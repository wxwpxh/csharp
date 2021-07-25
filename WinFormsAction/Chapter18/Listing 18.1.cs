using System;
using System.Drawing;
using System.Windows.Forms;

namespace SplitContainerExample
{
  static class SplitContainerProgram
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();

      SplitContainer split2 = new SplitContainer();
      split2.Dock = DockStyle.Fill;
      split2.Orientation = Orientation.Horizontal;
      split2.Panel1.BackColor = Color.LightGray;
      split2.Panel2.BackColor = Color.DarkGray;

      // Create split1 container to hold split2 container
      SplitContainer split1 = new SplitContainer();
      split1.Dock = DockStyle.Fill;
      split1.Panel1.BackColor = Color.WhiteSmoke;
      split1.SplitterWidth = 10;
      split1.Panel2.Controls.Add(split2);

      // Create a form to hold split1 container
      Form f = new Form();
      f.Text = "SplitContainer example";
      f.Controls.Add(split1);

      // Display the form
      Application.Run(f);
    }
  }
}