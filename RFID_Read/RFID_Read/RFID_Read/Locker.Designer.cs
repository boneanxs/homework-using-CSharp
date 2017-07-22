namespace Consign
{
    partial class Record
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.会员卡号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄存时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.取走时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consign_inquiry = new System.Windows.Forms.MenuStrip();
            this.按姓名查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按日期查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按卡号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_inquiry = new System.Windows.Forms.Button();
            this.inquiry = new System.Windows.Forms.TextBox();
            this.label_tips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.consign_inquiry.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.姓名,
            this.会员卡号,
            this.寄存时间,
            this.取走时间,
            this.日期});
            this.dataGridView1.Location = new System.Drawing.Point(25, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(545, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // 会员卡号
            // 
            this.会员卡号.HeaderText = "会员卡号";
            this.会员卡号.Name = "会员卡号";
            // 
            // 寄存时间
            // 
            this.寄存时间.HeaderText = "寄存时间";
            this.寄存时间.Name = "寄存时间";
            // 
            // 取走时间
            // 
            this.取走时间.HeaderText = "取走时间";
            this.取走时间.Name = "取走时间";
            // 
            // 日期
            // 
            this.日期.HeaderText = "日期";
            this.日期.Name = "日期";
            // 
            // consign_inquiry
            // 
            this.consign_inquiry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按姓名查询ToolStripMenuItem,
            this.按日期查询ToolStripMenuItem,
            this.按卡号查询ToolStripMenuItem});
            this.consign_inquiry.Location = new System.Drawing.Point(0, 0);
            this.consign_inquiry.Name = "consign_inquiry";
            this.consign_inquiry.Size = new System.Drawing.Size(584, 25);
            this.consign_inquiry.TabIndex = 1;
            this.consign_inquiry.Text = "menuStrip1";
            // 
            // 按姓名查询ToolStripMenuItem
            // 
            this.按姓名查询ToolStripMenuItem.Name = "按姓名查询ToolStripMenuItem";
            this.按姓名查询ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.按姓名查询ToolStripMenuItem.Text = "按姓名查询";
            this.按姓名查询ToolStripMenuItem.Click += new System.EventHandler(this.按姓名查询ToolStripMenuItem_Click);
            // 
            // 按日期查询ToolStripMenuItem
            // 
            this.按日期查询ToolStripMenuItem.Name = "按日期查询ToolStripMenuItem";
            this.按日期查询ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.按日期查询ToolStripMenuItem.Text = "按日期查询";
            this.按日期查询ToolStripMenuItem.Click += new System.EventHandler(this.按日期查询ToolStripMenuItem_Click);
            // 
            // 按卡号查询ToolStripMenuItem
            // 
            this.按卡号查询ToolStripMenuItem.Name = "按卡号查询ToolStripMenuItem";
            this.按卡号查询ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.按卡号查询ToolStripMenuItem.Text = "按卡号查询";
            this.按卡号查询ToolStripMenuItem.Click += new System.EventHandler(this.按卡号查询ToolStripMenuItem_Click);
            // 
            // btn_inquiry
            // 
            this.btn_inquiry.Location = new System.Drawing.Point(350, 35);
            this.btn_inquiry.Name = "btn_inquiry";
            this.btn_inquiry.Size = new System.Drawing.Size(75, 23);
            this.btn_inquiry.TabIndex = 2;
            this.btn_inquiry.Text = "查询";
            this.btn_inquiry.UseVisualStyleBackColor = true;
            this.btn_inquiry.Visible = false;
            // 
            // inquiry
            // 
            this.inquiry.Location = new System.Drawing.Point(219, 35);
            this.inquiry.Name = "inquiry";
            this.inquiry.Size = new System.Drawing.Size(81, 21);
            this.inquiry.TabIndex = 3;
            this.inquiry.Visible = false;
            // 
            // label_tips
            // 
            this.label_tips.AutoSize = true;
            this.label_tips.Location = new System.Drawing.Point(180, 40);
            this.label_tips.Name = "label_tips";
            this.label_tips.Size = new System.Drawing.Size(59, 12);
            this.label_tips.TabIndex = 4;
            this.label_tips.Text = "label_tip";
            this.label_tips.Visible = false;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.label_tips);
            this.Controls.Add(this.inquiry);
            this.Controls.Add(this.btn_inquiry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.consign_inquiry);
            this.MainMenuStrip = this.consign_inquiry;
            this.MaximizeBox = false;
            this.Name = "Record";
            this.Text = "寄存记录查询";
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.consign_inquiry.ResumeLayout(false);
            this.consign_inquiry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 会员卡号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寄存时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 取走时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.MenuStrip consign_inquiry;
        private System.Windows.Forms.ToolStripMenuItem 按姓名查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按日期查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按卡号查询ToolStripMenuItem;
        private System.Windows.Forms.Button btn_inquiry;
        private System.Windows.Forms.TextBox inquiry;
        private System.Windows.Forms.Label label_tips;
    }
}

