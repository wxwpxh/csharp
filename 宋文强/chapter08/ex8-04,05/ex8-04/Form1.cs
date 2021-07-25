using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
/*创建一个菜单驱动，运用对话框实现以交互方式创建、打开和保存文件，并能在状态栏显示状态信息的简单记事本程序
运用对话框实现以交互方式设置被选中文字的字体和颜色的简单记事本程序*/
namespace ex704
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "新建";
            DialogResult myresult = saveFileDialog1.ShowDialog();
            if (myresult == DialogResult.OK)            //测试用户是否执行了有效的新建操作
            {
                File.Create(@saveFileDialog1.FileName);//按从对话框获得的文件名创建新文件
                toolStatus2.Text = saveFileDialog1.FileName + "文件创建成功";
            }
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            DialogResult myresult = openFileDialog1.ShowDialog();//打开对话框并获取返回值
            if (myresult == DialogResult.OK)            //测试用户是否执行了有效的打开操作
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            DialogResult myresult = saveFileDialog1.ShowDialog();//打开对话框并获取返回值
            if (myresult == DialogResult.OK)    //测试用户是否执行了有效的保存操作
            {
                richTextBox1.SaveFile(@openFileDialog1.FileName);//按从对话框获得的文件名保存文件
                toolStatus2.Text = openFileDialog1.FileName + "文件保存成功";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";      //设置默认的初始打开文件名为空字符串
            openFileDialog1.InitialDirectory = @"F:\C#";//设置文件操作的初始目录
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt|RTF文件(*.rtf)|*.rtf|所有文件(*.*)|*.*";
            openFileDialog1.FilterIndex = 2;    //把筛选器中的第二项设置为默认值
            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|RTF文件(*.rtf)|*.rtf|所有文件(*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            toolStatus1.Text = "当前系统日期：" + DateTime.Now.ToShortDateString();//在状态栏显示当前日期
        }

        private void menuFormatFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;                       //允许显示“应用”按钮
            fontDialog1.ShowColor = true;                       //允许显示“颜色”选择下拉列表
            fontDialog1.ShowEffects = true;                     //允许显示删除线、下划线等效果选项
            fontDialog1.ShowDialog();                           //显示对话框，执行交互操作
            richTextBox1.SelectionFont = fontDialog1.Font;      //设置被选中文字的字体
        }

        private void menuFormatColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();                          //显示对话框，执行交互操作
            richTextBox1.SelectionColor = colorDialog1.Color;   //设置被选中文字的颜色
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
