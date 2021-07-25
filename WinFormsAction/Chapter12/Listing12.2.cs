using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoCompleteSample
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Form f = new Form();
      f.Text = "AutoComplete Sample";
      f.Size = new Size(300, 100);

      TableLayoutPanel panel = new TableLayoutPanel();
      panel.Dock = DockStyle.Fill;
      panel.ColumnCount = 2;
      panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75));
      panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
      
      Label l1 = new Label();
      l1.Text = "Files:";
      l1.TextAlign = ContentAlignment.MiddleRight;
      
      Label l2 = new Label();
      l2.Text = "Web Sites:";
      l2.TextAlign = ContentAlignment.MiddleRight;

      TextBox txtFiles = new TextBox();
      txtFiles.Width = 120;
      txtFiles.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      txtFiles.AutoCompleteMode = AutoCompleteMode.Suggest;
      txtFiles.AutoCompleteSource = AutoCompleteSource.FileSystem;
      
      TextBox txtSites = new TextBox();
      txtSites.Width = 120;
      txtSites.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      txtSites.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      txtSites.AutoCompleteSource = AutoCompleteSource.AllUrl;
      
      panel.Controls.Add(l1);
      panel.Controls.Add(txtFiles);
      panel.Controls.Add(l2);
      panel.Controls.Add(txtSites);
      f.Controls.Add(panel);
      
      Application.Run(f);
    }
  }
}
