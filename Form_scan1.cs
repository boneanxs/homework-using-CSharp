using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HomePage
{
    public class good
    {
        public string ID;
        public string Name;
        public double Amount;
        public good() { }
        public good(string ID,string Name,double Amount)
        {
            this.ID = ID;
            this.Name = Name;
            this.Amount = Amount;
        }
            

    }

    public partial class Form_scan : Form
    {
        //public good[] goods;
        bool exist;

        public Form_scan()
        {
            InitializeComponent();
            textBox_worker.Text = MODEL.class1.staff.ID;
            textBox_time.Text= System.DateTime.Now.ToLongDateString();
        }

        private void button_scanned_Click(object sender, EventArgs e)
        {
            //生成入库单
            MessageBox.Show("确定扫描完成并生产入库单");
            Communal.instock = new _9GodownEntry();
            Communal.instock.Show();
            Communal.instock.textBox2.Text = txtQAID.Text;
            List<good> a = new List<good>();
            for (int i = 0; i < dataGridView_scanned.Rows.Count - 1; i++)
            {
                exist = false;
                good g = new good(dataGridView_scanned.Rows[i].Cells[0].Value.ToString(), dataGridView_scanned.Rows[i].Cells[1].Value.ToString(), System.Convert.ToDouble(dataGridView_scanned.Rows[i].Cells[2].Value.ToString()));
                if (a is null)
                {
                    a.Add(g);
                }
                else
                {
                    for (int j = 0; j < a.Count; j++)
                    {
                        if (a[j].ID == g.ID)
                        {
                            a[j].Amount += g.Amount;
                            exist = true;
                        }
                    }
                    if (exist == false)
                    {
                        a.Add(g);
                    }
                } 

            }
                for (int i = 0; i < a.Count; i++)
                {
                    Communal.instock.dataGridView1.Rows.Add(a[i].ID, a[i].Name, a[i].Amount);
                }
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            dataGridView_scanned.Rows.Add(txtGoodID.Text, txtGoodName.Text,1);
        }

        private void label_goodstype_Click(object sender, EventArgs e)
        {

        }
    }
}
