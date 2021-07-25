using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 启动一个Windows绘图进程
        private void button1_Click(object sender, EventArgs e)
        {
            paintProcess.Start();
        }
        // 关闭全部已启动的Windows绘图进程
        private void button2_Click(object sender, EventArgs e)
        {
            // 创建一个Process组件的数组 
            // 将所建数组与指定进程名(mspaint)的所有进程资源相关联
            Process[] msPaintProcess= Process.GetProcessesByName("mspaint");
            // 遍历当前启动程序，查找包含指定名称的进程
            foreach (Process p in msPaintProcess)
            { 
                // 终止当前进程，关闭应用程序窗体
                p.CloseMainWindow();
            }
        }
    }
}
