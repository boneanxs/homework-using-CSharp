using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;
using Login;
namespace MIS
{
    public partial class PlanFloor : Form
    {

        public PlanFloor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private System.Threading.Thread _th = null; // 开启搜索线程
        private bool isStart = false;//是否开始搜索
        private static readonly string IP_Adr = "ws://192.168.0.151:9001/";//localsense 定位地址
        private static readonly int readSize = 60;
        private static readonly int singRSize = 29;
        private static readonly int picWid = 579;
        private static readonly int picHei = 613;
        private Mutex socMutex = new Mutex();
        private byte[] data = new byte[readSize];//接收数据存放处
        private int RFIDID = 0;
        private int CpLen = 21;
        //绘制得到的用户点
        MyPoint prePoint = new MyPoint(0, 0);
        MyPoint curPoint = new MyPoint(0.00,0.00);
        Bitmap traceB = new Bitmap(picWid, picHei);
        private void PlanFloor_Load(object sender, EventArgs e)
        {
            string temp = Application.StartupPath;
            //MessageBox.Show(Application.StartupPath);
            Bitmap b = new Bitmap(Application.StartupPath + @"\Resources\map.png");
            this.graph.Image = b;
            this.loc_Icon.BackColor = Color.Transparent;
            this.loc_Icon.Parent = this.traceGraph;
            this.traceGraph.Parent = this.graph;
            this.loc_Icon.Visible = false;
            this.traceGraph.Image = traceB;
        }
        private void setLoc(MyPoint loc)
        {
            Point temp = new Point(Convert.ToInt32(loc.dx + 53), Convert.ToInt32(loc.dy + 45));
            if (this.loc_Icon.InvokeRequired)
            {
                Action<Point> draw = (x) =>
                {
                    if (isClosed) return;
                    this.loc_Icon.Location = x;
                };
                if (isClosed) return;
                this.loc_Icon.Invoke(draw, temp);
            }
            else
            {
                if (isClosed) return;
                this.loc_Icon.Location = temp;
            }
        }
        WebSocket socket = null;
        
        private string[] copyStrArWithLen(string[] preStr, int start)
        {
            string[] retunAr = new string[CpLen];
            for(int i = start; i< start + CpLen; i++)
            {
                retunAr[i - start] = preStr[i];
            }
            return retunAr;
        }
        MyPoint curUsr = null;
        private void asyFun(int id)
        {
            if(socket == null)
            {
                socket = new WebSocket(IP_Adr, "localSensePush-protocol");
            }
            socket.OnMessage += (sender, e) => {
                try
                {
                    socMutex.WaitOne();
                    string[] temp = e.Data.Split('-');
                    if (temp[0] == "CC" && temp[1] == "5F" && temp[2] == "01")
                    {
                        int num = Convert.ToInt32(temp[3], 16);
                        for (int i = 0; i < num; i++)
                        {
                            string[] subTemp = copyStrArWithLen(temp, 4 + i * CpLen);
                            int tempID = Convert.ToInt32(subTemp[0] + subTemp[1], 16);
                            if (tempID == id)
                            {
                                curUsr = new MyPoint(Convert.ToInt32(subTemp[2] + subTemp[3] + subTemp[4] + subTemp[5], 16),
                                                   Convert.ToInt32(subTemp[6] + subTemp[7] + subTemp[8] + subTemp[9], 16)
                                    /*Convert.ToInt32(subTemp[10] + subTemp[11] + subTemp[12] + subTemp[13], 16)*/);
                            }
                        }
                    }
                    socMutex.ReleaseMutex();
                }
                catch
                {

                }
            };
            socket.Connect();
            
        }
        bool isChecked = false;
        private void drawPos()
        {
            while (isStart)
            {
                socMutex.WaitOne();
                if (curUsr != null)
                {
                    if (!isChecked)
                    {
                        MessageBox.Show("查询成功");
                        if (loc_Icon.InvokeRequired)
                        {
                            Action VisAc = () =>
                            {
                                if (isClosed) return;
                                this.loc_Icon.Visible = true;
                            };
                            if (isClosed) return;
                            loc_Icon.Invoke(VisAc);
                        }
                        else
                        {
                            loc_Icon.Visible = true;
                        }
                    }
                    isChecked = true;
                    if (prePoint.dx == 0 && prePoint.dy == 0)
                    {
                        curPoint = new MyPoint(325 * (935.5 - curUsr.dx - 28) / 935.5 + 189.5, 0.34601 * (curUsr.dy - 35) - 65);
                        prePoint = new MyPoint(curPoint.dx, curPoint.dy);
                        setLoc(curPoint);
                        prePoint = curPoint;
                    }
                    else
                    {
                        curPoint = new MyPoint(325 * (935.5 - curUsr.dx - 28) / 935.5 + 189.5, 0.34601 * (curUsr.dy - 35) - 65);
                        setLoc(curPoint);
                        prePoint = curPoint;
                    }
                }
                socMutex.ReleaseMutex();
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                
                if (RfID_ID.Text.Trim() != "")
                {
                    if (CplHelper.IsMemIdRight(RfID_ID.Text))
                    {
                        string RFIDID = DAL.InStock.getARFIDInfo(RfID_ID.Text.Trim());
                        if (RFIDID != "")
                        {
                            isStart = true;
                            asyFun(int.Parse(RFIDID));
                            _th = new System.Threading.Thread(drawPos);
                            _th.Start();
                        }
                        else
                        {
                            MessageBox.Show("没有找到该会员ID");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("会员ID不正确!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("请输入会员标签序号");
                    return;
                }
            }
            else
            {
                
                if (socket != null)
                {
                    socket.Close();
                    socket = null;
                }
                isChecked = false;
                _th.Abort();
                isStart = false;
                MessageBox.Show("关闭成功");
            }
            
        }

        private void graph_Click(object sender, EventArgs e)
        {

        }
        private class MyPoint
        {
            //public int x { get; set; }
            //public int y { get; set; }
            //public int z { get; set; }
            public double dx{get;set;}
            public double dy { get; set; }
            //public MyPoint(int x, int y, int z)
            //{
            //    this.x = x;
            //    this.y = y;
            //    this.z = z;
            //}
            public MyPoint(double x, double y)
            {
                this.dx = x;
                this.dy = y;
            }
        }
        bool isClosed = false;
        private void PlanFloor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isStart)
            {
                MessageBox.Show("为防止程序冲突，请关闭搜寻");
                e.Cancel = true;
                return;
            }
            isClosed = true;
            socMutex.Close();
            
            if (socket != null)
            {
                socket.Close();
            }
            isChecked = false;
            _th.Abort();
        }
    }
}
