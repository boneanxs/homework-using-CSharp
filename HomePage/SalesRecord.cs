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
    public partial class SalesRecord : Form
    {
        public int state = 0;

        public SalesRecord()
        {
            InitializeComponent();
        }

        private void SalesRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            MIS.Communal.h.AllButtonEnabled();
        }

        private void SalesRecord_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
            dataGridView1.Font = new Font("宋体", 10);
        }

        private void 按名称查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
            button1.Visible = true;
            state = 1;
            label1.Text = "请输入商品名称";
            dataGridView1.Location = new Point(50, 90);
        }
        private void 按日期查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 2;
            label1.Visible = true;
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
            button1.Visible = true;
            label1.Text = "请选择日期";
            dataGridView1.Location = new Point(50, 90);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case 1:
                    {
                        dataGridView1.DataSource = DAL.SellInfo.QuerybyGoodName(textBox1.Text).Tables[0];
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = DAL.SellInfo.QuerybyDate(dateTimePicker1.Text).Tables[0];
                        break;
                    }
            }
            for (int i = 0; i < 4; i++)
            {
                this.dataGridView1.Columns[i].Width = (dataGridView1.Width - 45) / 4;
            }
        }
    }
}
