using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuleTech.Gen2;
using ModuleTech;
using ModuleLibrary;
using System.Timers;
using System.Threading;
using System.Collections;
using System.Text.RegularExpressions;

namespace RFID_Read
{
    public partial class Form1 : Form
    {
        public static readonly string ConAdr = "192.168.0.101";//connect address
        public static readonly int antNum = 1;//antnna count
        public static readonly int genSession = 1;
        public static readonly int readDur = 300;//read duration
        public bool isGpoSet = false; //set Gpo
        public string accPass = "00000000";//access password
        public static readonly uint EpcAdr = 2; //Epc read start
        public static readonly byte EpcEnd = 8; //Epc data count
        public static readonly uint TIDStart = 0; //User read start
        public static readonly byte TIDEnd = 12; //user read count
        public static readonly int readCount = 5; //标签阅读次数
        public static readonly double db = 0.9;
        public Reader rdr = null;
        public double consumeNum = 0;
        private string curEPC = "CC";
        System.Timers.Timer autoAcq = new System.Timers.Timer();
        Mutex tagMutex = new Mutex();
        List<tagInfo> tagList = new List<tagInfo>();
        List<goodInfo> goodsList = new List<goodInfo>();
        List<goodDetail> goodsDetailList = new List<goodDetail>();
        BindingSource bs = new BindingSource();
        UserInfo meb = null;
        Dictionary<string, ArrayList> details_Num = new Dictionary<string, ArrayList>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdr = Reader.Create(ConAdr, ModuleTech.Region.NA, (ReaderType)antNum);
            rdrParmSet();
            bs.DataSource = new BindingList<goodInfo>(goodsList);
            Items_Details.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Items_Details.MultiSelect = false;
            Items_Details.DataSource = bs;
            Items_Details.ReadOnly = true;
            Items_Details.AllowUserToAddRows = false;
            autoAcq.Interval = 100;
            autoAcq.Enabled = true;
            autoAcq.Elapsed += new ElapsedEventHandler(autoAcqData_Elapsed);
            autoAcq.AutoReset = true;
        }
        private void rdrParmSet() // read param set
        {
            if (rdr != null)
            {
                uint PassWord = uint.Parse(accPass, System.Globalization.NumberStyles.AllowHexSpecifier);
                //rdr.ParamSet("AccessPassword", PassWord);
                int[] ants = new int[] { 1 };
                //SimpleReadPlan searchPlan = new SimpleReadPlan(ants);
                rdr.ParamSet("ReadPlan", new SimpleReadPlan(TagProtocol.GEN2, ants));
                rdr.ParamSet("CheckAntConnection", false);
                rdr.ParamSet("Gen2Session", (Session)0);
                AntPower[] apwr = new AntPower[1];
                apwr[0].AntId = (byte)1;
                apwr[0].WritePower = (ushort)((int)rdr.ParamGet("RfPowerMax") *db );
                apwr[0].ReadPower = (ushort)((int)rdr.ParamGet("RfPowerMax") * db);
                rdr.ParamSet("AntPowerConf", apwr);
                //rdr.GPOSet(1, false);
            }
        }
        // for each tag, discriminate it is member or good, then change details.
        private void updateTagData(TagReadData tag) 
        {
            string EBdData = tag.EPCString;
            int isMem = EBdData.IndexOf("A");
            if (isMem == 0)
            {
                curEPC = EBdData;
                meb = DAL.getMemDetailByID(EBdData);
                meb.EPCStr = EBdData;
                if (ID_Text.InvokeRequired)
                {
                    Action<string> IDDel = (x) =>
                    {
                        ID_Text.Text = x.ToString();
                    };
                    ID_Text.Invoke(IDDel, meb.name);
                }
                else
                {
                    ID_Text.Text = meb.ID;
                }
            }
            else
            {
                byte[] TIDByte = tag.EbdData;
                string TIDStr = Encoding.ASCII.GetString(TIDByte);
                goodDetail good = DAL.getDetailByID(TIDStr);
                goodsDetailList.Add(good);
                if (details_Num.ContainsKey(good.name))
                {
                    ArrayList temp = details_Num[good.name];
                    temp[1] = (int)temp[1] + 1;
                    temp[0] = (double)temp[0] + good.cost;
                }
                else
                {
                    ArrayList temp = new ArrayList();
                    temp.Add(good.cost);
                    temp.Add(1);
                    details_Num.Add(good.name, temp);
                }

            }
        }
        private byte[] strCovertToDeciByte(string temp)
        {
            byte[] filterbytes = Encoding.ASCII.GetBytes(temp);

            return filterbytes;
        }
        //private void setUserData(string cost)
        //{
        //    string binarystr = meb.EPCStr;
        //    Gen2TagFilter filter = new Gen2TagFilter(binarystr.Length, strCovertToDeciByte(binarystr), ModuleTech.Gen2.MemBank.EPC, 32, false);
        //    string datastr = "";
        //    if(cost.Length <= 8)
        //    {
        //        for(int i = cost.Length; i <8; i++)
        //        {
        //            cost += "F";
        //        }
        //        datastr = cost;
        //    }
        //    datastr = "0x44445555";
        //    ushort[] writedata = new ushort[4];
        //    for (int a = 0; a < writedata.Length; ++a)
        //        writedata[a] = ushort.Parse(datastr.Substring(a * 4, 4), System.Globalization.NumberStyles.AllowHexSpecifier);
        //    rdr.WriteTagMemWords(filter,MemBank.USER,Convert.ToInt32(userStart),writedata);
        //}
        
