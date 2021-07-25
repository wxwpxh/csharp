namespace ListViewSample
{
	partial class ListViewForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.nudSize = new System.Windows.Forms.NumericUpDown();
			this.lvNumbers = new System.Windows.Forms.ListView();
			this.btnClose = new System.Windows.Forms.Button();
			this.columnValue = new System.Windows.Forms.ColumnHeader();
			((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Size:";
			// 
			// nudSize
			// 
			this.nudSize.Location = new System.Drawing.Point(53, 7);
			this.nudSize.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudSize.Name = "nudSize";
			this.nudSize.Size = new System.Drawing.Size(120, 20);
			this.nudSize.TabIndex = 1;
			this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
			// 
			// lvNumbers
			// 
			this.lvNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lvNumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnValue});
			this.lvNumbers.Location = new System.Drawing.Point(12, 33);
			this.lvNumbers.Name = "lvNumbers";
			this.lvNumbers.Size = new System.Drawing.Size(268, 192);
			this.lvNumbers.TabIndex = 2;
			this.lvNumbers.UseCompatibleStateImageBehavior = false;
			this.lvNumbers.View = System.Windows.Forms.View.Details;
			this.lvNumbers.VirtualMode = true;
			this.lvNumbers.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lvNumbers_RetrieveVirtualItem);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.Location = new System.Drawing.Point(109, 231);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// columnValue
			// 
			this.columnValue.Text = "Numeric Value";
			this.columnValue.Width = 182;
			// 
			// ListViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lvNumbers);
			this.Controls.Add(this.nudSize);
			this.Controls.Add(this.label1);
			this.Name = "ListViewForm";
			this.Text = "Virtual Items Sample";
			((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudSize;
		private System.Windows.Forms.ListView lvNumbers;
		private System.Windows.Forms.ColumnHeader columnValue;
		private System.Windows.Forms.Button btnClose;
	}
}

