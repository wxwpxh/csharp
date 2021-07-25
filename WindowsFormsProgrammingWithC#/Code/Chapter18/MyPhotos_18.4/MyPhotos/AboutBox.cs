using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using AxSHDocVw;

namespace MyPhotos
{
	/// <summary>
	/// Summary description for AboutBox.
	/// </summary>
	public class AboutBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageIcons;
		private System.Windows.Forms.Label lblIcon;
		private System.Windows.Forms.Label lblAboutText;
		private System.Windows.Forms.LinkLabel linkWebSite;
		private System.Windows.Forms.LinkLabel linkClose;
		private System.Windows.Forms.Panel pnlWebSite;
		private System.ComponentModel.IContainer components;

		public AboutBox()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		protected const int SDI_ICON = 0;
		protected const int MDI_ICON = 1;

		private AxWebBrowser browser;
		private const string startPage
			= "www.manning.com/eebrown";

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AboutBox));
			this.imageIcons = new System.Windows.Forms.ImageList(this.components);
			this.lblIcon = new System.Windows.Forms.Label();
			this.lblAboutText = new System.Windows.Forms.Label();
			this.linkWebSite = new System.Windows.Forms.LinkLabel();
			this.linkClose = new System.Windows.Forms.LinkLabel();
			this.pnlWebSite = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// imageIcons
			// 
			this.imageIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageIcons.ImageSize = new System.Drawing.Size(32, 32);
			this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
			this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lblIcon
			// 
			this.lblIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIcon.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblIcon.Image")));
			this.lblIcon.ImageIndex = 0;
			this.lblIcon.ImageList = this.imageIcons;
			this.lblIcon.Location = new System.Drawing.Point(8, 8);
			this.lblIcon.Name = "lblIcon";
			this.lblIcon.Size = new System.Drawing.Size(56, 48);
			this.lblIcon.TabIndex = 0;
			// 
			// lblAboutText
			// 
			this.lblAboutText.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.lblAboutText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblAboutText.Location = new System.Drawing.Point(72, 8);
			this.lblAboutText.Name = "lblAboutText";
			this.lblAboutText.Size = new System.Drawing.Size(312, 56);
			this.lblAboutText.TabIndex = 1;
			this.lblAboutText.Text = "MyPhotos";
			// 
			// linkWebSite
			// 
			this.linkWebSite.Location = new System.Drawing.Point(8, 72);
			this.linkWebSite.Name = "linkWebSite";
			this.linkWebSite.Size = new System.Drawing.Size(176, 16);
			this.linkWebSite.TabIndex = 2;
			this.linkWebSite.TabStop = true;
			this.linkWebSite.Text = "Click for book\'s web site";
			this.linkWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebSite_LinkClicked);
			// 
			// linkClose
			// 
			this.linkClose.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.linkClose.Location = new System.Drawing.Point(216, 72);
			this.linkClose.Name = "linkClose";
			this.linkClose.Size = new System.Drawing.Size(168, 16);
			this.linkClose.TabIndex = 3;
			this.linkClose.TabStop = true;
			this.linkClose.Text = "Click to close window";
			this.linkClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.linkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClose_LinkClicked);
			// 
			// pnlWebSite
			// 
			this.pnlWebSite.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.pnlWebSite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlWebSite.Location = new System.Drawing.Point(8, 96);
			this.pnlWebSite.Name = "pnlWebSite";
			this.pnlWebSite.Size = new System.Drawing.Size(376, 16);
			this.pnlWebSite.TabIndex = 4;
			this.pnlWebSite.Visible = false;
			// 
			// AboutBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 117);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pnlWebSite,
																		  this.linkClose,
																		  this.linkWebSite,
																		  this.lblAboutText,
																		  this.lblIcon});
			this.MinimizeBox = false;
			this.Name = "AboutBox";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About MyPhotos";
			this.ResumeLayout(false);

		}
		#endregion

		private void linkClose_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Close();
		}

		private void linkWebSite_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (browser != null)
			{
				// Shut down existing browser
				pnlWebSite.Visible = false;
				browser.Dispose();
				browser = null;

				// Reset dialog settings
				linkWebSite.Text = "Click for book's web site";
				this.Size = new Size(400, 140);
				this.Text = "About MyPhotos";
			}
			else
			{
				// Create web browser object
				browser = new AxWebBrowser();
				browser.Dock = DockStyle.Fill;

				browser.TitleChange += new DWebBrowserEvents2_TitleChangeEventHandler(this.browser_TitleChange);
				browser.HandleCreated += new EventHandler(this.browser_HandleCreated);

				// Show panel containing new browser
				pnlWebSite.SuspendLayout();
				pnlWebSite.Visible = true;
				pnlWebSite.Controls.Add(browser);
				pnlWebSite.ResumeLayout();
		
				linkWebSite.Text = "Click to hide web page";
				this.Size = new Size(600, 400);
			}
		}

		public bool IsMdiApplication
		{
			get { return (lblIcon.ImageIndex == MDI_ICON); }
			set
			{
				if (value)
					lblIcon.ImageIndex = MDI_ICON;
				else
					lblIcon.ImageIndex = SDI_ICON;
			}
		}

		public string AboutText
		{
			get { return lblAboutText.Text; }
			set { lblAboutText.Text = value; }
		}

		private void browser_TitleChange(object sender, DWebBrowserEvents2_TitleChangeEvent e)
		{
			this.Text = e.text;
		}

		protected void DisplayPage(string url)
		{
			// These are required because the importer
			// assumes these are in/out parameters
			// and defines them as passed by reference.
			object param2 = 0;
			object param3 = "";
			object param4 = "";
			object param5 = "";

			try
			{
				Cursor.Current = Cursors.WaitCursor;
				browser.Navigate(url,
					ref param2, ref param3,
					ref param4, ref param5);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		public void browser_HandleCreated(object sender, EventArgs evArgs) 
		{
			// The WebBrowser has been created
			// Display the starting page
			DisplayPage(startPage);

			// Remove this handler
			browser.HandleCreated -= new EventHandler(this.browser_HandleCreated);
		}



		// end of AboutBox class
	}
}
