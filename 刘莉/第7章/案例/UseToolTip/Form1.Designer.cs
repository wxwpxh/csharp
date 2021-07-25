namespace UseToolTip
{
    partial class RichTextBox的使用
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.justifyLeft = new System.Windows.Forms.Button();
            this.justifyCenter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.justifyRight = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(330, 185);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.Open);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑区域";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(213, 207);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(65, 32);
            this.Save.TabIndex = 2;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(69, 207);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(65, 32);
            this.Open.TabIndex = 1;
            this.Open.Text = "打开";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // justifyLeft
            // 
            this.justifyLeft.AutoSize = true;
            this.justifyLeft.Image = global::UseToolTip.Properties.Resources.左对齐;
            this.justifyLeft.Location = new System.Drawing.Point(69, 19);
            this.justifyLeft.Name = "justifyLeft";
            this.justifyLeft.Size = new System.Drawing.Size(28, 24);
            this.justifyLeft.TabIndex = 2;
            this.justifyLeft.UseVisualStyleBackColor = true;
            this.justifyLeft.Click += new System.EventHandler(this.justifyLeft_Click);
            // 
            // justifyCenter
            // 
            this.justifyCenter.AutoSize = true;
            this.justifyCenter.Image = global::UseToolTip.Properties.Resources.居中对齐;
            this.justifyCenter.Location = new System.Drawing.Point(167, 19);
            this.justifyCenter.Name = "justifyCenter";
            this.justifyCenter.Size = new System.Drawing.Size(28, 23);
            this.justifyCenter.TabIndex = 3;
            this.justifyCenter.UseVisualStyleBackColor = true;
            this.justifyCenter.Click += new System.EventHandler(this.justifyCenter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.justifyRight);
            this.groupBox2.Controls.Add(this.justifyCenter);
            this.groupBox2.Controls.Add(this.justifyLeft);
            this.groupBox2.Location = new System.Drawing.Point(6, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 59);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "格式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "右对齐：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "居中对齐：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "左对齐：";
            // 
            // justifyRight
            // 
            this.justifyRight.AutoSize = true;
            this.justifyRight.Image = global::UseToolTip.Properties.Resources.右对齐;
            this.justifyRight.Location = new System.Drawing.Point(260, 16);
            this.justifyRight.Name = "justifyRight";
            this.justifyRight.Size = new System.Drawing.Size(28, 26);
            this.justifyRight.TabIndex = 4;
            this.justifyRight.UseVisualStyleBackColor = true;
            this.justifyRight.Click += new System.EventHandler(this.justifyRight_Click);
            // 
            // RichTextBox的使用
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RichTextBox的使用";
            this.Text = "RichTextBox的使用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button justifyLeft;
        private System.Windows.Forms.Button justifyCenter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button justifyRight;
    }
}

