namespace MIS
{
    partial class _6CustomRecord
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
            this.消费记录查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按日期查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按商品查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(876, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.消费记录查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 消费记录查询ToolStripMenuItem
            // 
            this.消费记录查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按日期查询ToolStripMenuItem,
            this.按商品查询ToolStripMenuItem});
            this.消费记录查询ToolStripMenuItem.Name = "消费记录查询ToolStripMenuItem";
            this.消费记录查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.消费记录查询ToolStripMenuItem.Text = "查询记录";
            // 
            // 按日期查询ToolStripMenuItem
            // 
            this.按日期查询ToolStripMenuItem.Name = "按日期查询ToolStripMenuItem";
            this.按日期查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.按日期查询ToolStripMenuItem.Text = "按日期查询";
            this.按日期查询ToolStripMenuItem.Click += new System.EventHandler(this.按日期查询ToolStripMenuItem_Click);
            // 
            // 按商品查询ToolStripMenuItem
            // 
            this.按商品查询ToolStripMenuItem.Name = "按商品查询ToolStripMenuItem";
            this.按商品查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.按商品查询ToolStripMenuItem.Text = "按商品查询";
            this.按商品查询ToolStripMenuItem.Click += new System.EventHandler(this.按商品查询ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.Font = new System.Drawing.Font("SimSun", 10F);
            this.btn.Location = new System.Drawing.Point(578, 41);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(90, 30);
            this.btn.TabIndex = 3;
            this.btn.Text = "确认";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Visible = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("SimSun", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 21);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // _6CustomRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 581);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "_6CustomRecord";
            this.Text = "会员消费记录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._6CustomRecord_FormClosing);
            this.Load += new System.EventHandler(this._6CustomRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 消费记录查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按日期查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按商品查询ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}