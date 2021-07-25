namespace MyAlbumData
{
	partial class DataForm
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
			this.comboAlbum = new System.Windows.Forms.ComboBox();
			this.gridPhotoAlbum = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Album:";
			// 
			// comboAlbum
			// 
			this.comboAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboAlbum.DropDownWidth = 500;
			this.comboAlbum.FormattingEnabled = true;
			this.comboAlbum.Location = new System.Drawing.Point(57, 6);
			this.comboAlbum.Name = "comboAlbum";
			this.comboAlbum.Size = new System.Drawing.Size(263, 21);
			this.comboAlbum.TabIndex = 1;
			this.comboAlbum.SelectionChangeCommitted += new System.EventHandler(this.comboAlbum_SelectionChangeCommitted);
			// 
			// gridPhotoAlbum
			// 
			this.gridPhotoAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gridPhotoAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPhotoAlbum.Location = new System.Drawing.Point(12, 33);
			this.gridPhotoAlbum.Name = "gridPhotoAlbum";
			this.gridPhotoAlbum.Size = new System.Drawing.Size(418, 192);
			this.gridPhotoAlbum.TabIndex = 2;
			this.gridPhotoAlbum.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPhotoAlbum_CellMouseDown);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(355, 231);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// DataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 266);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.gridPhotoAlbum);
			this.Controls.Add(this.comboAlbum);
			this.Controls.Add(this.label1);
			this.Name = "DataForm";
			this.Text = "MyAlbumData";
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboAlbum;
		private System.Windows.Forms.DataGridView gridPhotoAlbum;
		private System.Windows.Forms.Button btnClose;
	}
}

