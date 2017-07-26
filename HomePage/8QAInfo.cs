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
    public partial class _8QAInfo : Form
    {
        public static int state=0;

        public _8QAInfo()
        {
            InitializeComponent();
        }

        private void _8RNoteInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }
        
        public void show3()
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            dateTimePicker1.Visible = false;
        }

        public void ChangeName()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "质检单批号";
            dataGridView1.Columns[1].HeaderCell.Value = "商品号";
            dataGridView1.Columns[2].HeaderCell.Value = "商品名称";
            dataGridView1.Columns[3].HeaderCell.Value = "商品数量";
            dataGridView1.Columns[4].HeaderCell.Value = "供应商";
            dataGridView1.Columns[5].HeaderCell.Value = "日期";
            dataGridView1.Columns[6].HeaderCell.Value = "质检员";
        }

        private void 按收货单批号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show3();
            label1.Text = "请输入质检单号";
            state = 1;
            dataGridView1.Location = new Point(52, 115);
        }

        private void 按商品批号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show3();
            label1.Text = "请输入商品批号";
            state = 2;
            dataGridView1.Location = new Point(52, 115);
        }

        private void 按商品名称查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show3();
            label1.Text = "请输入商品名称";
            state =3;
            dataGridView1.Location = new Point(52, 115);
        }

        private void 按供应商查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show3();
            label1.Text = "请输入供应商名称";
            state = 4;
            dataGridView1.Location = new Point(52, 115);
        }

        private void 按收货时间查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 按质检时间查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            dateTimePicker1.Visible = true;
            textBox1.Visible = false;
            button1.Visible = true;
            label1.Text = "请输入质检时间";
            state = 5;
            dataGridView1.Location = new Point(52, 115);
        }

        private void 按操作员查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show3();
            label1.Text = "请输入质检员工号";
            state = 6;
            dataGridView1.Location = new Point(52, 115);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case 1:
                    {
                        if (CplHelper.IsQualityIDRight(textBox1.Text.Trim()))
                        {
                            dataGridView1.DataSource = DAL.class1.QuerybyQAID(textBox1.Text).Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("质检信息输入错误");
                            return;
                        }
                        break;
                    }
                case 2:
                    {
                        if (CplHelper.IsGoodsIdRight(textBox1.Text.Trim()))
                        {
                            dataGridView1.DataSource = DAL.class1.QuerybyGoodID(textBox1.Text).Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("商品ID错误");
                            return;
                        }
                        break;
                    }
                case 3:
                    {
                        dataGridView1.DataSource = DAL.class1.QuerybyGoodName(textBox1.Text).Tables[0];
                        break;
                    }
                case 4:
                    {
                        dataGridView1.DataSource = DAL.class1.QuerybySupplier(textBox1.Text).Tables[0];
                        break;
                    }
                case 5:
                    {
                        dataGridView1.DataSource = DAL.class1.QuerybyDate(dateTimePicker1.Text).Tables[0];
                        break;
                    }
                case 6:
                    {
                        dataGridView1.DataSource = DAL.class1.QuerybyOperator(textBox1.Text).Tables[0];
                        break;
                    }
            }
            ChangeName();
            for (int i = 0; i < 6; i++)
            {
                this.dataGridView1.Columns[i].Width = (dataGridView1.Width - 30) / 7;
            }
        }

        private void _8QAInfo_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
        }

        private void 审核并保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
