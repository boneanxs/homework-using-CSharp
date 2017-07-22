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
using Login;
namespace MIS
{
    public partial class Register : Form
    {
        //public static System.FormatException e;
        public string state = "";

        public Register()
        {
            InitializeComponent();
        }
        
        
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxSex.Items.Add("男");
            BoxSex.Items.Add("女");
        }
        private bool AddInfoToCard()
        {
            bool returnVal = false;
            UHFReaderHelper reader = new UHFReaderHelper();
            if (reader.Connect())
            {
                string EPCData = txtMemID.Text;
                EPCData = "A" + EPCData;
                string UserData = txtAccount.Text;
                if (reader.WriteEPCData(EPCData))
                    returnVal = true;
            }
            return returnVal;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //information complete check
            if (CplHelper.IsNull(txtIdcard.Text) || CplHelper.IsNull(txtAccount.Text) || CplHelper.IsNull(txtMemID.Text)
                || CplHelper.IsNull(txtMemName.Text) || CplHelper.IsNull(txtTel.Text))
            {
                MessageBox.Show("信息录入不全！");
                return;
            }
            if (!CplHelper.IsEmail(txtTel.Text))
            {
                MessageBox.Show("邮箱格式错误!");
                return;
            }
            if(!CplHelper.IsDecimal(txtAccount.Text))
            {
                MessageBox.Show("金额格式不正确");
                return;
            }
            if(!CplHelper.IsSpecLen(txtIdcard.Text,18))
            {
                MessageBox.Show("身份证格式错误");
                return;
            }
            //*************************
            Communal.h.AllButtonEnabled();
            MODEL.Member m = new MODEL.Member();
            m.MemName = txtMemName.Text;
            m.MemSex = BoxSex.Text;
            m.IDCard = txtIdcard.Text;
            m.MemCardID = txtMemID.Text;
            m.Memtel = txtTel.Text;

            try { m.Memacount = Convert.ToDouble(txtAccount.Text); }
            catch
            {
                MessageBox.Show("未输入金额！");
                m.Memacount = 0;

            }
            if (AddInfoToCard())
            {
                MessageBox.Show("注册成功");
                m.Registtime = System.DateTime.Now.ToLongDateString();
                m.operateStaff = MODEL.class1.staff.ID;
                DAL.class1.InputMember(m);
                this.Close();
            }
            else
            {
                MessageBox.Show("请确认将卡添加到读卡器上！");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
            int IDpre = Convert.ToInt32(DAL.getnewest.MemID());
            IDpre +=1;
            txtMemID.Text = MODEL.AddID.Getid(IDpre);
            txtMemID.ReadOnly = true;
            button1.Text = state;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }  
}
