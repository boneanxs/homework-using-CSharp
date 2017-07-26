using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace Entry
{
    public partial class entry : Form
    {
        public entry()
        {
            InitializeComponent();
        }
        string curPath = "";
        private void btn_MIS_Click(object sender, EventArgs e)
        {

            Process ps = new Process();
            ps.StartInfo.WorkingDirectory = curPath + "/Login/bin/Debug";
            ps.StartInfo.FileName = curPath + "/Login/bin/Debug/Login.exe";
            ps.Start();
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(curPath + "/SelfService/bin/Debug/SelfService.exe");
        }

        private void btn_consign_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(curPath + "/Restore Cmd Application/Restore Cmd Application/bin/Debug/Restore Cmd Application.exe");
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(curPath + "/CusDetailForm/bin/Debug/CusDetailForm.exe");
        }

        private void entry_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                curPath = Directory.GetCurrentDirectory();
                Directory.SetCurrentDirectory(Directory.GetParent(curPath).FullName);
                curPath = Directory.GetCurrentDirectory();
            }
        }
    }
}
