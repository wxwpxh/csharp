using System;
using System.IO;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace BindingNavigatorSample
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.Run(new MyForm());
    }
  }

  public class MyForm : Form
  {
    private ComboBox _combo = new ComboBox();
    private ScrollablePictureBox _scrollBox = new ScrollablePictureBox();
    private BindingSource _source = new BindingSource();

    public MyForm()
    {
      Text = "BindingNavigator Sample";

      _combo.DataSource = Directory.GetFiles(AlbumManager.DefaultPath, "*.abm");
      _combo.Dock = DockStyle.Top;
      _combo.SelectionChangeCommitted += new EventHandler(combo_SelectionChangeCommitted);
      _scrollBox.BorderStyle = BorderStyle.Fixed3D;
      _scrollBox.Dock = DockStyle.Fill;
      
      BindingNavigator nav = new BindingNavigator(_source);
      nav.Dock = DockStyle.Bottom;
      
      Controls.AddRange(new Control[] { _scrollBox, _combo, nav });
    }

    protected override void OnLoad(EventArgs e)
    {
      OpenAlbum();
      base.OnLoad(e);
    }

    private void combo_SelectionChangeCommitted(object sender, EventArgs e)
    {
      OpenAlbum();
    }

    private void OpenAlbum()
    {
      string path = _combo.SelectedItem.ToString();
      try
      {
        AlbumManager am = new AlbumManager(path);
        _source.DataSource = am.Album;
        if (_scrollBox.DataBindings.Count == 0)
          _scrollBox.DataBindings.Add("Image", _source, "Image");
      }
      catch (AlbumStorageException)
      {
        _scrollBox.DataBindings.Clear();
        MessageBox.Show("Unable to open album");
      }
    }

  }
}