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
    public partial class _9GodownEntry : Form
    {
        public _9GodownEntry()
        {
            InitializeComponent();
            textBox4.Text = MODEL.class1.staff.ID;
            textBox3.Text = System.DateTime.Now.ToLongDateString();
        }

        private void _9GodownEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //存主表
            MODEL.InStockMain instockmain = new MODEL.InStockMain();
            instockmain.InID = textBox1.Text;
            instockmain.QAID = comboBox1 .Text;
            instockmain.Date = textBox3.Text;
            instockmain.Operator = textBox4.Text;
            DAL.InStock.InPutMain(instockmain);
            //存从表并改变库存
            for(int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                int curNum = i + 1;
                MODEL.InStockdetail instockdetail = new MODEL.InStockdetail();
                instockdetail.InID = textBox1.Text;
                instockdetail.GoodID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                instockdetail.GoodName= dataGridView1.Rows[i].Cells[1].Value.ToString();
                instockdetail.Amount=System.Convert.ToDouble( dataGridView1.Rows[i].Cells[2].Value.ToString());
                if (CplHelper.IsDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                    instockdetail.goodinprice = System.Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
                else
                {
                    MessageBox.Show("第" + curNum.ToString() + "行价格不正确");
                    return;
                }
                //instockdetail.Type= dataGridView1.Rows[i].Cells[4].Value.ToString();
                instockdetail.Supplier= dataGridView1.Rows[i].Cells[4].Value.ToString();
                if(CplHelper.IsNull(dataGridView1.Rows[i].Cells[5].Value.ToString()))
                {
                    MessageBox.Show("请输入第" + curNum.ToString() + "仓库信息");
                    return;
                }
                instockdetail.Inventory= dataGridView1.Rows[i].Cells[5].Value.ToString();
                DAL.InStock.InputDetail(instockdetail);
                DAL.Inventory.ChangeNum(instockdetail);
            }
            this.TopMost = false;
            MessageBox.Show("已保存成功");
            if (Communal.mapDiag == null ||Communal.mapDiag.isClosed)
            {
                Communal.mapDiag = new realTimeShow();
                Communal.mapDiag.isClosed = false;
            }
            Communal.mapDiag.goodsNum = 1;
            Communal.mapDiag.Show();
            Communal.mapDiag.goodsOnTableAnimate();
            
        }

        private void _9GodownEntry_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
            this.dataGridView1.Font = new Font("宋体", 10);
            textBox1.Text = MODEL.AddID.Change(DAL.getnewest.InID());
            DataTable table=DAL.getnewest.allQAID().Tables[0];
            for(int i=0;i<table.Rows.Count;i++)
            {
                //MessageBox.Show(table.Rows[i][0].ToString());
                comboBox1.Items.Add(table.Rows[i][0].ToString());
            }
           // comboBox1.DataSource = table;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
