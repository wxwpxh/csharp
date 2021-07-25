using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyPhotos
{
	/// <summary>
	/// Summary description for PixelDlg.
	/// </summary>
	public class PixelDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblBlueVal;
		private System.Windows.Forms.Label lblGreenVal;
		private System.Windows.Forms.Label lblRedVal;
		private System.Windows.Forms.Label lblYVal;
		private System.Windows.Forms.Label lblXVal;
		private System.Windows.Forms.Button btnClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PixelDlg()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblBlueVal = new System.Windows.Forms.Label();
			this.lblGreenVal = new System.Windows.Forms.Label();
			this.lblRedVal = new System.Windows.Forms.Label();
			this.lblYVal = new System.Windows.Forms.Label();
			this.lblXVal = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "X:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Y:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Red:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Green:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Blue:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblBlueVal
			// 
			this.lblBlueVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblBlueVal.Location = new System.Drawing.Point(80, 136);
			this.lblBlueVal.Name = "lblBlueVal";
			this.lblBlueVal.Size = new System.Drawing.Size(48, 16);
			this.lblBlueVal.TabIndex = 9;
			// 
			// lblGreenVal
			// 
			this.lblGreenVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblGreenVal.Location = new System.Drawing.Point(80, 104);
			this.lblGreenVal.Name = "lblGreenVal";
			this.lblGreenVal.Size = new System.Drawing.Size(48, 16);
			this.lblGreenVal.TabIndex = 8;
			// 
			// lblRedVal
			// 
			this.lblRedVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblRedVal.Location = new System.Drawing.Point(80, 72);
			this.lblRedVal.Name = "lblRedVal";
			this.lblRedVal.Size = new System.Drawing.Size(48, 16);
			this.lblRedVal.TabIndex = 7;
			// 
			// lblYVal
			// 
			this.lblYVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblYVal.Location = new System.Drawing.Point(80, 32);
			this.lblYVal.Name = "lblYVal";
			this.lblYVal.Size = new System.Drawing.Size(48, 16);
			this.lblYVal.TabIndex = 6;
			// 
			// lblXVal
			// 
			this.lblXVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblXVal.Location = new System.Drawing.Point(80, 8);
			this.lblXVal.Name = "lblXVal";
			this.lblXVal.Size = new System.Drawing.Size(48, 16);
			this.lblXVal.TabIndex = 5;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(35, 168);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// PixelDlg
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(144, 205);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnClose,
																		  this.lblBlueVal,
																		  this.lblGreenVal,
																		  this.lblRedVal,
																		  this.lblYVal,
																		  this.lblXVal,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PixelDlg";
			this.Text = "Pixel Values";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		public int XVal
		{
			set { lblXVal.Text = value.ToString(); }
		}
		public int YVal
		{
			set { lblYVal.Text = value.ToString(); }
		}
		public int RedVal
		{
			set { lblRedVal.Text = value.ToString(); }
		}

		public int GreenVal
		{
			set { lblGreenVal.Text = value.ToString(); }
		}

		public int BlueVal
		{
			set { lblBlueVal.Text = value.ToString(); }
		}

		// end of PixelDlg
	}
}
