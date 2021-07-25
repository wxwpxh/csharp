[assembly: System.Reflection.AssemblyVersion("1.0.*")]

namespace MyNamespace
{
    public class MyForm : System.Windows.Forms.Form
    {
        public MyForm()
        {
            // Constructor
	    this.Text = "Hello Form";
        }


    public static void Main()
        {
            System.Windows.Forms.Application.Run(new MyForm());
        }
    }
}
