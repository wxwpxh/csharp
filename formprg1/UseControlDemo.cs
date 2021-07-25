// csc /t:winexe UseControlDemo.cs

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
            Text = "一个窗口";
            Height = 300;
            Width = 500;
            BackColor = Color.Green;
            Cursor = Cursors.Hand;
        }
    }
}