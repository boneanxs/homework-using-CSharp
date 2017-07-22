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
    public partial class Inventory : Form
    {
        int state=0;

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }

        public void show3()
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        public void ChangeName()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "商品编号";
            dataGridView1.Columns[1].HeaderCell.Value = "商品名称";
            dataGridView1.Columns[2].HeaderCell.Value = "商品数量";
        }

        private void 按名称查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 1;
            show3();
            label1.Text = "请输入商品名称";
            button1.Text = "确认查询";
            dataGridView1.Location = new Point(203, 100);
        }

        private void 按编号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 2;
            show3();
            label1.Text = "请输入商品编号";
            button1.Text = "确认查询";
            dataGridView1.Location = new Point(203, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case 1:
                    {
                        dataGridView1.DataSource = DAL.Inventory.QuerybyGoodName(textBox1.Text).Tables[0];
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = DAL.Inventory.QuerybyGoodID(textBox1.Text).Tables[0];
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            MODEL.Inventory inventory = new MODEL.Inventory();
                            inventory.GoodID= dataGridView1.Rows[i].Cells[0].Value.ToString();
                            inventory.GoodName= dataGridView1.Rows[i].Cells[1].Value.ToString();
                            inventory.Amount = System.Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());
                            DAL.Inventory.PanDian(inventory);
                        }
                        break;
                    }                 
            }
            ChangeName();
            for (int i = 0; i < 3; i++)
            {
                this.dataGridView1.Columns[i].Width = (dataGridView1.Width - 45) / 3;
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 3;
            label1.Text = "请在列表中修改商品的数量";
            button1.Text = "确认";
            show3();
            textBox1.Visible = false;
             dataGridView1.Location = new Point(203, 100);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
        }
    }
}
