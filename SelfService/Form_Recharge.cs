using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hit.RFID;
using System.Timers;
using System.Threading;
using Login;
namespace SelfService
{
    public partial class Form_Recharge : Form
    {
        public Form_Recharge()
        {
            InitializeComponent();
        }
        //窗体大小变化时，控件位置随着变化
        //private void Form_Recharge_Resize(object sender, EventArgs e)
        //{
        //    //控件距离界面上边缘的高度
        //    label_balance.Top = Height / 5;
        //    textBox_balance.Top = Height / 5;

        //    label_name.Top = 2 * Height / 5;
        //    textBox_name.Top = 2 * Height / 5;

        //    label_sum.Top = 3 * Height / 5;
        //    textBox_sum.Top = 3 * Height / 5;

        //    button_enter.Top = 4 * Height / 5;
        //    //控件左边框据界面左边框的距离
        //    label_balance.Left = Width / 20;
        //    textBox_balance.Left = Width / 5;

        //    label_name.Left = Width / 20;
        //    textBox_name.Left = Width / 5;

        //    label_sum.Left = Width / 20;
        //    textBox_sum.Left = Width / 5;

        //    label_tips.Left = Width / 3;
        //    button_enter.Left = 2 * Width / 5;
        //    //label_balance.Width = Width / 2;//控件宽度为界面的1/2；
        //    //label_balance.Height = Height * 2 / 3;//控件高度为界面的2/3；

        //}
        //***************************Anhui*********************************************
        UHFReaderHelper reader = null;
        System.Timers.Timer ReadEPCThread = new System.Timers.Timer();
        private void Form_Recharge_Load(object sender, EventArgs e)
        {
            //add time to check card every 1000 ms
            ReadEPCThread.Interval = 1000;
            ReadEPCThread.Enabled = true;
            ReadEPCThread.Elapsed += new ElapsedEventHandler(AutoReadEPC_Elapsed);
            ReadEPCThread.AutoReset = true;
        }
        Mutex mutex = new Mutex();
        MODEL.UserInfo user = null;
        // timer event
        private void AutoReadEPC_Elapsed(object sender, ElapsedEventArgs e)
        {
            mutex.WaitOne();
            if (reader == null)
            {
                reader = new UHFReaderHelper();
                reader.Connect();
            }
            if ((reader.isConnected == 1) || ((reader.isConnected == -1) && (reader.Connect())))
            {
                if (reader.ReadEPC() != "")
                {
                    user = DAL.InStock.getMemDetailByID(reader.ReadEPC().Replace("A", ""));
                    if (textBox_name.InvokeRequired && textBox_balance.InvokeRequired)
                    {
                        Action<string> balActionDel = (string x) => {
                            this.textBox_balance.Text = x;
                        };
                        this.textBox_balance.Invoke(balActionDel, user.balance.ToString());
                        Action<string> nameActionDel = (x) => { this.textBox_name.Text = x.ToString(); };
                        this.textBox_name.Invoke(nameActionDel, user.name.ToString());
                    }
                    else
                    {
                        this.textBox_balance.Text = user.balance.ToString();
                        this.textBox_name.Text = user.name.ToString();
                    }
                    ReadEPCThread.Enabled = false;
                    mutex.ReleaseMutex();
                    return;
                }
            }
            mutex.ReleaseMutex();
        }
        private bool WriteBalanceToTab(string balance)
        {
            return true;
        }
        /* entry user charge num to his card
         * return 1 if charge success
         * return -1 if connect ocur wrong expression
         * return 0 while charge ocur something wrong
         */
        private int MemCardInfEntry()
        {
            int returnV = 0;
            if (reader == null)
            {
                reader = new UHFReaderHelper();
                if (!reader.Connect())
                {
                    returnV = -1;
                    return returnV;
                }
            }
            if (reader.WriteUserData(textBox_sum.Text.Trim()))
            {
                string balance = Convert.ToString(double.Parse(textBox_balance.Text) + double.Parse(textBox_sum.Text));
                if (WriteBalanceToTab(balance))
                    returnV = 1;
            }
            return returnV;
        }
        private bool modifyBal()
        {
            double bal = Convert.ToDouble(textBox_balance.Text);
            bal += Convert.ToDouble(textBox_sum.Text);
            if(user != null)
            {
                DAL.InStock.updateMemBalance(user.ID, bal);
                MODEL.RechargeRecord record = new MODEL.RechargeRecord();
                record.MemCardID = user.ID;
                record.MemName = textBox_name.Text;
                record.RechargeAmount = Convert.ToDouble(textBox_sum.Text);
                record.AmountAfter = Convert.ToDouble(textBox_balance.Text);
                record.Operator = user.ID;
                record.RechargeTime = DateTime.Now.ToLongDateString();
                DAL.recharge.InputRecord(record);
                return true;

            }
            else
            {
                return false;
            }

        }
        //***************************************************************************
        private void button_enter_Click(object sender, EventArgs e)
        {
            //充值成功直接退出页面
            if(CplHelper.IsNull(textBox_balance.Text) || CplHelper.IsNull(textBox_name.Text) || CplHelper.IsNull(textBox_sum.Text))
            {
                MessageBox.Show("信息录入不全!");
                return;
            }
            if (!CplHelper.IsDecimal(textBox_sum.Text))
            {
                MessageBox.Show("充值金额输入错误!");
                return;
            }
            if (modifyBal())
            {
                
                MessageBox.Show("充值成功！");
            }
            else
            {
                MessageBox.Show("充值失败！");
            }
            
            
            //DAL.Recharge.Charge(, r.RechargeAmount);
           // DAL.Recharge.InputRecord(r);
        }
    }
}
