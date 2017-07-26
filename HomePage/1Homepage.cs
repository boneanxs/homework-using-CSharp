using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace MIS
{
    public partial class Homepage : Form
    {
        public string state;

        public Homepage()
        {
            InitializeComponent();
           label2.Text = "操作员: " + MODEL.class1.staff.ID;
        }

        public static void warn()
        {
            MessageBox.Show("您无此权限！");
        }

       // public string state = DAL.class1.StaffAuthority(MODEL.class1.s);
        private void backImgTrans(TabPage tab,PictureBox temp)
        {
            temp.BackColor = Color.Transparent;
            temp.Parent = tab;
        }
        private void backImgTrans(Panel tab, Label temp)
        {
            temp.BackColor = Color.Transparent;
            temp.Parent = tab;
        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            // 设置 tabControlHomePage属性为用户绘制方式
            tabControlHomePage.DrawMode = TabDrawMode.OwnerDrawFixed;
            backImgTrans(tabPage1, pictureBox1);
            backImgTrans(tabPage1, pictureBox2);
            backImgTrans(tabPage1, pictureBox3);
            backImgTrans(tabPage1, pictureBox4);
            backImgTrans(tabPage2, pictureBox5);
            backImgTrans(tabPage2, pictureBox6);
            backImgTrans(tabPage2, pictureBox7);
            backImgTrans(tabPage2, pictureBox8);
            backImgTrans(tabPage2, pictureBox9);
            backImgTrans(tabPage3, pictureBox10);
            backImgTrans(tabPage3, pictureBox11);
            backImgTrans(panel_info, label2);
            backImgTrans(panel_info, label_post);
            //label2.Text = "操作员：" + MODEL.class1.staff.ID;
            label_post.Text = "职位:" + this.state;
            this.panel_showform.BackColor = ColorTranslator.FromHtml("#8C8C8C");
            this.pictureBox12.BackColor = ColorTranslator.FromHtml("#515151");
        }

     

        //将tabpage内所有button设置为不可点击的公共方法
        public void ButtonUnenabledinTabPage(TabPage t)
        {
            foreach (Control ctl in t.Controls)
            {
                if (ctl is Button)
                {
                    Button btn = ctl as Button;
                    btn.Enabled = false;
                }
            }
        }
        //将所有button设置为不可点击的方法
        public void AllButtonUnenabled()
        {
            ButtonUnenabledinTabPage(tabPage1);
            ButtonUnenabledinTabPage(tabPage2);
            ButtonUnenabledinTabPage(tabPage3);
        }
        //将所有tabpage内button设为可点击方法
        public static void ButtonEnabledinTabPage(TabPage t)
        {
            foreach (Control ctl in t.Controls)
            {
                if (ctl is Button)
                {
                    Button btn = ctl as Button;
                    btn.Enabled = true;
                }
            }
        }
        public void AllButtonEnabled()
        {
            ButtonEnabledinTabPage(tabPage1);
            ButtonEnabledinTabPage(tabPage2);
            ButtonEnabledinTabPage(tabPage3);
        }

        //打开子窗体的公共方法
        private void showForm(Form temp)
        {
            //temp.MdiParent = this;
            //temp.StartPosition = FormStartPosition.Manual;//更改属性
            temp.TopLevel = false;
            temp.Dock = DockStyle.Fill;
            temp.Parent = this.panel_showform;
            temp.Location = new Point(0, 0);//通过修改Point里的坐标设定起始位置
            temp.Show();
        }
        //点击不同的button打开相应的子窗体
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "用户管理员")
            {
                AllButtonUnenabled();
                Register myform = new Register();
                myform.state = "注册";
                showForm(myform);
            }
            else warn();

        }
        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "用户管理员")
            {
                CustomerInfo myform = new CustomerInfo();
                showForm(myform);
                AllButtonUnenabled();
            }
            else warn();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "用户管理员")
            {
                //UpdateRecord myform = new UpdateRecord();
                //showForm(myform);
                //AllButtonUnenabled();
            }
            else warn();
        }

        private void btnChargeRecord_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "用户管理员")
            {
                ChargeRecord myform = new ChargeRecord();
                showForm(myform);
                AllButtonUnenabled();
            }
        }

        private void ReceivingNote_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "质检员")
            {
                _7ReceivingNote myform = new _7ReceivingNote();
                showForm(myform);
                AllButtonUnenabled();
            }
            else warn();
        }

        private void btnRNoteInfo_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "质检员")
            {
                _8QAInfo myform = new _8QAInfo();
                showForm(myform);
                AllButtonUnenabled();
            }
            else warn();
        }

        //private void btnGodownEntry_Click(object sender, EventArgs e)
        //{
        //    if (state == "信息员" || state == "库存管理员员")
        //    {
        //        _9GodownEntry myform = new _9GodownEntry();
        //        showForm(myform);
        //        AllButtonUnenabled();
        //    }
        //    else warn();
        //}

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "库存管理员")
            {
                _10GEInfo myform = new _10GEInfo();
                showForm(myform);
                AllButtonUnenabled();
            }
            else warn();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "库存管理员")
            {
               Inventory myform = new Inventory();
                showForm(myform);
                AllButtonUnenabled();
            }
            else warn();
        }

        //private void button15_Click(object sender, EventArgs e)
        //{
        //    if (state == "信息员" || state == "质检员")
        //    {
        //        _11Outstock myform = new _11Outstock();
        //        showForm(myform);
        //        AllButtonUnenabled();
        //    }
        //    else warn();
        //}

        private void btnSalesRecord_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "销售员")
            {
                SalesRecord myform = new SalesRecord();
                showForm(myform);
                AllButtonUnenabled();
            }
            else warn();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "销售员")
            {
                Report myform = new Report();
                showForm(myform);
                AllButtonUnenabled();
            }
            else warn();
        }

        private void btnCustomRecord_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "用户管理员")
            {
                _6CustomRecord myform = new _6CustomRecord();
                showForm(myform);
                AllButtonUnenabled();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "质检员") { }
            else warn();
        }

        //重绘tabcontrol 
        private void tabControlHomePage_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;

            ///*************修改选项卡背景颜色*************/
            //Rectangle rec = tabControlHomePage.GetTabRect(e.Index);
            //SolidBrush brushrect = new SolidBrush(Color.CadetBlue);
            //g.FillRectangle(brushrect, rec);

            /**************修改选项卡停靠位置****************/
            //做个转换来获得TAB项的RECTANGELF
             Rectangle tabArea = tabControlHomePage.GetTabRect(e.Index);
           // RectangleF tabTextArea = (RectangleF)(tabControlHomePage.GetTabRect(e.Index));
            //封装文本布局信息
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
          //  sf.Alignment = StringAlignment.Center;
            Font font = this.tabControlHomePage.Font;
            //绘制边框的画笔
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString(((TabControl)(sender)).TabPages[e.Index].Text, font, brush, tabArea/*tabTextArea*/, sf);
        }

        private void btnScanIn_Click(object sender, EventArgs e)
        {
            if (state == "信息员" || state == "库存管理员")
            {
                Form_scan myform = new Form_scan();
                //_9GodownEntry myform = new _9GodownEntry();
                showForm(myform);
                AllButtonUnenabled();
            }
            else warn();
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControlHomePage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            match F = new match();
            showForm(F);
        }

        private void btn_planfloor_Click(object sender, EventArgs e)
        {
            PlanFloor f = new PlanFloor();
            f.Show();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
