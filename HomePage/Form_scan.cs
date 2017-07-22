using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Timers;
using Hit.RFID;
using System.Threading;

namespace MIS
{

    public partial class Form_scan : Form
    {
        //public good[] goods;
        bool exist;

        public Form_scan()
        {
            InitializeComponent();
            
        }
        //********************anhui*************************************
        UHFReaderHelper reader = null;
        System.Timers.Timer ReadTIDThread = new System.Timers.Timer();
        string curTidStr = "";
        Mutex mutex = new Mutex();
        private bool scanRFIDInfo()
        {
            string goodsID = txtGoodID.Text;
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
            mutex.WaitOne();
            //MessageBox.Show("开始读取");
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
                   // MessageBox.Show(curTidStr);
                    if (this.textBox_rfid.InvokeRequired)
                    {
                        Action<string> textDel = (string x) =>
                        {
                            this.textBox_rfid.Text = x;
                        };
                        this.textBox_rfid.Invoke(textDel, curTidStr);
                    }
                    else
                    {
                        this.textBox_rfid.Text = reader.readTIDData();
                    }
                    //mutex.ReleaseMutex();
                    ReadTIDThread.Enabled = false;
                }
            }
            mutex.ReleaseMutex();
            
        }
        private void Form_scan_Load(object sender, EventArgs e)
        {
            DataTable table = DAL.getnewest.allQAID().Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cBoxQA.Items.Add(table.Rows[i][0].ToString());
            }
            textBox_worker.Text = MODEL.class1.staff.ID;
            textBox_time.Text = System.DateTime.Now.ToLongDateString();
            ReadTIDThread.Interval = 1000;
            ReadTIDThread.Enabled = true;
            ReadTIDThread.Elapsed += new ElapsedEventHandler(AutoReadTID_Elapsed);
            ReadTIDThread.AutoReset = true;
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
        }
        private void button_scanned_Click(object sender, EventArgs e)
        {
            //生成入库单
            if(dataGridView_scanned.Rows.Count == 0)
                MessageBox.Show("确定扫描完成并生产入库单");
            else
            {
                MessageBox.Show("扫描未完成，请扫描完所有信息");
                return;
            }
            Communal.instock = new _9GodownEntry();
            DataTable dt = new DataTable();
            dt = DAL.ConvertQAtoStock.Convert(cBoxQA.Text).Tables[0];
            for(int i=0;i<dt.Rows.Count;i++)
            {
                Communal.instock.dataGridView1.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), "", dt.Rows[i][3].ToString(),"");
            }
            Communal.instock.Show();
            //Communal.instock.comboBox1.Text = this.cBoxQA.Text;
            //List<good> a = new List<good>();
            //for (int i = 0; i < dataGridView_scanned.Rows.Count - 1; i++)
            //{
            //    exist = false;
            //    good g = new good(dataGridView_scanned.Rows[i].Cells[0].Value.ToString(), dataGridView_scanned.Rows[i].Cells[1].Value.ToString(), System.Convert.ToDouble(dataGridView_scanned.Rows[i].Cells[2].Value.ToString()));
            //    if (a.Count == 0)
            //    {
            //        a.Add(g);
            //    }
            //    else
            //    {
            //        for (int j = 0; j < a.Count; j++)
            //        {
            //            if (a[j].ID == g.ID)
            //            {
            //                a[j].Amount += g.Amount;
            //                exist = true;
            //            }
            //        }
            //        if (exist == false)
            //        {
            //            a.Add(g);
            //        }
            //    } 

            //}
            //    for (int i = 0; i < a.Count; i++)
            //    {
            //        Communal.instock.dataGridView1.Rows.Add(a[i].ID, a[i].Name, a[i].Amount);
            //    }
                this.Close();
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_scan_Click(object sender, EventArgs e)
        {

            if (!scanRFIDInfo())
            {
                MessageBox.Show("写入失败");
            }

            else
            {
                DAL.InStock.InPutGoodsRFID(txtGoodID.Text, textBox_rfid.Text);


                if (Convert.ToDouble(dataGridView_scanned.Rows.Count) > 1)
                {
                    //txtGoodID.Text = dataGridView_scanned.Rows[0].Cells[0].Value.ToString();
                    //txtGoodName.Text = dataGridView_scanned.Rows[0].Cells[1].Value.ToString();
                    dataGridView_scanned.Rows[0].Cells[2].Value = Convert.ToDouble(dataGridView_scanned.Rows[0].Cells[2].Value) - 1;
                    
                    if (Convert.ToDouble(dataGridView_scanned.Rows[0].Cells[2].Value) == 0)
                        dataGridView_scanned.Rows.Remove(dataGridView_scanned.Rows[0]);

                    if (Convert.ToDouble(dataGridView_scanned.Rows.Count) > 1)
                    {
                        txtGoodID.Text = dataGridView_scanned.Rows[0].Cells[0].Value.ToString();
                        txtGoodName.Text = dataGridView_scanned.Rows[0].Cells[1].Value.ToString();
                    }

                }
                MessageBox.Show("写入成功，请拿下RFID卡");
                Communal.mapDiag.goodsNum = 1;
                Communal.mapDiag.scanAnimate();
            }
            ReadTIDThread.Enabled = true;
        }

        private void label_goodstype_Click(object sender, EventArgs e)
        {

        }

        private void Form_scan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }

        private void cBoxQA_TextChanged(object sender, EventArgs e)
        {
            dataGridView_scanned.DataSource = DAL.ConvertQAtoStock.Convert(cBoxQA.Text).Tables[0];
            dataGridView_scanned.Columns[0].HeaderCell.Value = "商品编号";
            dataGridView_scanned.Columns[1].HeaderCell.Value = "商品名称";
            dataGridView_scanned.Columns[2].HeaderCell.Value = "商品数量";
            dataGridView_scanned.Columns[3].HeaderCell.Value = "供应商";
            txtGoodID.Text = dataGridView_scanned.Rows[0].Cells[0].Value.ToString();
            txtGoodName.Text = dataGridView_scanned.Rows[0].Cells[1].Value.ToString();
            //cBoxQA.Enabled = false;
        }

        private void textBox_rfid_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class good
    {
        public string ID;
        public string Name;
        public double Amount;
        public good() { }
        public good(string ID, string Name, double Amount)
        {
            this.ID = ID;
            this.Name = Name;
            this.Amount = Amount;
        }


    }
}
