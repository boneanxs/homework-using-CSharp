namespace MIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanFloor));
            this.graph = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.traceGraph = new System.Windows.Forms.PictureBox();
            this.RfID_ID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.loc_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traceGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(73, 85);
            this.graph.Margin = new System.Windows.Forms.Padding(0);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(579, 613);
            this.graph.TabIndex = 5;
            this.graph.TabStop = false;
            this.graph.Click += new System.EventHandler(this.graph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.traceGraph);
            this.groupBox1.Controls.Add(this.RfID_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // traceGraph
            // 
            this.traceGraph.BackColor = System.Drawing.Color.Transparent;
            this.traceGraph.Location = new System.Drawing.Point(-29, -12);
            this.traceGraph.Margin = new System.Windows.Forms.Padding(0);
            this.traceGraph.Name = "traceGraph";
            this.traceGraph.Size = new System.Drawing.Size(579, 613);
            this.traceGraph.TabIndex = 8;
            this.traceGraph.TabStop = false;
            // 
            // RfID_ID
            // 
            this.RfID_ID.FormattingEnabled = true;
            this.RfID_ID.Location = new System.Drawing.Point(240, 24);
            this.RfID_ID.Name = "RfID_ID";
            this.RfID_ID.Size = new System.Drawing.Size(121, 20);
            this.RfID_ID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "会员ID:";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(440, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(131, 36);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "搜索/停止搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // loc_Icon
            // 
            this.loc_Icon.BackColor = System.Drawing.Color.Transparent;
            this.loc_Icon.Image = ((System.Drawing.Image)(resources.GetObject("loc_Icon.Image")));
            this.loc_Icon.Location = new System.Drawing.Point(0, 0);
            this.loc_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.loc_Icon.Name = "loc_Icon";
            this.loc_Icon.Size = new System.Drawing.Size(40, 40);
            this.loc_Icon.TabIndex = 7;
            this.loc_Icon.TabStop = false;
            this.loc_Icon.Visible = false;
            // 
            // PlanFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(747, 733);
            this.Controls.Add(this.loc_Icon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graph);
            this.MaximizeBox = false;
            this.Name = "PlanFloor";
            this.Text = "平面图";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanFloor_FormClosing);
            this.Load += new System.EventHandler(this.PlanFloor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.traceGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox RfID_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox loc_Icon;
        private System.Windows.Forms.PictureBox traceGraph;
    }
}

