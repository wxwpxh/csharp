namespace 例6._7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.磅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.磅ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.字形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加粗ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.楷体ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.红色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.蓝色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绿色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.默认颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.红色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.绿色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.蓝色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.默认颜色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.字体ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy,
            this.cut,
            this.粘贴ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(116, 22);
            this.copy.Text = "复制(&C)";
            this.copy.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(116, 22);
            this.cut.Text = "剪切";
            this.cut.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Enabled = false;
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字号ToolStripMenuItem,
            this.字形ToolStripMenuItem});
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.字体ToolStripMenuItem.Text = "字体";
            // 
            // 字号ToolStripMenuItem
            // 
            this.字号ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.磅ToolStripMenuItem,
            this.磅ToolStripMenuItem1});
            this.字号ToolStripMenuItem.Name = "字号ToolStripMenuItem";
            this.字号ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.字号ToolStripMenuItem.Text = "宋体";
            // 
            // 磅ToolStripMenuItem
            // 
            this.磅ToolStripMenuItem.Name = "磅ToolStripMenuItem";
            this.磅ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.磅ToolStripMenuItem.Text = "12磅";
            this.磅ToolStripMenuItem.Click += new System.EventHandler(this.磅ToolStripMenuItem_Click);
            // 
            // 磅ToolStripMenuItem1
            // 
            this.磅ToolStripMenuItem1.Name = "磅ToolStripMenuItem1";
            this.磅ToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.磅ToolStripMenuItem1.Text = "16磅";
            this.磅ToolStripMenuItem1.Click += new System.EventHandler(this.磅ToolStripMenuItem1_Click);
            // 
            // 字形ToolStripMenuItem
            // 
            this.字形ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加粗ToolStripMenuItem2,
            this.楷体ToolStripMenuItem1});
            this.字形ToolStripMenuItem.Name = "字形ToolStripMenuItem";
            this.字形ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.字形ToolStripMenuItem.Text = "楷体";
            // 
            // 加粗ToolStripMenuItem2
            // 
            this.加粗ToolStripMenuItem2.Name = "加粗ToolStripMenuItem2";
            this.加粗ToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.加粗ToolStripMenuItem2.Text = "加粗";
            this.加粗ToolStripMenuItem2.Click += new System.EventHandler(this.加粗ToolStripMenuItem2_Click);
            // 
            // 楷体ToolStripMenuItem1
            // 
            this.楷体ToolStripMenuItem1.Name = "楷体ToolStripMenuItem1";
            this.楷体ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.楷体ToolStripMenuItem1.Text = "下划线";
            this.楷体ToolStripMenuItem1.Click += new System.EventHandler(this.楷体ToolStripMenuItem1_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.红色ToolStripMenuItem,
            this.蓝色ToolStripMenuItem,
            this.绿色ToolStripMenuItem,
            this.toolStripSeparator2,
            this.默认颜色ToolStripMenuItem});
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.颜色ToolStripMenuItem.Text = "颜色";
            // 
            // 红色ToolStripMenuItem
            // 
            this.红色ToolStripMenuItem.Name = "红色ToolStripMenuItem";
            this.红色ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.红色ToolStripMenuItem.Text = "红色";
            this.红色ToolStripMenuItem.Click += new System.EventHandler(this.红色ToolStripMenuItem_Click);
            // 
            // 蓝色ToolStripMenuItem
            // 
            this.蓝色ToolStripMenuItem.Name = "蓝色ToolStripMenuItem";
            this.蓝色ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.蓝色ToolStripMenuItem.Text = "蓝色";
            this.蓝色ToolStripMenuItem.Click += new System.EventHandler(this.蓝色ToolStripMenuItem_Click);
            // 
            // 绿色ToolStripMenuItem
            // 
            this.绿色ToolStripMenuItem.Name = "绿色ToolStripMenuItem";
            this.绿色ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.绿色ToolStripMenuItem.Text = "绿色";
            this.绿色ToolStripMenuItem.Click += new System.EventHandler(this.绿色ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // 默认颜色ToolStripMenuItem
            // 
            this.默认颜色ToolStripMenuItem.Checked = true;
            this.默认颜色ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.默认颜色ToolStripMenuItem.Name = "默认颜色ToolStripMenuItem";
            this.默认颜色ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.默认颜色ToolStripMenuItem.Text = "默认颜色";
            this.默认颜色ToolStripMenuItem.Click += new System.EventHandler(this.默认颜色ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "-";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "默认颜色";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(7, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 164);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.红色ToolStripMenuItem1,
            this.绿色ToolStripMenuItem1,
            this.蓝色ToolStripMenuItem1,
            this.默认颜色ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 92);
            // 
            // 红色ToolStripMenuItem1
            // 
            this.红色ToolStripMenuItem1.Name = "红色ToolStripMenuItem1";
            this.红色ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.红色ToolStripMenuItem1.Text = "红色";
            this.红色ToolStripMenuItem1.Click += new System.EventHandler(this.红色ToolStripMenuItem1_Click);
            // 
            // 绿色ToolStripMenuItem1
            // 
            this.绿色ToolStripMenuItem1.Name = "绿色ToolStripMenuItem1";
            this.绿色ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.绿色ToolStripMenuItem1.Text = "绿色";
            this.绿色ToolStripMenuItem1.Click += new System.EventHandler(this.绿色ToolStripMenuItem1_Click);
            // 
            // 蓝色ToolStripMenuItem1
            // 
            this.蓝色ToolStripMenuItem1.Name = "蓝色ToolStripMenuItem1";
            this.蓝色ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.蓝色ToolStripMenuItem1.Text = "蓝色";
            this.蓝色ToolStripMenuItem1.Click += new System.EventHandler(this.蓝色ToolStripMenuItem1_Click);
            // 
            // 默认颜色ToolStripMenuItem1
            // 
            this.默认颜色ToolStripMenuItem1.Checked = true;
            this.默认颜色ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.默认颜色ToolStripMenuItem1.Name = "默认颜色ToolStripMenuItem1";
            this.默认颜色ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.默认颜色ToolStripMenuItem1.Text = "默认颜色";
            this.默认颜色ToolStripMenuItem1.Click += new System.EventHandler(this.默认颜色ToolStripMenuItem1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "我的编辑器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 红色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 蓝色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绿色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 磅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 磅ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 字形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加粗ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 楷体ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 红色ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 绿色ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 蓝色ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 默认颜色ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

