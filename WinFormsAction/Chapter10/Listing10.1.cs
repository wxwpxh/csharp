using System.Drawing;
using System.Windows.Forms;

public class MouseSample : Form
{
  public MouseSample()
  {
    Text = "Mouse Sample";
    MouseDown += HandleMouseDown;
    MouseUp += HandleMouseUp;
  }

  public void HandleMouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button == MouseButtons.Left)
      BackColor = Color.Purple;
    else if (e.Button == MouseButtons.Right)
      BackColor = Color.Yellow;
  }

  public void HandleMouseUp(object sender, MouseEventArgs e)
  {
    BackColor = SystemColors.Control;
  }

  public static void Main()
  {
    Application.Run(new MouseSample());
  }
}
