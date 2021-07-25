using System;
using System.Drawing;
using System.Windows.Forms;

namespace Manning.Chapter08.MaskedSample
{
  /*
   * Just to be different, I wrote this sample as text,
   * without using Visual Studio.
   */
  partial class MaskedForm : Form
  {
    Label label1 = new Label();
    Label label2 = new Label();
    Label lblSettings = new Label();

    TextBox txtMask = new TextBox();
    MaskedTextBox mskSample = new MaskedTextBox();

    public MaskedForm()
    {
      TableLayoutPanel tablePanel = new TableLayoutPanel();

      label1.Text = "Mask String";
      label1.Dock = DockStyle.Fill;
      label1.TextAlign = ContentAlignment.MiddleRight;
      label2.Text = "MaskedTextBox";
      label2.Dock = DockStyle.Fill;
      label2.TextAlign = ContentAlignment.MiddleRight;
      lblSettings.BorderStyle = BorderStyle.Fixed3D;
      lblSettings.Dock = DockStyle.Fill;

      txtMask.Leave += HandleLeave;
      txtMask.Anchor = AnchorStyles.Left | AnchorStyles.Right;
      mskSample.TextChanged += HandleTextChanged;
      mskSample.Anchor = AnchorStyles.Left | AnchorStyles.Right;

      tablePanel.Dock = DockStyle.Fill;
      tablePanel.ColumnCount = 2;
      tablePanel.RowCount = 4;
      tablePanel.Controls.Add(label1);
      tablePanel.Controls.Add(txtMask);
      tablePanel.Controls.Add(label2);
      tablePanel.Controls.Add(mskSample);

      tablePanel.Controls.Add(lblSettings);
      tablePanel.SetColumnSpan(lblSettings, 2);
      tablePanel.SetRowSpan(lblSettings, 2);

      Text = "MaskedTextBox Sample";
      Size = new Size(200, 150);
      Controls.Add(tablePanel);
    }

    private void HandleLeave(object sender, EventArgs e)
    {
      mskSample.Mask = txtMask.Text;
    }

    private void HandleTextChanged(object sender, EventArgs e)
    {
      lblSettings.Text = String.Format(
        "Mask Result = {0}"
        + "\nMaskCompleted = {1} \nMaskFull = {2}",
        mskSample.Text,
        mskSample.MaskCompleted,
        mskSample.MaskFull);
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.Run(new MaskedForm());
    }
  }

}

