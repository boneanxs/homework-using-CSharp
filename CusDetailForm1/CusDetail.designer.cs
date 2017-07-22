namespace RFID_Read
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cost_Text = new System.Windows.Forms.Label();
            this.ID_Text = new System.Windows.Forms.Label();
            this.Cost_label = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.Items_Details = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.goodInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cost_Text);
            this.groupBox1.Controls.Add(this.ID_Text);
            this.groupBox1.Controls.Add(this.Cost_label);
            this.groupBox1.Controls.Add(this.ID_Label);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Cost_Text
            // 
            this.Cost_Text.AutoSize = true;
            this.Cost_Text.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cost_Text.Location = new System.Drawing.Point(405, 20);
            this.Cost_Text.Name = "Cost_Text";
            this.Cost_Text.Size = new System.Drawing.Size(16, 16);
            this.Cost_Text.TabIndex = 3;
            this.Cost_Text.Text = "0";
            // 
            // ID_Text
            // 
            this.ID_Text.AutoSize = true;
            this.ID_Text.Location = new System.Drawing.Point(127, 23);
            this.ID_Text.Name = "ID_Text";
            this.ID_Text.Size = new System.Drawing.Size(0, 12);
            this.ID_Text.TabIndex = 2;
            // 
            // Cost_label
            // 
            this.Cost_label.AutoSize = true;
            this.Cost_label.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cost_label.Location = new System.Drawing.Point(296, 17);
            this.Cost_label.Name = "Cost_label";
            this.Cost_label.Size = new System.Drawing.Size(85, 19);
            this.Cost_label.TabIndex = 1;
            this.Cost_label.Text = "消费金额";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ID_Label.Location = new System.Drawing.Point(23, 17);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(67, 19);
            this.ID_Label.TabIndex = 0;
            this.ID_Label.Text = "会员ID";
            //this.ID_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Items_Details
            // 
            this.Items_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_Details.Location = new System.Drawing.Point(13, 88);
            this.Items_Details.Name = "Items_Details";
            this.Items_Details.RowTemplate.Height = 23;
            this.Items_Details.Size = new System.Drawing.Size(575, 312);
            this.Items_Details.TabIndex = 1;
            //this.Items_Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goodInfoBindingSource
            // 
            this.goodInfoBindingSource.DataSource = typeof(RFID_Read.goodInfo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Items_Details);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label Cost_Text;
        private System.Windows.Forms.Label ID_Text;
        private System.Windows.Forms.Label Cost_label;
        private System.Windows.Forms.DataGridView Items_Details;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource goodInfoBindingSource;
    }
}

