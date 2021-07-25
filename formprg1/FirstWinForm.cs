// csc /t:winexe FirstWinForm.cs

using System;
using System.Windows.Forms;

namespace DemoWinForm
{
    class App : Form
    {
        static void Main()
        {
            Application.Run(new App());
        }
    }
}


/*
namespace DemoWinForm
{
    // 注意这里我用静态类
    static class App
    {
        static void Main()
        {
            Application.Run(new MainForm());
        }
    }
    
    public class MainForm : Form{}
}

*/