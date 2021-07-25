namespace exci9
{
    partial class Form2
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbutton4 = new System.Windows.Forms.RadioButton();
            this.rbutton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbutton2 = new System.Windows.Forms.RadioButton();
            this.rbutton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(195, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 18);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "粗体";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbutton4);
            this.groupBox2.Controls.Add(this.rbutton3);
            this.groupBox2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(110, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(70, 80);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "大小";
            // 
            // rbutton4
            // 
            this.rbutton4.AutoSize = true;
            this.rbutton4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutton4.ForeColor = System.Drawing.Color.Blue;
            this.rbutton4.Location = new System.Drawing.Point(13, 45);
            this.rbutton4.Name = "rbutton4";
            this.rbutton4.Size = new System.Drawing.Size(39, 18);
            this.rbutton4.TabIndex = 1;
            this.rbutton4.TabStop = true;
            this.rbutton4.Text = "16";
            this.rbutton4.UseVisualStyleBackColor = true;
            this.rbutton4.CheckedChanged += new System.EventHandler(this.rbutton4_CheckedChanged);
            // 
            // rbutton3
            // 
            this.rbutton3.AutoSize = true;
            this.rbutton3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutton3.ForeColor = System.Drawing.Color.Blue;
            this.rbutton3.Location = new System.Drawing.Point(13, 23);
            this.rbutton3.Name = "rbutton3";
            this.rbutton3.Size = new System.Drawing.Size(39, 18);
            this.rbutton3.TabIndex = 0;
            this.rbutton3.TabStop = true;
            this.rbutton3.Text = "10";
            this.rbutton3.UseVisualStyleBackColor = true;
            this.rbutton3.CheckedChanged += new System.EventHandler(this.rbutton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbutton2);
            this.groupBox1.Controls.Add(this.rbutton1);
            this.groupBox1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(29, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(70, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字体";
            // 
            // rbutton2
            // 
            this.rbutton2.AutoSize = true;
            this.rbutton2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbutton2.ForeColor = System.Drawing.Color.Blue;
            this.rbutton2.Location = new System.Drawing.Point(13, 45);
            this.rbutton2.Name = "rbutton2";
            this.rbutton2.Size = new System.Drawing.Size(55, 18);
            this.rbutton2.TabIndex = 1;
            this.rbutton2.TabStop = true;
            this.rbutton2.Text = "楷体";
            this.rbutton2.UseVisualStyleBackColor = true;
            this.rbutton2.CheckedChanged += new System.EventHandler(this.rbutton2_CheckedChanged);
            // 
            // rbutton1
            // 
            this.rbutton1.AutoSize = true;
            this.rbutton1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbutton1.ForeColor = System.Drawing.Color.Blue;
            this.rbutton1.Location = new System.Drawing.Point(13, 23);
            this.rbutton1.Name = "rbutton1";
            this.rbutton1.Size = new System.Drawing.Size(55, 18);
            this.rbutton1.TabIndex = 0;
            this.rbutton1.TabStop = true;
            this.rbutton1.Text = "宋体";
            this.rbutton1.UseVisualStyleBackColor = true;
            this.rbutton1.CheckedChanged += new System.EventHandler(this.rbutton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 51);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "中华人民共和国成立70周年";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbutton4;
        private System.Windows.Forms.RadioButton rbutton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbutton2;
        private System.Windows.Forms.RadioButton rbutton1;
        private System.Windows.Forms.TextBox textBox1;
    }
}