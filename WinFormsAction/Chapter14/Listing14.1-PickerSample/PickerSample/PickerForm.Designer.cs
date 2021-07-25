namespace PickerSample
{
	partial class PickerForm
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
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.comboProperty = new System.Windows.Forms.ComboBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Date:";
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(60, 8);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(199, 20);
			this.dtpDate.TabIndex = 1;
			this.dtpDate.Value = new System.DateTime(2005, 2, 24, 0, 0, 0, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "Property:";
			// 
			// comboProperty
			// 
			this.comboProperty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboProperty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboProperty.FormattingEnabled = true;
			this.comboProperty.Items.AddRange(new object[] {
            "BackColor",
            "CalendarForeColor",
            "CalendarMonthBackground",
            "CalendarTitleBackColor",
            "CalendarTitleForeColor",
            "CalendarTrailingForeColor",
            "ForeColor"});
			this.comboProperty.Location = new System.Drawing.Point(60, 50);
			this.comboProperty.Name = "comboProperty";
			this.comboProperty.Size = new System.Drawing.Size(199, 21);
			this.comboProperty.Sorted = true;
			this.comboProperty.TabIndex = 3;
			this.comboProperty.Text = "BackColor";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(161, 103);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnColor
			// 
			this.btnColor.Location = new System.Drawing.Point(36, 103);
			this.btnColor.Name = "btnColor";
			this.btnColor.TabIndex = 6;
			this.btnColor.Text = "Colo&r...";
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 140);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.comboProperty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "DateTimePicker Sample";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboProperty;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnColor;
	}
}

