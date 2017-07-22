namespace MIS
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
            this.textBox_rfid = new System.Windows.Forms.TextBox();
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
            this.txtGoodID = new System.Windows.Forms.TextBox();
            this.cBoxQA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scanned)).BeginInit();
            this.SuspendLayout();
            // 
            // label_goodsid
            // 
            this.label_goodsid.AutoSize = true;
            this.label_goodsid.Location = new System.Drawing.Point(136, 221);
            this.label_goodsid.Name = "label_goodsid";
            this.label_goodsid.Size = new System.Drawing.Size(53, 12);
            this.label_goodsid.TabIndex = 0;
            this.label_goodsid.Text = "商品编号";
            // 
            // label_goodstype
            // 
            this.label_goodstype.AutoSize = true;
            this.label_goodstype.Location = new System.Drawing.Point(137, 94);
            this.label_goodstype.Name = "label_goodstype";
            this.label_goodstype.Size = new System.Drawing.Size(53, 12);
            this.label_goodstype.TabIndex = 2;
            this.label_goodstype.Text = "商品名称";
            this.label_goodstype.Click += new System.EventHandler(this.label_goodstype_Click);
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(245, 91);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.ReadOnly = true;
            this.txtGoodName.Size = new System.Drawing.Size(121, 21);
            this.txtGoodName.TabIndex = 3;
            // 
            // textBox_rfid
            // 
            this.textBox_rfid.Location = new System.Drawing.Point(245, 484);
            this.textBox_rfid.Name = "textBox_rfid";
            this.textBox_rfid.ReadOnly = true;
            this.textBox_rfid.Size = new System.Drawing.Size(214, 21);
            this.textBox_rfid.TabIndex = 4;
            this.textBox_rfid.TextChanged += new System.EventHandler(this.textBox_rfid_TextChanged);
            // 
            // label_rfid
            // 
            this.label_rfid.AutoSize = true;
            this.label_rfid.Location = new System.Drawing.Point(149, 487);
            this.label_rfid.Name = "label_rfid";
            this.label_rfid.Size = new System.Drawing.Size(77, 12);
            this.label_rfid.TabIndex = 5;
            this.label_rfid.Text = "商品RFID编号";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(153, 366);
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
            this.dataGridView_scanned.Location = new System.Drawing.Point(477, 60);
            this.dataGridView_scanned.Name = "dataGridView_scanned";
            this.dataGridView_scanned.RowTemplate.Height = 23;
            this.dataGridView_scanned.Size = new System.Drawing.Size(428, 439);
            this.dataGridView_scanned.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "待扫描商品";
            // 
            // button_scanned
            // 
            this.button_scanned.Location = new System.Drawing.Point(647, 540);
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
            this.label_worker.Location = new System.Drawing.Point(136, 292);
            this.label_worker.Name = "label_worker";
            this.label_worker.Size = new System.Drawing.Size(41, 12);
            this.label_worker.TabIndex = 10;
            this.label_worker.Text = "操作员";
            // 
            // textBox_worker
            // 
            this.textBox_worker.Location = new System.Drawing.Point(245, 286);
            this.textBox_worker.Name = "textBox_worker";
            this.textBox_worker.ReadOnly = true;
            this.textBox_worker.Size = new System.Drawing.Size(121, 21);
            this.textBox_worker.TabIndex = 11;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(245, 155);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.ReadOnly = true;
            this.textBox_time.Size = new System.Drawing.Size(121, 21);
            this.textBox_time.TabIndex = 12;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(137, 161);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(53, 12);
            this.label_time.TabIndex = 13;
            this.label_time.Text = "扫描时间";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(135, 44);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(65, 12);
            this.label_id.TabIndex = 14;
            this.label_id.Text = "质检单编号";
            // 
            // txtGoodID
            // 
            this.txtGoodID.Location = new System.Drawing.Point(245, 216);
            this.txtGoodID.Name = "txtGoodID";
            this.txtGoodID.ReadOnly = true;
            this.txtGoodID.Size = new System.Drawing.Size(100, 21);
            this.txtGoodID.TabIndex = 16;
            // 
            // cBoxQA
            // 
            this.cBoxQA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxQA.FormattingEnabled = true;
            this.cBoxQA.Location = new System.Drawing.Point(245, 35);
            this.cBoxQA.Name = "cBoxQA";
            this.cBoxQA.Size = new System.Drawing.Size(121, 20);
            this.cBoxQA.TabIndex = 17;
            this.cBoxQA.TextChanged += new System.EventHandler(this.cBoxQA_TextChanged);
            // 
            // Form_scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 581);
            this.Controls.Add(this.cBoxQA);
            this.Controls.Add(this.txtGoodID);
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
            this.Controls.Add(this.textBox_rfid);
            this.Controls.Add(this.txtGoodName);
            this.Controls.Add(this.label_goodstype);
            this.Controls.Add(this.label_goodsid);
            this.MaximizeBox = false;
            this.Name = "Form_scan";
            this.Text = "商品扫描";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_scan_FormClosing);
            this.Load += new System.EventHandler(this.Form_scan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scanned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_goodsid;
        private System.Windows.Forms.Label label_goodstype;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.TextBox textBox_rfid;
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
        private System.Windows.Forms.TextBox txtGoodID;
        private System.Windows.Forms.ComboBox cBoxQA;
    }
}