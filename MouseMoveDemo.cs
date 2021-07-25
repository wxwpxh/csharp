// csc /t:winexe MouseMoveDemo.cs

using System;
using System.Windows.Forms;
using System.Drawing;

namespace DemoWinForm
{
    static class App
    {
        static void Main()
        {
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "一个窗口";
            this.Height = 300;
            this.Width = 500;
            BackColor = Color.Green;
            Cursor = Cursors.Hand;

            this.MouseMove += new MouseEventHandler(MainForm_MouseMove);
        }

        void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = string.Format("当前鼠标坐标: [{0},{1}]",e.X,e.Y);
        }
    }
}
