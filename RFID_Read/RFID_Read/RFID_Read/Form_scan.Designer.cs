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
            this.comboBox_goodsid = new System.Windows.Forms.ComboBox();
            this.label_goodstype = new System.Windows.Forms.Label();
            this.textBox_goostype = new System.Windows.Forms.TextBox();
            this.textBox_rfid = new System.Windows.Forms.TextBox();
            this.label_rfid = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.dataGridView_scanned = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_list = new System.Windows.Forms.Label();
            this.button_finished = new System.Windows.Forms.Button();
            this.label_worker = new System.Windows.Forms.Label();
            this.textBox_worker = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.label_totalsum = new System.Windows.Forms.Label();
            this.label_scannednum = new System.Windows.Forms.Label();
            this.GoodsNum_label = new System.Windows.Forms.Label();
            this.ScanGoodsNum_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scanned)).BeginInit();
            this.SuspendLayout();
            // 
            // label_goodsid
            // 
            this.label_goodsid.AutoSize = true;
            this.label_goodsid.Location = new System.Drawing.Point(241, 32);
            this.label_goodsid.Name = "label_goodsid";
            this.label_goodsid.Size = new System.Drawing.Size(53, 12);
            this.label_goodsid.TabIndex = 0;
            this.label_goodsid.Text = "商品编号";
            // 
            // comboBox_goodsid
            // 
            this.comboBox_goodsid.FormattingEnabled = true;
            this.comboBox_goodsid.Location = new System.Drawing.Point(326, 24);
            this.comboBox_goodsid.Name = "comboBox_goodsid";
            this.comboBox_goodsid.Size = new System.Drawing.Size(121, 20);
            this.comboBox_goodsid.TabIndex = 1;
            // 
            // label_goodstype
            // 
            this.label_goodstype.AutoSize = true;
            this.label_goodstype.Location = new System.Drawing.Point(12, 88);
            this.label_goodstype.Name = "label_goodstype";
            this.label_goodstype.Size = new System.Drawing.Size(53, 12);
            this.label_goodstype.TabIndex = 2;
            this.label_goodstype.Text = "商品类别";
            // 
            // textBox_goostype
            // 
            this.textBox_goostype.Location = new System.Drawing.Point(96, 79);
            this.textBox_goostype.Name = "textBox_goostype";
            this.textBox_goostype.Size = new System.Drawing.Size(121, 21);
            this.textBox_goostype.TabIndex = 3;
            // 
            // textBox_rfid
            // 
            this.textBox_rfid.Location = new System.Drawing.Point(240, 297);
            this.textBox_rfid.Name = "textBox_rfid";
            this.textBox_rfid.Size = new System.Drawing.Size(100, 21);
            this.textBox_rfid.TabIndex = 4;
            // 
            // label_rfid
            // 
            this.label_rfid.AutoSize = true;
            this.label_rfid.Location = new System.Drawing.Point(121, 300);
            this.label_rfid.Name = "label_rfid";
            this.label_rfid.Size = new System.Drawing.Size(77, 12);
            this.label_rfid.TabIndex = 5;
            this.label_rfid.Text = "商品RFID编号";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(123, 215);
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
            this.Column2,
            this.Column3});
            this.dataGridView_scanned.Location = new System.Drawing.Point(499, 43);
            this.dataGridView_scanned.Name = "dataGridView_scanned";
            this.dataGridView_scanned.RowTemplate.Height = 23;
            this.dataGridView_scanned.Size = new System.Drawing.Size(347, 269);
            this.dataGridView_scanned.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品类别";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "商品名称";
            this.Column3.Name = "Column3";
            // 
            // label_list
            // 
            this.label_list.AutoSize = true;
            this.label_list.Location = new System.Drawing.Point(497, 9);
            this.label_list.Name = "label_list";
            this.label_list.Size = new System.Drawing.Size(89, 12);
            this.label_list.TabIndex = 8;
            this.label_list.Text = "已扫描商品列表";
            // 
            // button_finished
            // 
            this.button_finished.Location = new System.Drawing.Point(629, 338);
            this.button_finished.Name = "button_finished";
            this.button_finished.Size = new System.Drawing.Size(75, 36);
            this.button_finished.TabIndex = 9;
            this.button_finished.Text = "扫描完成";
            this.button_finished.UseVisualStyleBackColor = true;
            this.button_finished.Click += new System.EventHandler(this.button_scanned_Click);
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
            // comboBox_id
            // 
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Location = new System.Drawing.Point(96, 24);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(121, 20);
            this.comboBox_id.TabIndex = 15;
            // 
            // label_totalsum
            // 
            this.label_totalsum.AutoSize = true;
            this.label_totalsum.Location = new System.Drawing.Point(241, 149);
            this.label_totalsum.Name = "label_totalsum";
            this.label_totalsum.Size = new System.Drawing.Size(53, 12);
            this.label_totalsum.TabIndex = 16;
            this.label_totalsum.Text = "商品个数";
            // 
            // label_scannednum
            // 
            this.label_scannednum.AutoSize = true;
            this.label_scannednum.Location = new System.Drawing.Point(123, 353);
            this.label_scannednum.Name = "label_scannednum";
            this.label_scannednum.Size = new System.Drawing.Size(89, 12);
            this.label_scannednum.TabIndex = 18;
            this.label_scannednum.Text = "已扫描商品个数";
            // 
            // GoodsNum_label
            // 
            this.GoodsNum_label.AutoSize = true;
            this.GoodsNum_label.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoodsNum_label.Location = new System.Drawing.Point(331, 141);
            this.GoodsNum_label.Name = "GoodsNum_label";
            this.GoodsNum_label.Size = new System.Drawing.Size(21, 21);
            this.GoodsNum_label.TabIndex = 20;
            this.GoodsNum_label.Text = "0";
            // 
            // ScanGoodsNum_label
            // 
            this.ScanGoodsNum_label.AutoSize = true;
            this.ScanGoodsNum_label.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScanGoodsNum_label.Location = new System.Drawing.Point(239, 345);
            this.ScanGoodsNum_label.Name = "ScanGoodsNum_label";
            this.ScanGoodsNum_label.Size = new System.Drawing.Size(21, 21);
            this.ScanGoodsNum_label.TabIndex = 21;
            this.ScanGoodsNum_label.Text = "0";
            // 
            // Form_scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 432);
            this.Controls.Add(this.ScanGoodsNum_label);
            this.Controls.Add(this.GoodsNum_label);
            this.Controls.Add(this.label_scannednum);
            this.Controls.Add(this.label_totalsum);
            this.Controls.Add(this.comboBox_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_worker);
            this.Controls.Add(this.label_worker);
            this.Controls.Add(this.button_finished);
            this.Controls.Add(this.label_list);
            this.Controls.Add(this.dataGridView_scanned);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.label_rfid);
            this.Controls.Add(this.textBox_rfid);
            this.Controls.Add(this.textBox_goostype);
            this.Controls.Add(this.label_goodstype);
            this.Controls.Add(this.comboBox_goodsid);
            this.Controls.Add(this.label_goodsid);
            this.MaximizeBox = false;
            this.Name = "Form_scan";
            this.Text = "商品扫描";
            this.Load += new System.EventHandler(this.Form_scan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scanned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_goodsid;
        private System.Windows.Forms.ComboBox comboBox_goodsid;
        private System.Windows.Forms.Label label_goodstype;
        private System.Windows.Forms.TextBox textBox_goostype;
        private System.Windows.Forms.TextBox textBox_rfid;
        private System.Windows.Forms.Label label_rfid;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.DataGridView dataGridView_scanned;
        private System.Windows.Forms.Label label_list;
        private System.Windows.Forms.Button button_finished;
        private System.Windows.Forms.Label label_worker;
        private System.Windows.Forms.TextBox textBox_worker;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.Label label_totalsum;
        private System.Windows.Forms.Label label_scannednum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label GoodsNum_label;
        private System.Windows.Forms.Label ScanGoodsNum_label;
    }
}