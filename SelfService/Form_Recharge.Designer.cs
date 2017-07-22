namespace SelfService
{
    partial class Form_Recharge
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
            this.label_tips = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            this.label_sum = new System.Windows.Forms.Label();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_tips
            // 
            this.label_tips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tips.AutoSize = true;
            this.label_tips.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips.Location = new System.Drawing.Point(142, 25);
            this.label_tips.Name = "label_tips";
            this.label_tips.Size = new System.Drawing.Size(247, 20);
            this.label_tips.TabIndex = 0;
            this.label_tips.Text = "请将会员卡放在读卡器上，谢谢合作。";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(146, 84);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "姓名";
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(146, 150);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(29, 12);
            this.label_balance.TabIndex = 2;
            this.label_balance.Text = "余额";
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(146, 199);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(53, 12);
            this.label_sum.TabIndex = 3;
            this.label_sum.Text = "充值金额";
            // 
            // textBox_balance
            // 
            this.textBox_balance.Location = new System.Drawing.Point(247, 150);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.ReadOnly = true;
            this.textBox_balance.Size = new System.Drawing.Size(100, 21);
            this.textBox_balance.TabIndex = 4;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(245, 199);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(100, 21);
            this.textBox_sum.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(247, 84);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 7;
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(203, 268);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 23);
            this.button_enter.TabIndex = 8;
            this.button_enter.Text = "确定";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // Form_Recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 341);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.textBox_balance);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_tips);
            this.Name = "Form_Recharge";
            this.Text = "金额充值";
            this.Load += new System.EventHandler(this.Form_Recharge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tips;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_enter;
    }
}