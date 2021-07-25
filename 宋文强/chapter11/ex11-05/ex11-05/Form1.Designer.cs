namespace ex11_05
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBrowsing1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBrowsing2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBrowsing1,
            this.menuBrowsing2,
            this.menuStructure});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBrowsing1
            // 
            this.menuBrowsing1.Name = "menuBrowsing1";
            this.menuBrowsing1.Size = new System.Drawing.Size(119, 20);
            this.menuBrowsing1.Text = "查看数据集内容(1)";
            this.menuBrowsing1.Click += new System.EventHandler(this.menuBrowsing1_Click);
            // 
            // menuBrowsing2
            // 
            this.menuBrowsing2.Name = "menuBrowsing2";
            this.menuBrowsing2.Size = new System.Drawing.Size(119, 20);
            this.menuBrowsing2.Text = "查看数据集内容(2)";
            this.menuBrowsing2.Click += new System.EventHandler(this.menuBrowsing2_Click);
            // 
            // menuStructure
            // 
            this.menuStructure.Name = "menuStructure";
            this.menuStructure.Size = new System.Drawing.Size(101, 20);
            this.menuStructure.Text = "查看数据集结构";
            this.menuStructure.Click += new System.EventHandler(this.menuStructure_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(469, 146);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 170);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DataReader对象的应用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBrowsing1;
        private System.Windows.Forms.ToolStripMenuItem menuBrowsing2;
        private System.Windows.Forms.ToolStripMenuItem menuStructure;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

