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
namespace SelfService
{
    public partial class Form_Recharge : Form
    {
        public Form_Recharge()
        {
            InitializeComponent();
        }
       //窗体大小变化时，控件位置随着变化
        private void Form_Recharge_Resize(object sender, EventArgs e)
        {
            //控件距离界面上边缘的高度
            label_balance.Top = Height / 5;        
            textBox_balance.Top = Height / 5;

            label_name.Top = 2* Height / 5;
            textBox_name.Top = 2* Height / 5;

            label_sum.Top= 3 * Height / 5;
            textBox_sum.Top= 3 * Height / 5;

            button_enter.Top = 4 * Height / 5;
            //控件左边框据界面左边框的距离
            label_balance.Left = Width / 20;
            textBox_balance.Left = Width / 5;

            label_name.Left = Width / 20;
            textBox_name.Left = Width / 5;

            label_sum.Left = Width / 20;
            textBox_sum.Left = Width / 5;

            label_tips.Left = Width / 3;
            button_enter.Left = 2*Width / 5;
            //label_balance.Width = Width / 2;//控件宽度为界面的1/2；
            //label_balance.Height = Height * 2 / 3;//控件高度为界面的2/3；

        }
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
        // timer event
        private void AutoReadEPC_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (reader == null)
            {
                reader = new UHFReaderHelper();
                reader.Connect();
            }
            if ((reader.isConnected == 1) || ((reader.isConnected == -1) && (reader.Connect())))
            {
                if (reader.ReadEPC() != "")
                {
                    if (textBox_name.InvokeRequired&&textBox_balance.InvokeRequired)
                    {
                        Action<string> balActionDel = (string x) => { 
                            string temp = x.Replace("F", "");
                            this.textBox_balance.Text = temp;
                        };
                        this.textBox_balance.Invoke(balActionDel, reader.ReadUser());
                        Action<string> nameActionDel = (x) => { this.textBox_name.Text = x.ToString(); };
                        this.textBox_balance.Invoke(nameActionDel, reader.ReadEPC());
                    }
                    else
                    {
                        this.textBox_balance.Text = reader.ReadUser();
                        this.textBox_name.Text = reader.ReadEPC();
                    }
                    ReadEPCThread.Enabled = false;
                }
            }
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
            if(reader == null)
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
            if (reader.WriteUserData(bal.ToString()))
            {
                return true;
            }
            return false;
        }
        //***************************************************************************
        private void button_enter_Click(object sender, EventArgs e)
        {
            //充值成功直接退出页面
           if(modifyBal())
           {
               MessageBox.Show("充值成功！当前金额为: " + reader.ReadUser().Replace("F",""));
           }
           else
           {
               MessageBox.Show("充值失败！");
           }
        }
    }
}
