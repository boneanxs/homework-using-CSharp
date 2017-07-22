namespace MIS
{
    partial class ChargeRecord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询充值记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按编号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按时间查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(880, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询充值记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询充值记录ToolStripMenuItem
            // 
            this.查询充值记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按编号查询ToolStripMenuItem,
            this.按时间查询ToolStripMenuItem});
            this.查询充值记录ToolStripMenuItem.Name = "查询充值记录ToolStripMenuItem";
            this.查询充值记录ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.查询充值记录ToolStripMenuItem.Text = "查询充值记录";
            // 
            // 按编号查询ToolStripMenuItem
            // 
            this.按编号查询ToolStripMenuItem.Name = "按编号查询ToolStripMenuItem";
            this.按编号查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.按编号查询ToolStripMenuItem.Text = "按编号查询";
            this.按编号查询ToolStripMenuItem.Click += new System.EventHandler(this.按编号查询ToolStripMenuItem_Click);
            // 
            // 按时间查询ToolStripMenuItem
            // 
            this.按时间查询ToolStripMenuItem.Name = "按时间查询ToolStripMenuItem";
            this.按时间查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.按时间查询ToolStripMenuItem.Text = "按时间查询";
            this.按时间查询ToolStripMenuItem.Click += new System.EventHandler(this.按时间查询ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("SimSun", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 23);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun", 10F);
            this.button1.Location = new System.Drawing.Point(515, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "确认查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChargeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChargeRecord";
            this.Text = "会员充值记录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChargeRecord_FormClosing);
            this.Load += new System.EventHandler(this.ChargeRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询充值记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按编号查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按时间查询ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}