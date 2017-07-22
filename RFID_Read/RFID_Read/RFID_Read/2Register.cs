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
namespace HomePage
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        
        
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Communal.h.AllButtonEnabled();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxSex.Items.Add("男");
            BoxSex.Items.Add("女");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Communal.h.AllButtonEnabled();
            //MODEL.Member m = new MODEL.Member();
            //m.MemName = txtMemName.Text;
            //m.MemSex = BoxSex.Text;
            //m.IDCard = txtIdcard.Text;
            //m.MemCardID = txtMemID.Text;
            //m.Memtel = txtTel.Text;
            //m.Memacount = Convert.ToDouble(txtAccount.Text);
            //DAL.class1.InputMember(m);
            //**************Anhui**********************
            if (AddInfoToCard())
            {
                MessageBox.Show("注册成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("请确认将卡添加到读卡器上！");
            }
            //********************************************************
            //
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        //***********************Anhui**************************************
        private bool AddInfoToCard()
        {
            bool returnVal = false;
            UHFReaderHelper reader = new UHFReaderHelper();
            if (reader.Connect())
            {
                string EPCData = txtMemID.Text;
                EPCData = "A" + EPCData;
                string UserData = txtAccount.Text;
                if (reader.WriteEPCData(EPCData) && reader.WriteUserData(UserData))
                    returnVal = true;
            }
            return returnVal;
        }
        //****************************************************************
        //private void Register_Load(object sender, EventArgs e)
        //{

        //}
    }  
}
