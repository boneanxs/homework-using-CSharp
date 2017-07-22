using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consign
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void 按姓名查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inquiry.Visible = true;
            btn_inquiry.Visible = true;
            label_tips.Visible = true;
            label_tips.Text="姓名：";
        }

        private void 按日期查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inquiry.Visible = true;
            btn_inquiry.Visible = true;
            label_tips.Visible = true;
            label_tips.Text = "日期：";
        }

        private void 按卡号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inquiry.Visible = true;
            btn_inquiry.Visible = true;
            label_tips.Visible = true;
            label_tips.Text = "卡号：";
        }

        private void Record_Load(object sender, EventArgs e)
        {

        }
    }
}
