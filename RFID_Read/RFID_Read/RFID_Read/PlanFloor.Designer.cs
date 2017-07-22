namespace Ichnographyn
{
    partial class PlanFloor
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
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RfID_ID = new System.Windows.Forms.ComboBox();
            this.graph = new System.Windows.Forms.PictureBox();
            this.label_door = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(580, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(131, 36);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "搜索/停止搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(227, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "RFID标签序号:";
            // 
            // RfID_ID
            // 
            this.RfID_ID.FormattingEnabled = true;
            this.RfID_ID.Location = new System.Drawing.Point(350, 22);
            this.RfID_ID.Name = "RfID_ID";
            this.RfID_ID.Size = new System.Drawing.Size(121, 20);
            this.RfID_ID.TabIndex = 4;
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(32, 54);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(903, 541);
            this.graph.TabIndex = 5;
            this.graph.TabStop = false;
            this.graph.Click += new System.EventHandler(this.graph_Click);
            this.graph.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Paint);
            // 
            // label_door
            // 
            this.label_door.BackColor = System.Drawing.Color.Gray;
            this.label_door.Font = new System.Drawing.Font("NSimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_door.ForeColor = System.Drawing.Color.Black;
            this.label_door.Location = new System.Drawing.Point(300, 550);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(150, 35);
            this.label_door.TabIndex = 6;
            this.label_door.Text = "门禁";
            this.label_door.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlanFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label_door);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.RfID_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.MaximizeBox = false;
            this.Name = "PlanFloor";
            this.Text = "平面图";
            this.Load += new System.EventHandler(this.PlanFloor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RfID_ID;
        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.Label label_door;
    }
}

