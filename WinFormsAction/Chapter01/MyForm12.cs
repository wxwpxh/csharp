using System;
using System.Windows.Forms;

[assembly: System.Reflection.AssemblyVersion("1.2")]
namespace MyNamespace
{
  public class MyForm : Form
  {
    private Button btnLoad;
    private PictureBox pbxPhoto;

    public MyForm()
    {
      this.Text = "Hello Form 1.2";

      // Create and configure a button
      btnLoad = new Button();
      btnLoad.Text = "&Load";
      btnLoad.Left = 10;
      btnLoad.Top = 10;

      // Create and configure a picture box
      pbxPhoto = new PictureBox();
      pbxPhoto.BorderStyle = BorderStyle.Fixed3D;
      pbxPhoto.Width = this.Width / 2;
      pbxPhoto.Height = this.Height / 2;
      pbxPhoto.Left = (this.Width - pbxPhoto.Width) / 2;
      pbxPhoto.Top = (this.Height - pbxPhoto.Height) / 2;

      // Add our new controls to the form
      this.Controls.Add(btnLoad);
      this.Controls.Add(pbxPhoto);
    }

    [STAThread]
    public static void Main()
    {
      Application.EnableVisualStyles();
      Application.Run(new MyForm());
    }
  }
}
