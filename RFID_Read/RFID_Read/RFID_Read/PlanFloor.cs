using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Ichnographyn
{
    public partial class PlanFloor : Form
    {

        public PlanFloor()
        {
            InitializeComponent();
        }
        private System.Threading.Thread _th = null; // 开启搜索线程
        private bool isStart = false;//是否开始搜索
        private static readonly string IP_Adr = "ws://192.168.0.11:9700/";//localsense 定位地址
        private static readonly int readSize = 60;
        private static readonly int singRSize = 29;
        private Mutex socMutex = new Mutex();
        private byte[] data = new byte[readSize];//接收数据存放处
        private void graph_Paint(object sender, PaintEventArgs e)
        {
            //两个购物场所
            Graphics space = e.Graphics;
            Graphics line = e.Graphics;
            space.DrawRectangle(new Pen(Color.Black, 2), 0, 30, 900, 500);//超市平面区域
            line.DrawLine(new Pen(Color.Black, 2), 490, 110, 490, 450);//分割平面图的三条线
            line.DrawLine(new Pen(Color.Black, 2), 490, 30, 490, 65);
            line.DrawLine(new Pen(Color.Black, 2), 490, 495, 490, 530);
            //货架摆放
            int point_x1 = 80;//货架横坐标
            int point_x2 = 280;
            int point_x3 = 560;
            int point_x4 = 760;
            int point_y1 = 120;//货架纵坐标
            int point_y2 = 240;
            int point_y3 = 360;
            DrawStringRectangleF(e, point_x1, point_y1, "货架一");
            DrawStringRectangleF(e, point_x2, point_y1, "货架二");
            DrawStringRectangleF(e, point_x1, point_y2, "货架三");
            DrawStringRectangleF(e, point_x2, point_y2, "货架四");
            DrawStringRectangleF(e, point_x1, point_y3, "货架五");
            DrawStringRectangleF(e, point_x2, point_y3, "货架六");
            DrawStringRectangleF(e, point_x3, point_y1, "货架七");
            DrawStringRectangleF(e, point_x4, point_y1, "货架八");
            DrawStringRectangleF(e, point_x3, point_y2, "货架九");
            DrawStringRectangleF(e, point_x4, point_y2, "货架十");
            DrawStringRectangleF(e, point_x3, point_y3, "货架十一");
            DrawStringRectangleF(e, point_x4, point_y3, "货架十二");
        }
        //绘制得到的用户点
        private void drawUserPos(double x, double y)
        {
            //Graphics cir = ;

        }
        public void DrawStringRectangleF(PaintEventArgs e,int x,int y,string s)
        {
            // 显示货架编号
            String drawString = s;
            //字符居中
            StringFormat centerStringFormat = new StringFormat();
            centerStringFormat.Alignment = StringAlignment.Center;
            centerStringFormat.LineAlignment = StringAlignment.Center;
            // 字体、颜色
            Font drawFont = new Font("新宋体", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            // 矩形大小            
            int width = 100;
            int height = 50;
            RectangleF drawRect = new RectangleF(x, y, width, height);
            // 矩形颜色、位置
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, centerStringFormat);
        }

        private void PlanFloor_Load(object sender, EventArgs e)
        {

        }
        private async Task receiveData(ClientWebSocket socket)
        {
            try
            {
                byte[] buffer = new byte[singRSize];
                int readTimes = 0;
                while (socket.State == WebSocketState.Open)
                {
                    var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                    }
                    else
                    {
                        buffer.CopyTo(data, readTimes * singRSize);
                        readTimes++;
                    }
                }
            }catch(Exception ee)
            {

            }
        }
        private async Task connect()
        {
            ClientWebSocket socket = null;
            try
            {
                socket = new ClientWebSocket();
                await socket.ConnectAsync(new Uri(IP_Adr), CancellationToken.None);
                await receiveData(socket);

            }catch(Exception ee)
            {

            }
        }
        private void asyFun()
        {
            socMutex.WaitOne();
            connect().Wait();
            
            socMutex.ReleaseMutex();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                if (RfID_ID.Text.Trim() != "")
                {
                    isStart = true;
                    _th = new System.Threading.Thread(asyFun);
                    _th.Start();
                }
                else
                {
                    MessageBox.Show("请选择RFID标签序号");
                }
            }
            else
            {
                isStart = false;
                _th.Abort();
            }
        }

        private void graph_Click(object sender, EventArgs e)
        {

        }
    }
}
