namespace ex8_02
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorGreenripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorPurple = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColorRed,
            this.menuColorGreenripMenuItem,
            this.menuColorBlue,
            this.menuColorPurple,
            this.menuColorYellow,
            this.menuColorWhite});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 136);
            // 
            // menuColorRed
            // 
            this.menuColorRed.Name = "menuColorRed";
            this.menuColorRed.Size = new System.Drawing.Size(112, 22);
            this.menuColorRed.Text = "红色(&R)";
            this.menuColorRed.Click += new System.EventHandler(this.menuColorRed_Click);
            // 
            // menuColorGreenripMenuItem
            // 
            this.menuColorGreenripMenuItem.Name = "menuColorGreenripMenuItem";
            this.menuColorGreenripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.menuColorGreenripMenuItem.Text = "绿色(&G)";
            this.menuColorGreenripMenuItem.Click += new System.EventHandler(this.menuColorGreenripMenuItem_Click);
            // 
            // menuColorBlue
            // 
            this.menuColorBlue.Name = "menuColorBlue";
            this.menuColorBlue.Size = new System.Drawing.Size(112, 22);
            this.menuColorBlue.Text = "蓝色(&B)";
            this.menuColorBlue.Click += new System.EventHandler(this.menuColorBlue_Click);
            // 
            // menuColorPurple
            // 
            this.menuColorPurple.Name = "menuColorPurple";
            this.menuColorPurple.Size = new System.Drawing.Size(112, 22);
            this.menuColorPurple.Text = "紫色(&P)";
            this.menuColorPurple.Click += new System.EventHandler(this.menuColorPurple_Click);
            // 
            // menuColorYellow
            // 
            this.menuColorYellow.Name = "menuColorYellow";
            this.menuColorYellow.Size = new System.Drawing.Size(112, 22);
            this.menuColorYellow.Text = "黄色(&Y)";
            this.menuColorYellow.Click += new System.EventHandler(this.menuColorYellow_Click);
            // 
            // menuColorWhite
            // 
            this.menuColorWhite.Name = "menuColorWhite";
            this.menuColorWhite.Size = new System.Drawing.Size(112, 22);
            this.menuColorWhite.Text = "白色(&W)";
            this.menuColorWhite.Click += new System.EventHandler(this.menuColorWhite_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 158);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 158);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "设置图片框的背景色";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuColorRed;
        private System.Windows.Forms.ToolStripMenuItem menuColorGreenripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuColorBlue;
        private System.Windows.Forms.ToolStripMenuItem menuColorPurple;
        private System.Windows.Forms.ToolStripMenuItem menuColorYellow;
        private System.Windows.Forms.ToolStripMenuItem menuColorWhite;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

