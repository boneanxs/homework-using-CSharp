namespace MIS
{
    partial class Report
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_vendor = new System.Windows.Forms.Label();
            this.comboBox_vendor = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "确认并发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(140, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(648, 404);
            this.dataGridView2.TabIndex = 34;
            // 
            // label_vendor
            // 
            this.label_vendor.AutoSize = true;
            this.label_vendor.Location = new System.Drawing.Point(238, 27);
            this.label_vendor.Name = "label_vendor";
            this.label_vendor.Size = new System.Drawing.Size(65, 12);
            this.label_vendor.TabIndex = 37;
            this.label_vendor.Text = "选择供应商";
            // 
            // comboBox_vendor
            // 
            this.comboBox_vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vendor.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox_vendor.FormattingEnabled = true;
            this.comboBox_vendor.Items.AddRange(new object[] {
            "娃哈哈",
            "光明",
            "伊利",
            "蒙牛",
            "百事",
            "好吃点",
            "康师傅",
            "立白",
            "汰渍"});
            this.comboBox_vendor.Location = new System.Drawing.Point(356, 27);
            this.comboBox_vendor.Name = "comboBox_vendor";
            this.comboBox_vendor.Size = new System.Drawing.Size(180, 24);
            this.comboBox_vendor.TabIndex = 38;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 10F);
            this.btnQuery.Location = new System.Drawing.Point(558, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 34);
            this.btnQuery.TabIndex = 39;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 571);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.comboBox_vendor);
            this.Controls.Add(this.label_vendor);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Name = "Report";
            this.Text = "向供应商汇报当天销售信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Report_FormClosing);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_vendor;
        private System.Windows.Forms.ComboBox comboBox_vendor;
        private System.Windows.Forms.Button btnQuery;
    }
}