        private void refreshDataView() // binding source change
        {
            consumeNum = 0;
            foreach (var detail in details_Num)
            {
                ArrayList goodNum = detail.Value;
                goodInfo temp = new goodInfo(detail.Key,Convert.ToDouble(goodNum[0]),(int)goodNum[1]);
                consumeNum += temp.tPrice;
                goodsList.Add(temp);
                //BindingList<goodInfo> temp =

                if (Items_Details.InvokeRequired)
                {
                    Action listDel = () =>
                    {
                        bs.DataSource = new BindingList<goodInfo>(goodsList);
                        Items_Details.Refresh();
                    };
                    Items_Details.Invoke(listDel);
                }
                else
                {
                    bs.DataSource = new BindingList<goodInfo>(goodsList);
                    Items_Details.Refresh();
                }
                if (Cost_Text.InvokeRequired)
                {
                    Action<string> CostDel = (x) => {
                        Cost_Text.Text = x.ToString();
                    };
                    Cost_Text.Invoke(CostDel, consumeNum.ToString());
                }
                else
                {
                    Cost_Text.Text = consumeNum.ToString();
                }
            }
            double bal = meb.balance - consumeNum;
            foreach (goodDetail goodTemp in goodsDetailList)
            {
                ArrayList detail = details_Num[goodTemp.name];
                DAL.updateMemCostDetail(new costInfo(meb.ID, goodTemp.ID, DateTime.Now.ToString(), DAL.getBillNumber(),Convert.ToInt32(detail[1]), Convert.ToDouble(detail[0]) / Convert.ToInt32(detail[1]), Convert.ToDouble(detail[0])));
            }
            DAL.updateMemBalance(meb.ID, bal);
            //setUserData(bal.ToString());
        }
        //用户离开后刷新页面内容为空
        private void initialAllInfo()
        {
            meb = null;
            tagList.Clear();
            goodsDetailList.Clear();
            details_Num.Clear();
            goodsList.Clear();
            if (Items_Details.InvokeRequired)
            {
                Action listDel = () =>
                {
                    bs.DataSource = new BindingList<goodInfo>(goodsList);
                    Items_Details.Refresh();
                };
                Items_Details.Invoke(listDel);
            }
            else
            {
                bs.DataSource = new BindingList<goodInfo>(goodsList);
                Items_Details.Refresh();
            }
            if (Cost_Text.InvokeRequired)
            {
                Action<string> CostDel = (x) => {
                    Cost_Text.Text = x.ToString();
                };
                Cost_Text.Invoke(CostDel,"");
            }
            else
            {
                Cost_Text.Text = "";
            }
            if (ID_Text.InvokeRequired)
            {
                Action<string> IDDel = (x) =>
                {
                    ID_Text.Text = x.ToString();
                };
                ID_Text.Invoke(IDDel,"");
            }
            else
            {
                ID_Text.Text = "";
            }
        }
        //用户离开后发送邮件
        private bool sendDataToUser()
        {
            string data = "";
            data += "尊敬的" + meb.name + "您好，您的消费情况如下：\n";
            for(int i = 0; i < goodsList.Count; i++)
            {
                data += goodsList[i].name + "  " + goodsList[i].uPrice.ToString() + "  " + goodsList[i].num + " " + goodsList[i].tPrice.ToString() + "\n";
            }
            data += "欢迎您的下次光临！";
            if (EmailHelper.sendEmail(meb.number, "消费清单", data))
                return true;
            return false;
        }
        private void autoAcqData_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(rdr != null)
            {
                try
                {
                    tagMutex.WaitOne();
                    byte[] binaryStr = ByteFormat.FromHex(curEPC);
                    Gen2TagFilter filter = new Gen2TagFilter(ByteFormat.FromHex(curEPC), ModuleTech.Gen2.MemBank.EPC, 32, false);
                    rdr.ParamSet("Singulation", filter);
                    for (int i = 0; i < readCount; i++)
                    {
                        TagReadData[] tempData = rdr.Read(200);
                        if (tempData.Length != 0)
                        {
                            tagMutex.ReleaseMutex();
                            return;
                        }
                    }
                    if(meb != null)
                    {
                        initialAllInfo();
                    }
                    rdr.ParamSet("Singulation", null);
                    EmbededCmdData ecd = new EmbededCmdData(MemBank.TID, TIDStart, TIDEnd);
                    rdr.ParamSet("EmbededCmdOfInventory", ecd);
                    for (int i = 0; i < readCount; i++)
                    {
                        TagReadData[] tagDatas = rdr.Read(200);
                        if (tagDatas.Length != 0)
                        {
                            foreach (TagReadData tag in tagDatas)
                            {
                                bool isRead = false;
                                foreach (tagInfo temp in tagList)
                                {
                                    if (temp.epcid == tag.EPCString)
                                        isRead = true;
                                }
                                if (!isRead)
                                {
                                    updateTagData(tag);
                                    tagList.Add(new tagInfo(tag));
                                }
                            }
                        }
                    }
                    if (meb != null)
                    {
                        refreshDataView();
                        if (!sendDataToUser()) {
                            MessageBox.Show("发送失败");
                        }
                        else
                        {
                            MessageBox.Show("发送成功,用户可以通过！");
                        }
                    }
                    tagMutex.ReleaseMutex();
                    //autoAcq.Enabled = false;
                }
                catch(OpFaidedException exxx)
                {
                    //MessageBox.Show("read wrong");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
    public class tagInfo
    {
        public tagInfo(string epc, int rcnt, int ant, byte[] emd)
        {
            epcid = epc;
            readcnt = rcnt;
            antid = ant;
            ebdata = emd;
        }
        public tagInfo(TagReadData tag)
        {
            epcid = tag.EPCString;
            readcnt = tag.ReadCount;
            antid = tag.Antenna;
            ebdata = tag.EPC;
        }
        public string epcid;
        public int readcnt;
        public int antid;
        public byte[] ebdata;
    }
    public class goodInfo
    {
        public string name{get;set;}
        public double uPrice { get; set; }
        public int num { get; set; }
        public double tPrice { get; set; }
        public goodInfo(string name,double uPrice,int num)
        {
            this.name = name;
            this.uPrice = uPrice;
            this.num = num;
            this.tPrice = this.uPrice * this.num;
        }
        public goodInfo()
        {

        }
    }
}
