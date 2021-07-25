using System;
using System.Drawing;
using System.Windows.Forms;

[assembly: System.Reflection.AssemblyVersion("1.3")]
namespace MyNamespace
{
  public class MyForm : Form
  {
    private Button btnLoad;
    private PictureBox pbxPhoto;

    public MyForm()
    {
      this.Text = "Hello Form 1.3";

      // Create and configure a button
      btnLoad = new Button();
      btnLoad.Text = "&Load";
      btnLoad.Left = 10;
      btnLoad.Top = 10;
      btnLoad.Click += new EventHandler(this.HandleLoadClick);

      // Create and configure a picture box
      pbxPhoto = new PictureBox();
      pbxPhoto.BorderStyle = BorderStyle.Fixed3D;
      pbxPhoto.Width = this.Width / 2;
      pbxPhoto.Height = this.Height / 2;
      pbxPhoto.Left = (this.Width - pbxPhoto.Width) / 2;
      pbxPhoto.Top = (this.Height - pbxPhoto.Height) / 2;
      pbxPhoto.SizeMode = PictureBoxSizeMode.Zoom;

      // Add our new controls to the form
      this.Controls.Add(btnLoad);
      this.Controls.Add(pbxPhoto);
    }

    private void HandleLoadClick(object sender, System.EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();
      dlg.Title = "Open Photo";
      dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
      if (dlg.ShowDialog() == DialogResult.OK)
      {
        pbxPhoto.Image = new Bitmap(dlg.OpenFile());
      }

      dlg.Dispose();
    }

    [STAThread]
    public static void Main()
    {
      Application.EnableVisualStyles();
      Application.Run(new MyForm());
    }
  }
}
