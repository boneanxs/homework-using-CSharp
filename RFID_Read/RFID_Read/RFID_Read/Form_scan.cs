using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Hit.RFID;

namespace HomePage
{
    public partial class Form_scan : Form
    {
        public Form_scan()
        {
            InitializeComponent();
        }

        private void button_scanned_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定扫描完成并生产入库单");
        }
        //******************ANhui************************************************
        UHFReaderHelper reader = null;
        System.Timers.Timer ReadTIDThread = new System.Timers.Timer();
        string curTidStr = "";
        private bool scanRFIDInfo()
        {
            string goodsID = comboBox_goodsid.Text;
            if (reader.isConnected == 1)
            {
                if (reader.WriteEPCData(goodsID))
                    return true;
                else
                    return false; ;
            }
            else
                MessageBox.Show("请确认读卡器连接是否成功");
            return false;
        }
        private void AutoReadTID_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (reader == null)
            {
                reader = new UHFReaderHelper();
                reader.Connect();
            }
            if (reader.isConnected == 1)
            {
                if (curTidStr != reader.readTIDData())
                {
                    curTidStr = reader.readTIDData();
                    if (this.textBox_rfid.InvokeRequired)
                    {
                        Action<string> textDel = (string x) =>
                        {
                            this.textBox_rfid.Text = x;
                        };
                        this.textBox_rfid.Invoke(textDel,curTidStr);
                    }
                    else
                    {
                        this.textBox_rfid.Text = reader.readTIDData();
                    }
                }
            }
        }
        private void Form_scan_Load(object sender, EventArgs e)
        {
            ReadTIDThread.Interval = 1000;
            ReadTIDThread.Enabled = true;
            ReadTIDThread.Elapsed += new ElapsedEventHandler(AutoReadTID_Elapsed);
            ReadTIDThread.AutoReset = true;
        }
        //******************************Anhui*************************************
        private void btn_scan_Click(object sender, EventArgs e)
        {
            if (!scanRFIDInfo())
                MessageBox.Show("写入失败");
        }
    }
}
