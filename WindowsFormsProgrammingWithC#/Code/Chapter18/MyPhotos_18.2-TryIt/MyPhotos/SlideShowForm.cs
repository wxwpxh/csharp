using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;

namespace MyPhotos
{
	/// <summary>
	/// Summary description for SlideShowForm.
	/// </summary>
	public class SlideShowForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackSlide;
		private System.Windows.Forms.Timer slideTimer;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtInterval;
		private Manning.MyPhotoAlbum.PhotoBox pboxSlide;
		private System.ComponentModel.IContainer components;

		public SlideShowForm(PhotoAlbum album)
		{
			// Required for Form Designer support
			InitializeComponent();

			// Other initialization
			_album = album;
			_albumPos = 0;
		}

		private PhotoAlbum _album;
		private int _albumPos;

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
			this.label1 = new System.Windows.Forms.Label();
			this.txtInterval = new System.Windows.Forms.TextBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.trackSlide = new System.Windows.Forms.TrackBar();
			this.slideTimer = new System.Windows.Forms.Timer(this.components);
			this.pboxSlide = new Manning.MyPhotoAlbum.PhotoBox();
			((System.ComponentModel.ISupportInitialize)(this.trackSlide)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.label1.Location = new System.Drawing.Point(8, 216);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Interval: ";
			// 
			// txtInterval
			// 
			this.txtInterval.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.txtInterval.Location = new System.Drawing.Point(64, 214);
			this.txtInterval.Name = "txtInterval";
			this.txtInterval.Size = new System.Drawing.Size(32, 20);
			this.txtInterval.TabIndex = 2;
			this.txtInterval.Text = "2";
			// 
			// btnStop
			// 
			this.btnStop.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnStop.Location = new System.Drawing.Point(120, 213);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(72, 23);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "&Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.Location = new System.Drawing.Point(208, 213);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(72, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// trackSlide
			// 
			this.trackSlide.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.trackSlide.Location = new System.Drawing.Point(10, 256);
			this.trackSlide.Name = "trackSlide";
			this.trackSlide.Size = new System.Drawing.Size(270, 42);
			this.trackSlide.TabIndex = 5;
			this.trackSlide.Scroll += new System.EventHandler(this.trackSlide_Scroll);
			// 
			// slideTimer
			// 
			this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
			// 
			// pboxSlide
			// 
			this.pboxSlide.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.pboxSlide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pboxSlide.Location = new System.Drawing.Point(8, 8);
			this.pboxSlide.Name = "pboxSlide";
			this.pboxSlide.Size = new System.Drawing.Size(280, 192);
			this.pboxSlide.TabIndex = 6;
			this.pboxSlide.TabStop = false;
			// 
			// SlideShowForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 313);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pboxSlide,
																		  this.trackSlide,
																		  this.btnClose,
																		  this.btnStop,
																		  this.txtInterval,
																		  this.label1});
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SlideShowForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SlideShowForm";
			((System.ComponentModel.ISupportInitialize)(this.trackSlide)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		protected void SetInterval()
		{
			int interval = 0;
			try
			{
				interval = Convert.ToInt32(txtInterval.Text);
			}
			catch
			{
				// Reset interval value
				txtInterval.Text = "2";
				interval = 2;
			}

			slideTimer.Interval = interval * 1000;
		}

		protected override void OnLoad(EventArgs e)
		{
			SetInterval();
			slideTimer.Enabled = true;

			trackSlide.Minimum = 0;
			trackSlide.Maximum = _album.Count - 1;
			AssignImage();

			base.OnLoad(e);
		}

		private void slideTimer_Tick(object sender, System.EventArgs e)
		{
			_albumPos ++;
			if (_albumPos > _album.Count)
			{
				btnStop.Text = "&Start";
				_albumPos = 0;
				AssignImage();
				slideTimer.Enabled = false;
			}
			else if (_albumPos == _album.Count)
			{
				this.Text = "Finished";
			}
			else
			{
				AssignImage();
			}

			// Reset the interval
			SetInterval();
		}

		private void btnStop_Click(object sender, System.EventArgs e)
		{
			if (btnStop.Text == "&Stop")
			{
				// Stop
				slideTimer.Stop();
				btnStop.Text = "Re&sume";
			}
			else
			{
				// Resume or Start
				slideTimer.Start();
				btnStop.Text = "&Stop";
			}
		}

		private void trackSlide_Scroll(object sender, System.EventArgs e)
		{
			_albumPos = trackSlide.Value;
			AssignImage();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void AssignImage()
		{
			trackSlide.Value = _albumPos;

			this.Text = String.Format("{0} ({1:#}/{2:#})",
				_album[_albumPos].Caption,
				_albumPos + 1, _album.Count);
			pboxSlide.Image = _album[_albumPos].Image;
		}

		// end of SlidShowForm
	}
}
