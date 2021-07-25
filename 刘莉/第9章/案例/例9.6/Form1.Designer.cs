namespace 例8._5
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
            this.FileName = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Files = new System.Windows.Forms.ListBox();
            this.Folder = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LastAccessTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LastModifyTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CreationTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FileSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FileFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要查找的文件";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(34, 34);
            this.FileName.Margin = new System.Windows.Forms.Padding(2);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(296, 23);
            this.FileName.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(334, 34);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(54, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "搜索";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Files);
            this.groupBox1.Controls.Add(this.Folder);
            this.groupBox1.Location = new System.Drawing.Point(26, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(395, 210);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "所有文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "所有子目录";
            // 
            // Files
            // 
            this.Files.FormattingEnabled = true;
            this.Files.ItemHeight = 17;
            this.Files.Location = new System.Drawing.Point(205, 43);
            this.Files.Margin = new System.Windows.Forms.Padding(2);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(172, 157);
            this.Files.TabIndex = 1;
            this.Files.SelectedIndexChanged += new System.EventHandler(this.Files_SelectedIndexChanged);
            // 
            // Folder
            // 
            this.Folder.FormattingEnabled = true;
            this.Folder.ItemHeight = 17;
            this.Folder.Location = new System.Drawing.Point(14, 43);
            this.Folder.Margin = new System.Windows.Forms.Padding(2);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(172, 157);
            this.Folder.TabIndex = 0;
            this.Folder.SelectedIndexChanged += new System.EventHandler(this.Folder_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LastAccessTime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.LastModifyTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CreationTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.FileSize);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.FileFullName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(34, 282);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(395, 122);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件详细信息";
            // 
            // LastAccessTime
            // 
            this.LastAccessTime.Location = new System.Drawing.Point(281, 87);
            this.LastAccessTime.Margin = new System.Windows.Forms.Padding(2);
            this.LastAccessTime.Name = "LastAccessTime";
            this.LastAccessTime.ReadOnly = true;
            this.LastAccessTime.Size = new System.Drawing.Size(106, 23);
            this.LastAccessTime.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "最后访问时间";
            // 
            // LastModifyTime
            // 
            this.LastModifyTime.Location = new System.Drawing.Point(88, 87);
            this.LastModifyTime.Margin = new System.Windows.Forms.Padding(2);
            this.LastModifyTime.Name = "LastModifyTime";
            this.LastModifyTime.ReadOnly = true;
            this.LastModifyTime.Size = new System.Drawing.Size(106, 23);
            this.LastModifyTime.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "最后修改时间";
            // 
            // CreationTime
            // 
            this.CreationTime.Location = new System.Drawing.Point(281, 49);
            this.CreationTime.Margin = new System.Windows.Forms.Padding(2);
            this.CreationTime.Name = "CreationTime";
            this.CreationTime.ReadOnly = true;
            this.CreationTime.Size = new System.Drawing.Size(106, 23);
            this.CreationTime.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "创建时间";
            // 
            // FileSize
            // 
            this.FileSize.Location = new System.Drawing.Point(71, 49);
            this.FileSize.Margin = new System.Windows.Forms.Padding(2);
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.Size = new System.Drawing.Size(119, 23);
            this.FileSize.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "文件大小";
            // 
            // FileFullName
            // 
            this.FileFullName.Location = new System.Drawing.Point(71, 18);
            this.FileFullName.Margin = new System.Windows.Forms.Padding(2);
            this.FileFullName.Name = "FileFullName";
            this.FileFullName.ReadOnly = true;
            this.FileFullName.Size = new System.Drawing.Size(316, 23);
            this.FileFullName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "完整路径";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " 文件浏览器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Files;
        private System.Windows.Forms.ListBox Folder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox LastModifyTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CreationTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FileSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FileFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastAccessTime;
        private System.Windows.Forms.Label label9;
    }
}

