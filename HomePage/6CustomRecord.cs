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
    public partial class _6CustomRecord : Form
    {
        private int state=0;

        public void ChangeName()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "会员卡号";
            dataGridView1.Columns[1].HeaderCell.Value = "姓名";
            dataGridView1.Columns[2].HeaderCell.Value = "商品类型";
            dataGridView1.Columns[3].HeaderCell.Value = "商品数量";
            dataGridView1.Columns[4].HeaderCell.Value = "单价";
            dataGridView1.Columns[5].HeaderCell.Value = "金额";
            dataGridView1.Columns[6].HeaderCell.Value = "购买时间";
        }

        public _6CustomRecord()
        {
            InitializeComponent();
        }

        private void _6CustomRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }

        private void 按日期查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "请选择查询日期";
            dateTimePicker1.Visible = true;
            textBox1.Visible = false;
            btn.Visible = true;
            state = 1;
            dataGridView1.Location = new Point(5, 80);
        }

        private void 按商品查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "请输入商品名称";
            dateTimePicker1.Visible = false;
            textBox1.Visible = true;
            btn.Visible = true;
            state = 2;
            dataGridView1.Location = new Point(5, 80);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(state==1)
            {
                dataGridView1.DataSource = DAL.class1.QueryCustomRecordbyId(textBox1.Text).Tables[0];
                ChangeName();
            }
            else if(state==2)
            {
                dataGridView1.DataSource = DAL.class1.QueryCustomRecordbyDate(dateTimePicker1.Text).Tables[0];
                ChangeName();
            }
        }

        private void _6CustomRecord_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
        }
    }
}
