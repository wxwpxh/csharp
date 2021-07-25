[assembly: System.Reflection.AssemblyVersion("1.0")]
namespace MyNamespace
{
  public class MyForm : System.Windows.Forms.Form
  {
    public MyForm()
    {
      this.Text = "Hello Form";
    }

    [System.STAThread]
    public static void Main()
    {
      System.Windows.Forms.Application.EnableVisualStyles();
      System.Windows.Forms.Application.Run(new MyForm());
    }
  }
}
