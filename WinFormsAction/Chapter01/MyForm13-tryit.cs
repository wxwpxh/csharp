using System;
using System.Drawing;
using System.Windows.Forms;

[assembly: System.Reflection.AssemblyVersion("1.3.2")]
namespace MyNamespace
{
  public class MyForm : Form
  {
    private Button btnLoad, btnLoad2;  
    private PictureBox pbxPhoto, pbxPhoto2;

    public MyForm()
    {
      // Constructor
      this.Text = "Hello Form 1.3 TRY IT";

      // Create and configure the Button
      btnLoad = new Button();
      btnLoad.Text = "&Load";
      btnLoad.Left = 10;
      btnLoad.Top = 10;
      btnLoad.Click += new System.EventHandler(this.OnLoadClick);

      // Create and configure the PictureBox
      pbxPhoto = new PictureBox();
      pbxPhoto.BorderStyle = BorderStyle.Fixed3D;
      pbxPhoto.Width = this.Width / 2;      
      pbxPhoto.Height = this.Height / 2;      
      pbxPhoto.Left = 0;
      pbxPhoto.Top = btnLoad.Bottom + 5;
      pbxPhoto.SizeMode = PictureBoxSizeMode.Zoom;

      // Create and configure the second Button
      btnLoad2 = new Button();
      btnLoad2.Text = "L&oad2";
      btnLoad2.Left = btnLoad.Right + 10;
      btnLoad2.Top = 10;
      btnLoad2.Click += new System.EventHandler(this.OnLoadClick);

      // Create and configure the PictureBox
      pbxPhoto2 = new PictureBox();
      pbxPhoto2.BorderStyle = BorderStyle.Fixed3D;
      pbxPhoto2.Width = this.Width / 2;      
      pbxPhoto2.Height = this.Height / 2;      
      pbxPhoto2.Left = pbxPhoto.Right + 5;
      pbxPhoto2.Top = pbxPhoto.Top;
      pbxPhoto2.SizeMode = PictureBoxSizeMode.Zoom;

      // Add our new controls to the Form
      this.Controls.Add(btnLoad);
      this.Controls.Add(pbxPhoto);  
      this.Controls.Add(btnLoad2);
      this.Controls.Add(pbxPhoto2);  
    }

    // Note here how one constructor can invoke another, in this
    // case to create our button and picture box controls.
    public MyForm(string imageFile) : this()
    {
      Console.WriteLine("Image 0 is " + imageFile);
      pbxPhoto.Image = new Bitmap(imageFile);
    }    

    public MyForm(string imageFile0, string imageFile1) : this(imageFile0)
    {
      Console.WriteLine("Image 1 is " + imageFile1);
      pbxPhoto2.Image = new Bitmap(imageFile1);
    }    

    // This code does something slightly different than suggested
    // in the book.  We use the "OnLoadClick" handler as the Click
    // handler for both buttons, and make use of the "sender"
    // parameter to determine which PictureBox to use.
    protected void OnLoadClick(object sender, System.EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();

      dlg.Title = "Open Photo";
      dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*" ;

      if (dlg.ShowDialog() == DialogResult.OK)
      {
        if (sender == btnLoad2)
          pbxPhoto2.Image = new Bitmap(dlg.OpenFile());
        else
          pbxPhoto.Image = new Bitmap(dlg.OpenFile());
      }

      dlg.Dispose();
    }

    // Note that the [0] argument is the first parameter, rather
    // than the executable name as it is in C++.
    [STAThread]
    public static void Main(string[] args)
    {
      Application.EnableVisualStyles();

      if (args.Length < 1)
        Application.Run(new MyForm());
      else if (args.Length > 1)
        Application.Run(new MyForm(args[0], args[1]));
      else
        Application.Run(new MyForm(args[0]));
    }
  }
}
