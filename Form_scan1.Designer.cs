namespace HomePage
{
    partial class Form_scan
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
            this.label_goodsid = new System.Windows.Forms.Label();
            this.label_goodstype = new System.Windows.Forms.Label();
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_rfid = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.dataGridView_scanned = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button_scanned = new System.Windows.Forms.Button();
            this.label_worker = new System.Windows.Forms.Label();
            this.textBox_worker = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.txtQAID = new System.Windows.Forms.TextBox();
            this.txtGoodID = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scanned)).BeginInit();
            this.SuspendLayout();
            // 
            // label_goodsid
            // 
            this.label_goodsid.AutoSize = true;
            this.label_goodsid.Location = new System.Drawing.Point(241, 27);
            this.label_goodsid.Name = "label_goodsid";
            this.label_goodsid.Size = new System.Drawing.Size(53, 12);
            this.label_goodsid.TabIndex = 0;
            this.label_goodsid.Text = "商品编号";
            // 
            // label_goodstype
            // 
            this.label_goodstype.AutoSize = true;
            this.label_goodstype.Location = new System.Drawing.Point(12, 82);
            this.label_goodstype.Name = "label_goodstype";
            this.label_goodstype.Size = new System.Drawing.Size(53, 12);
            this.label_goodstype.TabIndex = 2;
            this.label_goodstype.Text = "商品名称";
            this.label_goodstype.Click += new System.EventHandler(this.label_goodstype_Click);
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(96, 79);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(121, 21);
            this.txtGoodName.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label_rfid
            // 
            this.label_rfid.AutoSize = true;
            this.label_rfid.Location = new System.Drawing.Point(105, 311);
            this.label_rfid.Name = "label_rfid";
            this.label_rfid.Size = new System.Drawing.Size(77, 12);
            this.label_rfid.TabIndex = 5;
            this.label_rfid.Text = "商品RFID编号";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(107, 220);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(217, 38);
            this.btn_scan.TabIndex = 6;
            this.btn_scan.Text = "单击扫描";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // dataGridView_scanned
            // 
            this.dataGridView_scanned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_scanned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.数量});
            this.dataGridView_scanned.Location = new System.Drawing.Point(499, 43);
            this.dataGridView_scanned.Name = "dataGridView_scanned";
            this.dataGridView_scanned.RowTemplate.Height = 23;
            this.dataGridView_scanned.Size = new System.Drawing.Size(347, 269);
            this.dataGridView_scanned.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "已扫描商品列表";
            // 
            // button_scanned
            // 
            this.button_scanned.Location = new System.Drawing.Point(629, 338);
            this.button_scanned.Name = "button_scanned";
            this.button_scanned.Size = new System.Drawing.Size(75, 36);
            this.button_scanned.TabIndex = 9;
            this.button_scanned.Text = "扫描完成";
            this.button_scanned.UseVisualStyleBackColor = true;
            this.button_scanned.Click += new System.EventHandler(this.button_scanned_Click);
            // 
            // label_worker
            // 
            this.label_worker.AutoSize = true;
            this.label_worker.Location = new System.Drawing.Point(241, 88);
            this.label_worker.Name = "label_worker";
            this.label_worker.Size = new System.Drawing.Size(41, 12);
            this.label_worker.TabIndex = 10;
            this.label_worker.Text = "操作员";
            // 
            // textBox_worker
            // 
            this.textBox_worker.Location = new System.Drawing.Point(326, 79);
            this.textBox_worker.Name = "textBox_worker";
            this.textBox_worker.Size = new System.Drawing.Size(121, 21);
            this.textBox_worker.TabIndex = 11;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(96, 140);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(121, 21);
            this.textBox_time.TabIndex = 12;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(12, 149);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(53, 12);
            this.label_time.TabIndex = 13;
            this.label_time.Text = "扫描时间";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(10, 32);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(65, 12);
            this.label_id.TabIndex = 14;
            this.label_id.Text = "质检单编号";
            // 
            // txtQAID
            // 
            this.txtQAID.Location = new System.Drawing.Point(96, 27);
            this.txtQAID.Name = "txtQAID";
            this.txtQAID.Size = new System.Drawing.Size(100, 21);
            this.txtQAID.TabIndex = 15;
            // 
            // txtGoodID
            // 
            this.txtGoodID.Location = new System.Drawing.Point(326, 27);
            this.txtGoodID.Name = "txtGoodID";
            this.txtGoodID.Size = new System.Drawing.Size(100, 21);
            this.txtGoodID.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "商品名称";
            this.Column3.Name = "Column3";
            // 
            // 数量
            // 
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            // 
            // Form_scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 432);
            this.Controls.Add(this.txtGoodID);
            this.Controls.Add(this.txtQAID);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_worker);
            this.Controls.Add(this.label_worker);
            this.Controls.Add(this.button_scanned);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_scanned);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.label_rfid);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtGoodName);
            this.Controls.Add(this.label_goodstype);
            this.Controls.Add(this.label_goodsid);
            this.MaximizeBox = false;
            this.Name = "Form_scan";
            this.Text = "商品扫描";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scanned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_goodsid;
        private System.Windows.Forms.Label label_goodstype;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_rfid;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.DataGridView dataGridView_scanned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_scanned;
        private System.Windows.Forms.Label label_worker;
        private System.Windows.Forms.TextBox textBox_worker;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox txtQAID;
        private System.Windows.Forms.TextBox txtGoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
    }
}