using System;
using System.IO;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace TabControlSample
{
  /// <summary>
  /// This code shows the combination of Listing 13.1
  /// and 13.2, combined.
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
          TabPage page = new TabPage(file);
          page.BorderStyle = BorderStyle.FixedSingle;
          page.ToolTipText = p.FileName;
          page.AutoScroll = true;
          page.AutoScrollMinSize = pbx.Image.Size;
          page.Controls.Add(pbx);

          tab.TabPages.Add(page);
        }
      }
      finally
      {
        tab.ResumeLayout();
      }
    }
  }
}