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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = DAL.SellInfo.QuerybuSupplier(comboBox_vendor.Text, DateTime.Now.ToLongDateString()).Tables[0];
            string s="";
            for (int i = 0; i < dataGridView2.Rows.Count-1;i++ )
            {
                for (int j = 0; j < 4; j++)
                {
                    s += dataGridView2.Rows[i].Cells[j].Value.ToString();
                    s += "  ";
                }
                s += '\n';
            }
            MessageBox.Show(s);
                EmailHelper.sendEmail("2423398883@qq.com", System.DateTime.Now.ToLongDateString(), s);
            /*确认无误后发送给供应商*/
            MessageBox.Show("发送成功");

        }

        private void Report_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            MIS.Communal.h.AllButtonEnabled();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DAL.SellInfo.QuerybuSupplier(comboBox_vendor.Text, System.DateTime.Now.ToLongDateString()).Tables[0];
            dataGridView2.Columns[0].HeaderCell.Value = "商品编号";
            dataGridView2.Columns[1].HeaderCell.Value = "商品名称";
            dataGridView2.Columns[2].HeaderCell.Value = "当日销售数量";
            dataGridView2.Columns[3].HeaderCell.Value = "销售日期";

        }
    }
}
