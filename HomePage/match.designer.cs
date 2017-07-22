namespace MIS
{
    partial class match
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
            this.txtbox_rfid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("SimSun", 18F);
            this.label_id.Location = new System.Drawing.Point(394, 146);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(82, 24);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "会员ID";
            // 
            // label_rfid
            // 
            this.label_rfid.AutoSize = true;
            this.label_rfid.Font = new System.Drawing.Font("SimSun", 18F);
            this.label_rfid.Location = new System.Drawing.Point(326, 265);
            this.label_rfid.Name = "label_rfid";
            this.label_rfid.Size = new System.Drawing.Size(154, 24);
            this.label_rfid.TabIndex = 1;
            this.label_rfid.Text = "RFID标签编号";
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(533, 146);
            this.txtBox_id.Multiline = true;
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(120, 25);
            this.txtBox_id.TabIndex = 3;
            // 
            // btn_match
            // 
            this.btn_match.AutoSize = true;
            this.btn_match.Font = new System.Drawing.Font("SimSun", 18F);
            this.btn_match.Location = new System.Drawing.Point(434, 381);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(116, 34);
            this.btn_match.TabIndex = 4;
            this.btn_match.Text = "确定配对";
            this.btn_match.UseVisualStyleBackColor = true;
            this.btn_match.Click += new System.EventHandler(this.btn_match_Click);
            // 
            // txtbox_rfid
            // 
            this.txtbox_rfid.Location = new System.Drawing.Point(524, 265);
            this.txtbox_rfid.Multiline = true;
            this.txtbox_rfid.Name = "txtbox_rfid";
            this.txtbox_rfid.Size = new System.Drawing.Size(120, 25);
            this.txtbox_rfid.TabIndex = 16;
            // 
            // match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 581);
            this.Controls.Add(this.txtbox_rfid);
            this.Controls.Add(this.btn_match);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.label_rfid);
            this.Controls.Add(this.label_id);
            this.MaximizeBox = false;
            this.Name = "match";
            this.Text = "配对";
            this.Load += new System.EventHandler(this.match_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_rfid;
        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.Button btn_match;
        private System.Windows.Forms.TextBox txtbox_rfid;
    }
}

