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
    public partial class _10GEInfo : Form
    {
        public static int state = 0;

        public _10GEInfo()
        {
            InitializeComponent();
        }

        private void _10GEInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }

        public void Show2()
        {
            label1.Visible = true;
            button1.Visible = true;
        }
        public void ShowText()
        {
            Show2();
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
        }
        public void ShowPicker()
        {
            Show2();
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
        }

        public void ChangeName()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "入库单号";
            dataGridView1.Columns[1].HeaderCell.Value = "商品号";
            dataGridView1.Columns[2].HeaderCell.Value = "商品名称";
            dataGridView1.Columns[3].HeaderCell.Value = "商品数量";
            dataGridView1.Columns[4].HeaderCell.Value = "供应商";
            dataGridView1.Columns[5].HeaderCell.Value = "入库日期";
            dataGridView1.Columns[6].HeaderCell.Value = "入库人员";
        }

        private void 按收货单批号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 1;
            ShowText();
            label1.Text = "请输入收货单号";
            dataGridView1.Location = new Point(15, 115);
        }

        private void 按商品批号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 2;
            ShowText();
            label1.Text = "请输入商品批号";
            dataGridView1.Location = new Point(15, 115);
        }

        private void 按商品名称查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 3;
            ShowText();
            label1.Text = "请输入商品名称";
            dataGridView1.Location = new Point(15, 115);
        }

        private void 按供应商查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 4;
            ShowText();
            label1.Text = "请输入供应商名称";
            dataGridView1.Location = new Point(15, 115);
        }
        private void 按收货时间查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 5;
            ShowPicker();
            label1.Text = "请输入收货日期";
            dataGridView1.Location = new Point(15, 115);
        }

        private void 按操作员查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 6;
            ShowText();
            label1.Text = "请输入入库人员ID";
            dataGridView1.Location = new Point(15, 115);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case 1:
                    {
                        dataGridView1.DataSource = DAL.InStock.QuerybyID(textBox1.Text).Tables[0];
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = DAL.InStock.QuerybyGoodID(textBox1.Text).Tables[0];
                        break;
                    }
                case 3:
                    {
                        dataGridView1.DataSource = DAL.InStock.QuerybyGoodName(textBox1.Text).Tables[0];
                        break;
                    }
                case 4:
                    {
                        dataGridView1.DataSource = DAL.InStock.QuerybySupplier(textBox1.Text).Tables[0];
                        break;
                    }
                case 5:
                    {
                        dataGridView1.DataSource = DAL.InStock.QuerybyDate(dateTimePicker1.Text).Tables[0];
                        break;
                    }
                case 6:
                    {
                        dataGridView1.DataSource = DAL.InStock.QuerybyOperator(textBox1.Text).Tables[0];
                        break;
                    }
            }
            ChangeName();
            for (int i = 0; i < 7; i++)
            {
                this.dataGridView1.Columns[i].Width = (dataGridView1.Width - 40) / 7;
            }
        }

        private void _10GEInfo_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
        }
    }
}
