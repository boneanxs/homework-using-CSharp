namespace MIS
{
    partial class CustomerInfo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询会员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按姓名查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按会员编号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按邮箱查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.按身份证号查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.按日期查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.挂失ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询会员信息ToolStripMenuItem,
            this.修改信息ToolStripMenuItem,
            this.挂失ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询会员信息ToolStripMenuItem
            // 
            this.查询会员信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按姓名查询ToolStripMenuItem,
            this.按会员编号查询ToolStripMenuItem,
            this.按邮箱查询ToolStripMenuItem1,
            this.按身份证号查询ToolStripMenuItem1,
            this.按日期查询ToolStripMenuItem1});
            this.查询会员信息ToolStripMenuItem.Name = "查询会员信息ToolStripMenuItem";
            this.查询会员信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.查询会员信息ToolStripMenuItem.Text = "查询会员信息";
            this.查询会员信息ToolStripMenuItem.Click += new System.EventHandler(this.查询会员信息ToolStripMenuItem_Click);
            // 
            // 按姓名查询ToolStripMenuItem
            // 
            this.按姓名查询ToolStripMenuItem.Name = "按姓名查询ToolStripMenuItem";
            this.按姓名查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.按姓名查询ToolStripMenuItem.Text = "按姓名查询";
            this.按姓名查询ToolStripMenuItem.Click += new System.EventHandler(this.按姓名查询ToolStripMenuItem_Click);
            // 
            // 按会员编号查询ToolStripMenuItem
            // 
            this.按会员编号查询ToolStripMenuItem.Name = "按会员编号查询ToolStripMenuItem";
            this.按会员编号查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.按会员编号查询ToolStripMenuItem.Text = "按编号查询";
            this.按会员编号查询ToolStripMenuItem.Click += new System.EventHandler(this.按会员编号查询ToolStripMenuItem_Click);
            // 
            // 按邮箱查询ToolStripMenuItem1
            // 
            this.按邮箱查询ToolStripMenuItem1.Name = "按邮箱查询ToolStripMenuItem1";
            this.按邮箱查询ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.按邮箱查询ToolStripMenuItem1.Text = "按邮箱查询";
            this.按邮箱查询ToolStripMenuItem1.Click += new System.EventHandler(this.按邮箱查询ToolStripMenuItem1_Click);
            // 
            // 按身份证号查询ToolStripMenuItem1
            // 
            this.按身份证号查询ToolStripMenuItem1.Name = "按身份证号查询ToolStripMenuItem1";
            this.按身份证号查询ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.按身份证号查询ToolStripMenuItem1.Text = "按身份证号查询";
            this.按身份证号查询ToolStripMenuItem1.Click += new System.EventHandler(this.按身份证号查询ToolStripMenuItem1_Click);
            // 
            // 按日期查询ToolStripMenuItem1
            // 
            this.按日期查询ToolStripMenuItem1.Name = "按日期查询ToolStripMenuItem1";
            this.按日期查询ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.按日期查询ToolStripMenuItem1.Text = "按日期查询";
            this.按日期查询ToolStripMenuItem1.Click += new System.EventHandler(this.按日期查询ToolStripMenuItem1_Click);
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
            // 
            // 挂失ToolStripMenuItem
            // 
            this.挂失ToolStripMenuItem.Name = "挂失ToolStripMenuItem";
            this.挂失ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.挂失ToolStripMenuItem.Text = "挂失";
            this.挂失ToolStripMenuItem.Click += new System.EventHandler(this.挂失ToolStripMenuItem_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("SimSun", 10F);
            this.btn.Location = new System.Drawing.Point(461, 544);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(79, 25);
            this.btn.TabIndex = 6;
            this.btn.Text = "btn";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Visible = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Location = new System.Drawing.Point(43, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(894, 433);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("SimSun", 11F);
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 24);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Visible = false;
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 581);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerInfo";
            this.Text = "会员信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerInfo_FormClosing);
            this.Load += new System.EventHandler(this.CustomerInfo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        //private System.Windows.Forms.ToolStripMenuItem 查询记录ToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem 姓名查询ToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem 按编号查询ToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem 按日期查询ToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem 按电话查询ToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem 修改记录ToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem 删除记录ToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem 按身份证号查询ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem 查询会员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按姓名查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按会员编号查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按邮箱查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 按身份证号查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 按日期查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 挂失ToolStripMenuItem;
    }
}