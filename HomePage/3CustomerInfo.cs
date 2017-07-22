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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        public static int state;

        public void Show3()
        {
            label1.Visible = true;
            btn.Visible = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = false;
        }

        public void ChangeName()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "会员卡号";
            dataGridView1.Columns[1].HeaderCell.Value = "姓名";
            dataGridView1.Columns[2].HeaderCell.Value = "性别";
            dataGridView1.Columns[3].HeaderCell.Value = "密码";
            dataGridView1.Columns[4].HeaderCell.Value = "电话号";
            dataGridView1.Columns[5].HeaderCell.Value = "身份证号";
            dataGridView1.Columns[6].HeaderCell.Value = "余额";
            dataGridView1.Columns[7].HeaderCell.Value = "注册日期";
            dataGridView1.Columns[8].HeaderCell.Value = "注册人员";
            dataGridView1.Columns[9].HeaderCell.Value = "账户状态";
        }
        private void CustomerInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communal.h.AllButtonEnabled();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case 1:
                    {
                        dataGridView1.DataSource = DAL.class1.QueryMembyName(textBox1.Text).Tables[0];
                        ChangeName();
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = DAL.class1.QueryMembyMemId(textBox1.Text).Tables[0];
                        ChangeName();
                        break;
                    }
                case 3:
                    {
                        dataGridView1.DataSource = DAL.class1.QueryMembyDate(dateTimePicker1.Text).Tables[0];
                        ChangeName();
                    
                        break;
                    }
                case 4:
                    {
                        dataGridView1.DataSource = DAL.class1.QueryMembyTel(textBox1.Text).Tables[0];
                        ChangeName();
                        break;
                    }
                case 5:
                    {
                        dataGridView1.DataSource = DAL.class1.QueryMembyId(textBox1.Text).Tables[0];
                        ChangeName();
                        break;
                    }
                case 6:
                    {
                        this.dataGridView1.Columns[0].ReadOnly = true;
                        this.dataGridView1.Columns[6].ReadOnly = true;
                        this.dataGridView1.Columns[7].ReadOnly = true;
                        this.dataGridView1.Columns[8].ReadOnly = true;
                        this.dataGridView1.Columns[9].ReadOnly = true;
                        for(int i=0;i<dataGridView1.Rows.Count;i++)
                        {
                            MODEL.Member m = new MODEL.Member();
                            
                            m.MemCardID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            m.MemName= dataGridView1.Rows[i].Cells[1].Value.ToString();
                            m.MemSex= dataGridView1.Rows[i].Cells[2].Value.ToString();
                            m.MemPd= dataGridView1.Rows[i].Cells[3].Value.ToString();
                            m.Memtel= dataGridView1.Rows[i].Cells[4].Value.ToString();
                            m.IDCard = dataGridView1.Rows[i].Cells[5].Value.ToString();
                            if (CplHelper.IsDecimal(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                                m.Memacount = System.Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            else
                            {
                                MessageBox.Show("金额格式不对!");
                                return;
                            }
                            m.Registtime= dataGridView1.Rows[i].Cells[7].Value.ToString();
                            m.operateStaff= dataGridView1.Rows[i].Cells[8].Value.ToString();
                            if (CplHelper.IsNull(m.MemName) || CplHelper.IsNull(m.MemSex) ||
                                CplHelper.IsNull(m.MemPd) || CplHelper.IsNull(m.Memtel) ||
                                CplHelper.IsNull(m.IDCard))
                            {
                                MessageBox.Show("信息未输入完全!");
                                return;
                            }
                            if (!CplHelper.IsEmail(m.Memtel))
                            {
                                MessageBox.Show("邮箱格式不对!");
                                return;
                            }
                            if(!CplHelper.IsSpecLen(m.IDCard,18))
                            {
                                MessageBox.Show("身份证格式不正确!");
                                return;
                            }
                            if(!CplHelper.IsSexRight(m.MemSex))
                            {
                                MessageBox.Show("性别输入不正确!");
                                return;
                            }
                            DAL.class1.UpdateMem(m);
                            
                        }
                        MessageBox.Show("已修改成功！请在查询界面进行查询");
                        break;
                    }
                case 7:
                    {
                        
                        DAL.class1.DeleteMem(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        
                        dataGridView1.SelectedRows[0].Cells[0].Value = "停用";
                        MessageBox.Show("已将该会员记录停用，双击该记录进行重新注册");
                        break;
                    }                 
            }
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            ConsChangeInForms.ConsChangeInForm(this);
            this.dataGridView1.Font = new Font("楷体", 10);
           this.BackColor = ColorTranslator.FromHtml("#CCCCCC");
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (state == 7)
            {
                MODEL.Member member = new MODEL.Member();
                Register myform = new Register();
                int i = Convert.ToInt32(e.RowIndex);
                myform.txtMemName.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                myform.BoxSex.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                myform.txtTel.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                myform.txtIdcard.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                myform.txtAccount.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                myform.TopMost = true;
                myform.state = "补办";
                myform.Show();
                this.Close();
            }
        }
        private void clearText()
        {
            this.textBox1.Clear();
        }
        private void 按姓名查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "请输入查询姓名";
            btn.Text = "确认";
            Show3();
            state = 1;
            dataGridView1.Location = new Point(43, 90);
            clearText();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void 按电话查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "请输入电话号码";
            btn.Text = "确认";
            Show3();
            state = 4;
            dataGridView1.Location = new Point(43, 90);
            clearText();
        }

        private void 按邮箱查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "请输入邮箱地址";
            btn.Text = "确认";
            Show3();
            state = 4;
            dataGridView1.Location = new Point(43, 90);
            clearText();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void 按身份证号查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "请输入身份证号";
            btn.Text = "确认";
            Show3();
            state = 5;
            dataGridView1.Location = new Point(43, 90);
            clearText();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void 按日期查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "请输入查询日期";
            btn.Text = "确认";
            Show3();
            textBox1.Visible = false;
            dateTimePicker1.Visible = true;
            state = 3;
            dataGridView1.Location = new Point(43, 90);
            clearText();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 6;
            label1.Visible = false;
            textBox1.Visible = false;
            btn.Visible = true;
            btn.Text = "确认修改";
            dataGridView1.ReadOnly = false;
            clearText();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void 挂失ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            state = 7;
            label1.Visible = false;
            textBox1.Visible = false;
            btn.Visible = true;
            btn.Text = "挂失";
            clearText();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void 按会员编号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "请输入查询编号";
            btn.Text = "确认";
            Show3();
            state = 2;
            dataGridView1.Location = new Point(43, 90);
            clearText();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void 查询会员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
