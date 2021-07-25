using System;
using System.IO;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace TabControlSample
{
	/// <summary>
	/// This application is the Try It in section 13.2.2.
	/// </summary>
	static class TabControlSampleMain
	{
		[STAThread]
		static void Main()
		{
			// Create tab control
			TabControl tab = new TabControl();
			tab.Dock = DockStyle.Fill;
			tab.ShowToolTips = true;

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

			// Create context menu
			ContextMenuStrip menu = new ContextMenuStrip();
			menu.Items.Add("&Open Album", null, openHandler);

			// Create and kick off form
			Form f = new Form();
			f.Text = "Right click to open a new album";
			f.ContextMenuStrip = menu;
			f.Controls.Add(tab);

			// Try It Handlers
			tab.Selecting += HandleSelecting;
			tab.Deselected += delegate(object s, TabControlEventArgs e)
			{
				TabPage page = e.TabPage;
				page.Controls.Clear();

				Photograph p = page.Tag as Photograph;
				if (p != null)
					p.ReleaseImage();
			};

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
					string file = Path.GetFileNameWithoutExtension(p.FileName);

					// Create a new tab page
					TabPage page = new TabPage(file);
					page.BorderStyle = BorderStyle.FixedSingle;
					page.ToolTipText = p.FileName;
					page.AutoScroll = true;

					// Associate photo with tab
					page.Tag = p;

					tab.TabPages.Add(page);
					if (tab.TabCount == 1)
						CreatePictureBox(page);
				}
			}
			finally
			{
				tab.ResumeLayout();
			}
		}

		static public void HandleSelecting(object s, TabControlCancelEventArgs e)
		{
			TabPage page = e.TabPage;
			if (page != null)
				CreatePictureBox(page);
		}

		static public void CreatePictureBox(TabPage page)
		{
			Photograph p = page.Tag as Photograph;

			if (page.Controls.Count == 0 && p != null)
			{
				// Add PictureBox
				PictureBox pbx = new PictureBox();
				pbx.Dock = DockStyle.Fill;
				pbx.Image = p.Image;
				pbx.SizeMode = PictureBoxSizeMode.AutoSize;

				page.AutoScrollMinSize = pbx.Image.Size;
				page.Controls.Add(pbx);
			}
		}

	}
}