using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;
namespace MIS
{
    public partial class match : Form
    {
        public match()
        {
            InitializeComponent();
        }


        private void create_Load(object sender, EventArgs e)
        {
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            if(CplHelper.IsNull(txtBox_id.Text) || CplHelper.IsNull(txtbox_rfid.Text))
            {
                MessageBox.Show("输入信息不完整!");
                return;
            }
            if(!CplHelper.IsMemIdRight(txtBox_id.Text))
            {
                MessageBox.Show("会员ID不正确!");
                return;
            }
            DAL.ActiveRFID.Input(txtBox_id.Text.Trim(), txtbox_rfid.Text.Trim());
            MessageBox.Show("匹配成功！");
        }

        private void match_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
        }
    }
}
