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
    public partial class _7ReceivingNote : Form
    {
        MODEL.QAdetail qadetail = new MODEL.QAdetail();
        public _7ReceivingNote()
        {
            InitializeComponent();
            textBox3.Text = System.DateTime.Now.ToLongDateString();
        }

        private void _7ReceivingNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立主表
            MODEL.QAmain qamain = new MODEL.QAmain();
            qamain.QAID = textBox1.Text;
            qamain.Supplier = comboBox1.Text;
            qamain.Operator = MODEL.class1.staff.ID;
            qamain.Date = System.DateTime.Now.ToLongDateString();
            DAL.class1.InputQAmain(qamain);
            //建立从表
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int curNum = i + 1;
                MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
                qadetail.QAID = textBox1.Text;
                qadetail.GoodID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                qadetail.GoodName = dataGridView1.Rows[i].Cells[1].Value.ToString();
                qadetail.Unit = dataGridView1.Rows[i].Cells[2].Value.ToString();
                if(!CplHelper.IsInt(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("第"+ curNum.ToString() + "行商品数量不正确!");
                    return;
                }
                qadetail.Amount = System.Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
                qadetail.Check = dataGridView1.Rows[i].Cells[4].Value.ToString();
                if(CplHelper.IsNull(qadetail.GoodID) || CplHelper.IsNull(qadetail.GoodName) || CplHelper.IsNull(qadetail.Unit)
                    || CplHelper.IsNull(qadetail.Check))
                {
                    MessageBox.Show("第" + curNum.ToString() + "行数据不完整!");
                    return;
                }
                if (!CplHelper.IsGoodsIdRight(qadetail.GoodID))
                {
                    MessageBox.Show("第" + curNum.ToString() + "行商品ID不正确，格式为B+10位数字!");
                    return;
                }
                DAL.class1.InputQAdetail(qadetail);
            }
            MessageBox.Show(qamain.QAID + "号质检单已经生成");
            Communal.mapDiag = new realTimeShow();
            Communal.mapDiag.goodsNum = 1;
            Communal.mapDiag.qualityAnimate();
        }

        private void _7ReceivingNote_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
            this.dataGridView1.Font = new Font("宋体", 10);
            textBox1.Text = MODEL.AddID.Change(DAL.getnewest.QAID());
            textBox2.Text = MODEL.class1.staff.ID;
        }
    }
}
