namespace MIS
{
    partial class realTimeShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(realTimeShow));
            this.checkedBox = new System.Windows.Forms.PictureBox();
            this.uncheckedBox = new System.Windows.Forms.PictureBox();
            this.backImgBox = new System.Windows.Forms.PictureBox();
            this.uncheckedNum = new System.Windows.Forms.Label();
            this.checkedNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.activeRFIDBox = new System.Windows.Forms.PictureBox();
            this.goodsBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheckedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeRFIDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedBox
            // 
            this.checkedBox.Image = ((System.Drawing.Image)(resources.GetObject("checkedBox.Image")));
            this.checkedBox.Location = new System.Drawing.Point(194, 293);
            this.checkedBox.Margin = new System.Windows.Forms.Padding(0);
            this.checkedBox.Name = "checkedBox";
            this.checkedBox.Size = new System.Drawing.Size(40, 40);
            this.checkedBox.TabIndex = 2;
            this.checkedBox.TabStop = false;
            // 
            // uncheckedBox
            // 
            this.uncheckedBox.Image = ((System.Drawing.Image)(resources.GetObject("uncheckedBox.Image")));
            this.uncheckedBox.Location = new System.Drawing.Point(14, 273);
            this.uncheckedBox.Margin = new System.Windows.Forms.Padding(0);
            this.uncheckedBox.Name = "uncheckedBox";
            this.uncheckedBox.Size = new System.Drawing.Size(40, 40);
            this.uncheckedBox.TabIndex = 1;
            this.uncheckedBox.TabStop = false;
            // 
            // backImgBox
            // 
            this.backImgBox.Image = ((System.Drawing.Image)(resources.GetObject("backImgBox.Image")));
            this.backImgBox.InitialImage = null;
            this.backImgBox.Location = new System.Drawing.Point(114, 0);
            this.backImgBox.Margin = new System.Windows.Forms.Padding(0);
            this.backImgBox.Name = "backImgBox";
            this.backImgBox.Size = new System.Drawing.Size(579, 613);
            this.backImgBox.TabIndex = 0;
            this.backImgBox.TabStop = false;
            // 
            // uncheckedNum
            // 
            this.uncheckedNum.AutoSize = true;
            this.uncheckedNum.BackColor = System.Drawing.Color.Transparent;
            this.uncheckedNum.Location = new System.Drawing.Point(307, 264);
            this.uncheckedNum.Name = "uncheckedNum";
            this.uncheckedNum.Size = new System.Drawing.Size(41, 12);
            this.uncheckedNum.TabIndex = 6;
            this.uncheckedNum.Text = "label1";
            // 
            // checkedNum
            // 
            this.checkedNum.AutoSize = true;
            this.checkedNum.BackColor = System.Drawing.Color.Transparent;
            this.checkedNum.Location = new System.Drawing.Point(280, 62);
            this.checkedNum.Name = "checkedNum";
            this.checkedNum.Size = new System.Drawing.Size(41, 12);
            this.checkedNum.TabIndex = 7;
            this.checkedNum.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // activeRFIDBox
            // 
            this.activeRFIDBox.Image = ((System.Drawing.Image)(resources.GetObject("activeRFIDBox.Image")));
            this.activeRFIDBox.Location = new System.Drawing.Point(127, 87);
            this.activeRFIDBox.Margin = new System.Windows.Forms.Padding(0);
            this.activeRFIDBox.Name = "activeRFIDBox";
            this.activeRFIDBox.Size = new System.Drawing.Size(40, 40);
            this.activeRFIDBox.TabIndex = 9;
            this.activeRFIDBox.TabStop = false;
            // 
            // goodsBox
            // 
            this.goodsBox.Image = ((System.Drawing.Image)(resources.GetObject("goodsBox.Image")));
            this.goodsBox.Location = new System.Drawing.Point(327, 128);
            this.goodsBox.Margin = new System.Windows.Forms.Padding(0);
            this.goodsBox.Name = "goodsBox";
            this.goodsBox.Size = new System.Drawing.Size(40, 40);
            this.goodsBox.TabIndex = 10;
            this.goodsBox.TabStop = false;
            // 
            // realTimeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(783, 617);
            this.Controls.Add(this.goodsBox);
            this.Controls.Add(this.activeRFIDBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedNum);
            this.Controls.Add(this.uncheckedNum);
            this.Controls.Add(this.checkedBox);
            this.Controls.Add(this.uncheckedBox);
            this.Controls.Add(this.backImgBox);
            this.Name = "realTimeShow";
            this.Text = "realTimeShow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.realTimeShow_FormClosed);
            this.Load += new System.EventHandler(this.realTimeShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheckedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeRFIDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox backImgBox;
        public System.Windows.Forms.PictureBox uncheckedBox;
        public System.Windows.Forms.PictureBox checkedBox;
        public System.Windows.Forms.Label uncheckedNum;
        public System.Windows.Forms.Label checkedNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox activeRFIDBox;
        private System.Windows.Forms.PictureBox goodsBox;
    }
}