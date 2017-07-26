using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class ChargeRecord : Form
    {
        public static int state=0;

        public ChargeRecord()
        {
            InitializeComponent();
        }

        public void Show2()
        {
            label1.Visible = true;
            button1.Visible = true;
        }

        public void ChangeName()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "会员卡号";
            dataGridView1.Columns[1].HeaderCell.Value = "姓名";
            dataGridView1.Columns[2].HeaderCell.Value = "充值金额";
            //dataGridView1.Columns[3].HeaderCell.Value = "充值前金额";
            //dataGridView1.Columns[3].HeaderCell.Value = "充值后金额";
            dataGridView1.Columns[3].HeaderCell.Value = "时间";
            dataGridView1.Columns[4].HeaderCell.Value = "操作员";
        }

        private void 按编号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 1;
            Show2();
            dateTimePicker1.Visible = false;
            textBox1.Visible = true;
            label1.Text = "请输入会员卡号";
            dataGridView1.Location = new Point(10, 100);
        }

        private void ChargeRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }

        private void 按时间查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state =2;
            Show2();
            dateTimePicker1.Visible = true;
            textBox1.Visible = false;
            label1.Text = "请选择查询日期";
            dataGridView1.Location = new Point(10, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state==1)
            {
                dataGridView1.DataSource = DAL.class1.QueryRechargebyID(textBox1.Text).Tables[0];
                ChangeName();
            }
            else if(state==2)
            {
                dataGridView1.DataSource = DAL.class1.QueryRechargebydate(dateTimePicker1.Text).Tables[0];
                ChangeName();
            }
            for (int i = 0; i < 5; i++)
            {
                this.dataGridView1.Columns[i].Width = (dataGridView1.Width -45)/ 5;
            }

        }

        private void ChargeRecord_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.dataGridView1.Font = new Font("宋体", 10);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
            
        }
    }
}
