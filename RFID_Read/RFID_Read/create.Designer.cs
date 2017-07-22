namespace Rfid_id
{
    partial class create
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_rfid = new System.Windows.Forms.Label();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.btn_match = new System.Windows.Forms.Button();
            this.dataGridView_rfid_no = new System.Windows.Forms.DataGridView();
            this.label_tip = new System.Windows.Forms.Label();
            this.textBox_inquiry = new System.Windows.Forms.TextBox();
            this.label_inquiry = new System.Windows.Forms.Label();
            this.label_note1 = new System.Windows.Forms.Label();
            this.label_note2 = new System.Windows.Forms.Label();
            this.btn_inquiry = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.txtbox_rfid = new System.Windows.Forms.TextBox();
            this.会员ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID标签编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rfid_no)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(55, 68);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(41, 12);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "会员ID";
            // 
            // label_rfid
            // 
            this.label_rfid.AutoSize = true;
            this.label_rfid.Location = new System.Drawing.Point(20, 117);
            this.label_rfid.Name = "label_rfid";
            this.label_rfid.Size = new System.Drawing.Size(77, 12);
            this.label_rfid.TabIndex = 1;
            this.label_rfid.Text = "RFID标签编号";
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(102, 65);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(121, 21);
            this.txtBox_id.TabIndex = 3;
            // 
            // btn_match
            // 
            this.btn_match.Location = new System.Drawing.Point(83, 155);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(75, 23);
            this.btn_match.TabIndex = 4;
            this.btn_match.Text = "确定配对";
            this.btn_match.UseVisualStyleBackColor = true;
            // 
            // dataGridView_rfid_no
            // 
            this.dataGridView_rfid_no.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rfid_no.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.会员ID,
            this.RFID标签编号});
            this.dataGridView_rfid_no.Location = new System.Drawing.Point(247, 59);
            this.dataGridView_rfid_no.Name = "dataGridView_rfid_no";
            this.dataGridView_rfid_no.RowTemplate.Height = 23;
            this.dataGridView_rfid_no.Size = new System.Drawing.Size(325, 310);
            this.dataGridView_rfid_no.TabIndex = 5;
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Location = new System.Drawing.Point(245, 29);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(137, 12);
            this.label_tip.TabIndex = 6;
            this.label_tip.Text = "已配对的有源RFID标签：";
            // 
            // textBox_inquiry
            // 
            this.textBox_inquiry.Location = new System.Drawing.Point(123, 260);
            this.textBox_inquiry.Name = "textBox_inquiry";
            this.textBox_inquiry.Size = new System.Drawing.Size(100, 21);
            this.textBox_inquiry.TabIndex = 10;
            // 
            // label_inquiry
            // 
            this.label_inquiry.AutoSize = true;
            this.label_inquiry.Location = new System.Drawing.Point(37, 263);
            this.label_inquiry.Name = "label_inquiry";
            this.label_inquiry.Size = new System.Drawing.Size(71, 12);
            this.label_inquiry.TabIndex = 9;
            this.label_inquiry.Text = "编号/会员ID";
            // 
            // label_note1
            // 
            this.label_note1.AutoSize = true;
            this.label_note1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_note1.Location = new System.Drawing.Point(22, 29);
            this.label_note1.Name = "label_note1";
            this.label_note1.Size = new System.Drawing.Size(53, 12);
            this.label_note1.TabIndex = 11;
            this.label_note1.Text = "新建配对";
            // 
            // label_note2
            // 
            this.label_note2.AutoSize = true;
            this.label_note2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_note2.Location = new System.Drawing.Point(19, 212);
            this.label_note2.Name = "label_note2";
            this.label_note2.Size = new System.Drawing.Size(53, 12);
            this.label_note2.TabIndex = 12;
            this.label_note2.Text = "查询配对";
            // 
            // btn_inquiry
            // 
            this.btn_inquiry.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_inquiry.Location = new System.Drawing.Point(83, 346);
            this.btn_inquiry.Name = "btn_inquiry";
            this.btn_inquiry.Size = new System.Drawing.Size(75, 23);
            this.btn_inquiry.TabIndex = 13;
            this.btn_inquiry.Text = "查询配对";
            this.btn_inquiry.UseVisualStyleBackColor = true;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(19, 309);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(95, 12);
            this.label_result.TabIndex = 14;
            this.label_result.Text = "对应会员ID/编号";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(123, 304);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(100, 21);
            this.textBox_result.TabIndex = 15;
            // 
            // txtbox_rfid
            // 
            this.txtbox_rfid.Location = new System.Drawing.Point(102, 114);
            this.txtbox_rfid.Name = "txtbox_rfid";
            this.txtbox_rfid.Size = new System.Drawing.Size(121, 21);
            this.txtbox_rfid.TabIndex = 16;
            // 
            // 会员ID
            // 
            this.会员ID.HeaderText = "会员ID";
            this.会员ID.Name = "会员ID";
            this.会员ID.Width = 140;
            // 
            // RFID标签编号
            // 
            this.RFID标签编号.HeaderText = "RFID标签编号";
            this.RFID标签编号.Name = "RFID标签编号";
            this.RFID标签编号.Width = 140;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.txtbox_rfid);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.btn_inquiry);
            this.Controls.Add(this.label_note2);
            this.Controls.Add(this.label_note1);
            this.Controls.Add(this.textBox_inquiry);
            this.Controls.Add(this.label_inquiry);
            this.Controls.Add(this.label_tip);
            this.Controls.Add(this.dataGridView_rfid_no);
            this.Controls.Add(this.btn_match);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.label_rfid);
            this.Controls.Add(this.label_id);
            this.MaximizeBox = false;
            this.Name = "create";
            this.Text = "有源RFID配对";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rfid_no)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_rfid;
        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.Button btn_match;
        private System.Windows.Forms.DataGridView dataGridView_rfid_no;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.TextBox textBox_inquiry;
        private System.Windows.Forms.Label label_inquiry;
        private System.Windows.Forms.Label label_note1;
        private System.Windows.Forms.Label label_note2;
        private System.Windows.Forms.Button btn_inquiry;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn 会员ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID标签编号;
        private System.Windows.Forms.TextBox txtbox_rfid;
    }
}

