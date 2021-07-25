using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace ColorTabApp
{
	static class TabControlSampleMain
	{
		// modify this path to the proper location
		static string CommonImageLibrary
			= @"C:\Program Files\Microsoft Visual Studio 8\Common7\VS2005ImageLibrary\";

		[STAThread]
		static void Main()
		{
			if (Directory.Exists(CommonImageLibrary) == false)
			{
				string msg = "CommonImageLibrary is not a valid path";
				MessageBox.Show(msg);
				throw new ApplicationException(msg);
			}

			// Create tab control
			ColorTabControl tab = new ColorTabControl();

			// Assign tab properties
			tab.Dock = DockStyle.Fill;
			tab.ShowToolTips = true;
			tab.SelectedTabColor = Color.Blue;
			tab.TabColor = Color.Gray;
			tab.Alignment = TabAlignment.Left;

			// Construct an image list of images
			// Any images can be used here, these are just an example
			ImageList iList = new ImageList();
			iList.ImageSize = new Size(16, 16);
			string s1 = CommonImageLibrary
				+ "bitmaps\\misc\\" + "ActionRequired_03.bmp";
			Image image1 = new Bitmap(s1);
			Image image2 = new Bitmap(CommonImageLibrary
				+ "bitmaps\\misc\\" + "SuccessComplete.bmp");
			iList.Images.AddRange(new Image[] { image1, image2 });
			iList.TransparentColor = Color.Fuchsia;

			tab.ImageList = iList;

			// Create anonymous Click handler for Open menu
			EventHandler openHandler = delegate(object s, EventArgs e)
			{
				string path = null;
				string pwd = null;
				if (AlbumController.OpenAlbumDialog(ref path, ref pwd))
				{
					PopulateTabControl(tab, path, pwd);
				}
			};
			EventHandler alignmentHandler = delegate(object s, EventArgs e)
			{
				ToolStripMenuItem item = s as ToolStripMenuItem;
				if (item != null)
				{
					string align = item.Text;
					TabAlignment setting = (TabAlignment) Enum.Parse(typeof(TabAlignment), align);
					if (Enum.IsDefined(typeof(TabAlignment), setting))
						tab.Alignment = setting;
				}
			};

			// Create context menu
			ContextMenuStrip menu = new ContextMenuStrip();
			menu.Items.Add("&Open Album", null, openHandler);
			menu.Items.Add("Top", null, alignmentHandler);
			menu.Items.Add("Left", null, alignmentHandler);
			menu.Items.Add("Right", null, alignmentHandler);
			menu.Items.Add("Bottom", null, alignmentHandler);

			// Create and kick off form
			Form f = new Form();
			f.Text = "Right click to open a new album";
			f.ContextMenuStrip = menu;
			f.Controls.Add(tab);

			Application.EnableVisualStyles();
			Application.Run(f);
		}

		static void PopulateTabControl(TabControl tab, string path, string password)
		{
			PhotoAlbum album = tab.Tag as PhotoAlbum;
			try
			{
				if (album != null)
					album.Dispose();

				album = AlbumStorage.ReadAlbum(path, password);
				tab.Tag = album;
			}
			catch (AlbumStorageException aex)
			{
				MessageBox.Show("Unable to open album: " + aex.Message);
			}

			// Fill tab control with contents of album
			try
			{
				tab.SuspendLayout();
				tab.TabPages.Clear();

				// Creates a tab page for each photograph
				foreach (Photograph p in album)
				{
					PictureBox pbx = new PictureBox();
					pbx.Dock = DockStyle.Fill;
					pbx.Image = p.Image;
					pbx.SizeMode = PictureBoxSizeMode.AutoSize;

					string file = Path.GetFileNameWithoutExtension(p.FileName);
					TabPage page = new TabPage();
					page.Text = file;
					page.BorderStyle = BorderStyle.FixedSingle;
					page.ToolTipText = p.FileName;
					page.AutoScroll = true;
					page.AutoScrollMinSize = pbx.Image.Size;
					page.Controls.Add(pbx);

					tab.TabPages.Add(page);

					// Add a 0 or 1 as the image index.
					page.ImageIndex = tab.TabCount % 2;
				}
			}
			finally
			{
				tab.ResumeLayout();
			}
		}
	}
}