using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;

namespace MyPhotos
{
	public partial class SlideShowDialog : Form
	{
		private AlbumManager _manager;
		private SoundPlayer _soundPlayer;
		
		private AlbumManager Manager { get { return _manager; } }
		private SoundPlayer Player { get { return _soundPlayer; } }

		public SlideShowDialog(AlbumManager manager)
		{
			if (manager == null || manager.Album == null || manager.Album.Count == 0)
				throw new ArgumentException("manager");

			InitializeComponent();
			
			// Other initialization
			_manager = manager;
			InitializeForm();
		}

		private void InitializeForm()
		{
			// Set button images, with White transparent
			Bitmap bmp = MyPhotos.Properties.Resources.NextBitmap;
			bmp.MakeTransparent(Color.White);
			btnNext.Image = bmp;
			
			bmp = MyPhotos.Properties.Resources.PrevBitmap;
			bmp.MakeTransparent(Color.White);
			btnPrev.Image = bmp;

			trackAlbum.Maximum = Manager.Album.Count - 1;
			UpdateDialog();

			// Assign sound for slide show
			_soundPlayer = new SoundPlayer(
				MyPhotos.Properties.Resources.DingSound);
		}

		private void UpdateDialog()
		{
			int index = trackAlbum.Value;
			if (index < Manager.Album.Count)
			{
				Photograph p = Manager.Album[index];
				pbxSlide.Image = p.Image;
				Text = p.Caption;
			}
		}

		private void trackAlbum_ValueChanged(object sender, EventArgs e)
		{
			UpdateDialog();
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (trackAlbum.Value > 0)
				trackAlbum.Value--;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (trackAlbum.Value < trackAlbum.Maximum)
				trackAlbum.Value++;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (btnStart.Text == "Pau&se")
			{
				timerSlide.Stop();
				btnStart.Text = "Re&sume";
			}
			else // "&Start" or "Re&sume"
			{
				timerSlide.Start();
				btnStart.Text = "Pau&se";
			}
		}

		private void timerSlide_Tick(object sender, EventArgs e)
		{
			int n = trackAlbum.Value + 1;
			if (n >= Manager.Album.Count)
			{
				// We are finished
				timerSlide.Stop();
				Text = "Finished";
				btnStart.Text = "&Start";
				n = 0;
			}

			trackAlbum.Value = n;
			Player.Play();
		}

		private void nudInterval_ValueChanged(object sender, EventArgs e)
		{
			// Set timer to this many seconds
			timerSlide.Interval = (int)nudInterval.Value * 1000;
		}

	}
}