namespace 例8._6
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
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.RichTextBox();
            this.Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(87, 6);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(170, 26);
            this.fname.TabIndex = 1;
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(263, 4);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(67, 28);
            this.Read.TabIndex = 2;
            this.Read.Text = "读";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(0, 37);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(431, 288);
            this.content.TabIndex = 3;
            this.content.Text = "";
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(347, 3);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(67, 28);
            this.Write.TabIndex = 4;
            this.Write.Text = "写";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 335);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.content);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "文件的读写";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Button Write;
    }
}

