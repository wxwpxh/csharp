namespace ex10_06
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
            this.brushSolid = new System.Windows.Forms.ToolStripMenuItem();
            this.brushHatch = new System.Windows.Forms.ToolStripMenuItem();
            this.brushLinearGradient = new System.Windows.Forms.ToolStripMenuItem();
            this.brushPathGradient = new System.Windows.Forms.ToolStripMenuItem();
            this.brushTexture = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brushSolid,
            this.brushHatch,
            this.brushLinearGradient,
            this.brushPathGradient,
            this.brushTexture});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // brushSolid
            // 
            this.brushSolid.Name = "brushSolid";
            this.brushSolid.Size = new System.Drawing.Size(65, 20);
            this.brushSolid.Text = "单色笔刷";
            this.brushSolid.Click += new System.EventHandler(this.brushSolid_Click);
            // 
            // brushHatch
            // 
            this.brushHatch.Name = "brushHatch";
            this.brushHatch.Size = new System.Drawing.Size(65, 20);
            this.brushHatch.Text = "图案笔刷";
            this.brushHatch.Click += new System.EventHandler(this.brushHatch_Click);
            // 
            // brushLinearGradient
            // 
            this.brushLinearGradient.Name = "brushLinearGradient";
            this.brushLinearGradient.Size = new System.Drawing.Size(89, 20);
            this.brushLinearGradient.Text = "线性渐变笔刷";
            this.brushLinearGradient.Click += new System.EventHandler(this.brushLinearGradient_Click);
            // 
            // brushPathGradient
            // 
            this.brushPathGradient.Name = "brushPathGradient";
            this.brushPathGradient.Size = new System.Drawing.Size(89, 20);
            this.brushPathGradient.Text = "路径渐变笔刷";
            this.brushPathGradient.Click += new System.EventHandler(this.brushPathGradient_Click);
            // 
            // brushTexture
            // 
            this.brushTexture.Name = "brushTexture";
            this.brushTexture.Size = new System.Drawing.Size(65, 20);
            this.brushTexture.Text = "纹理笔刷";
            this.brushTexture.Click += new System.EventHandler(this.brushTexture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 266);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Brush的派生类";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem brushSolid;
        private System.Windows.Forms.ToolStripMenuItem brushHatch;
        private System.Windows.Forms.ToolStripMenuItem brushLinearGradient;
        private System.Windows.Forms.ToolStripMenuItem brushPathGradient;
        private System.Windows.Forms.ToolStripMenuItem brushTexture;
    }
}

