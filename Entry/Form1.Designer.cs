namespace Entry
{
    partial class entry
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MIS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_charge = new System.Windows.Forms.Button();
            this.btn_consign = new System.Windows.Forms.Button();
            this.btn_sale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MIS
            // 
            this.btn_MIS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_MIS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MIS.Location = new System.Drawing.Point(113, 152);
            this.btn_MIS.Name = "btn_MIS";
            this.btn_MIS.Size = new System.Drawing.Size(115, 45);
            this.btn_MIS.TabIndex = 0;
            this.btn_MIS.Text = "MIS登录入口";
            this.btn_MIS.UseVisualStyleBackColor = false;
            this.btn_MIS.Click += new System.EventHandler(this.btn_MIS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(147, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "未来超市系统各功能入口";
            // 
            // btn_charge
            // 
            this.btn_charge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_charge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_charge.Location = new System.Drawing.Point(312, 152);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(115, 45);
            this.btn_charge.TabIndex = 5;
            this.btn_charge.Text = "自助充值入口";
            this.btn_charge.UseVisualStyleBackColor = false;
            this.btn_charge.Click += new System.EventHandler(this.btn_charge_Click);
            // 
            // btn_consign
            // 
            this.btn_consign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_consign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consign.Location = new System.Drawing.Point(113, 252);
            this.btn_consign.Name = "btn_consign";
            this.btn_consign.Size = new System.Drawing.Size(115, 45);
            this.btn_consign.TabIndex = 6;
            this.btn_consign.Text = "寄存管理入口";
            this.btn_consign.UseVisualStyleBackColor = false;
            this.btn_consign.Click += new System.EventHandler(this.btn_consign_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sale.Location = new System.Drawing.Point(312, 252);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(115, 45);
            this.btn_sale.TabIndex = 7;
            this.btn_sale.Text = "结账功能入口";
            this.btn_sale.UseVisualStyleBackColor = false;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(561, 401);
            this.Controls.Add(this.btn_sale);
            this.Controls.Add(this.btn_consign);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MIS);
            this.MaximizeBox = false;
            this.Name = "entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "统一入口";
            this.Load += new System.EventHandler(this.entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_charge;
        private System.Windows.Forms.Button btn_consign;
        private System.Windows.Forms.Button btn_sale;
    }
}

