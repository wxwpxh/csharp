using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace useProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessDemo pd = new ProcessDemo();
            pd.StartProcess(3);
            pd.ExitProcess();
        }
    }
}
