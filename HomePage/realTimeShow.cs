using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace MIS
{
    public partial class realTimeShow : Form
    {
        public realTimeShow()
        {
            InitializeComponent();
        }
        public int goodsNum = 20;
        public int timeIntival = 5;
        private int aftNum = 0;
        private Point prePoint;
        private Point aftPoint;
        private Mutex mutex = new Mutex();
        private void realTimeShow_Load(object sender, EventArgs e)
        {
            uncheckedBox.BackColor = Color.Transparent;
            uncheckedBox.Parent = backImgBox;
            checkedBox.BackColor = Color.Transparent;
            checkedBox.Parent = backImgBox;
            activeRFIDBox.BackColor = Color.Transparent;
            activeRFIDBox.Parent = backImgBox;
            goodsBox.BackColor = Color.Transparent;
            goodsBox.Parent = backImgBox;
            uncheckedNum.Text = goodsNum.ToString();
            checkedNum.Text = aftNum.ToString();
            prePoint = uncheckedBox.Location;
            aftPoint = checkedBox.Location;
            checkedBox.Visible = false;
            activeRFIDBox.Visible = true;
            uncheckedNum.Visible = false;
            checkedNum.Visible = false;
            goodsBox.Visible = false;
        }
        public void changePos()
        {
            if(goodsNum > 0)
            {
                timer1.Interval = 1;
                timer1.Start();
                
            }
        }
        int x = 0;
        int max = 0, min = 0;
        public void resetDefault()
        {
            max = prePoint.X > aftPoint.X ? prePoint.X : aftPoint.X;
            min = prePoint.X < aftPoint.X ? prePoint.X : aftPoint.X;
            x = prePoint.X;
        }
        PictureBox curControl, targetControl;
        string message = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            mutex.WaitOne();
            double k = (double)(aftPoint.Y - prePoint.Y) / (aftPoint.X - prePoint.X);
            double b = (double)aftPoint.Y - aftPoint.X * k;
            if (x == 0)
                resetDefault();
            x = prePoint.X == min ? x + 3 : x - 3;
            Point temp = new Point(x, (int)(k * x + b));
            curControl.Location = temp;
            if (x >= max || x <= min )
            {
                targetControl.Visible = true;
                curControl.Visible = false;
                timer1.Enabled = false;
                targetControl.BringToFront();
                goodsNum--;
                aftNum++;
                if(curControl == checkedBox)
                {
                    uncheckedNum.Text = goodsNum.ToString();
                    checkedNum.Text = aftNum.ToString();
                }
                MessageBox.Show(message);
                curControl.Location = prePoint;
                targetControl.Location = aftPoint;
                targetControl.Visible = false;
                curControl.Visible = true;
                resetDefault();
            }
            mutex.ReleaseMutex();
        }

        public void qualityAnimate()
        {
            if (goodsNum > 0)
            {
                message = "质检成功！！";
                curControl = uncheckedBox;
                targetControl = checkedBox;
                timer1.Interval = timeIntival;
                timer1.Start();
            }
        }
        public void scanAnimate()
        {
            if (activeRFIDBox.Visible == true)
                activeRFIDBox.Visible = false;
            if (checkedBox.Visible == false)
                checkedBox.Visible = true;
            if (uncheckedNum.Visible == false)
                uncheckedNum.Visible = true;
            if (checkedNum.Visible == false)
                checkedNum.Visible = true;
            if (goodsNum > 0)
            {
                message = "RFID贴标成功！！";
                curControl = checkedBox;
                targetControl = activeRFIDBox;
                prePoint = checkedBox.Location;
                aftPoint = activeRFIDBox.Location;
                timer1.Interval = timeIntival;
                timer1.Start();
            }

        }
        public void goodsOnTableAnimate()
        {
            if (activeRFIDBox.Visible == false)
                activeRFIDBox.Visible = true;
            if (goodsBox.Visible == true)
                goodsBox.Visible = false;
            if (uncheckedNum.Visible == true)
                uncheckedNum.Visible = false;
            if (checkedNum.Visible == true)
                checkedNum.Visible = false;
            if(goodsNum > 0)
            {
                message = "货物上架成功!";
                curControl = activeRFIDBox;
                targetControl = goodsBox;
                prePoint = activeRFIDBox.Location;
                aftPoint = goodsBox.Location;
                timer1.Interval = timeIntival;
                timer1.Start();
            }
        }
        public bool isClosed = false;
        private void realTimeShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
        }
    }
}
