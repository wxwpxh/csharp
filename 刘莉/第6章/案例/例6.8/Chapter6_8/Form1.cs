using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter6_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           
        private void toolStripButton1_Click(object sender, EventArgs e)
        {//“保存” 对话框  
            //设置文件的保存类型
            saveFileDialog1.Filter = "Word文件(*.doc)|*.doc|所有文件(*.*)|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();
            string folderPath;
            //判读在打开文件对话框中是否单击了“打开”按钮
            if (dr == DialogResult.OK)
            {
                folderPath = saveFileDialog1.FileName;
                textBox2.Text = folderPath;
                MessageBox.Show("文件保存成功","保存文件",MessageBoxButtons .OK );
            }
            else
                textBox2.Text = "未保存文件";
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {//“打开”文件
            openFileDialog1 .InitialDirectory =@"d:\program";//设置初始目录
            openFileDialog1.Title = "打开Word文件";//打开文件对话框的标题
            openFileDialog1.FileName = "new";
            //设置当前文件名筛选器字符串
            openFileDialog1.Filter = "Word文件(*.doc)|*.doc|所有文件(*.*)|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();//显示打开文件对话框            
            string folderPath;
            if (dr == DialogResult.OK)
            {
                folderPath = openFileDialog1.FileName;//获取打开文件的文件名
                textBox1.Text = folderPath;//将文件名显示在textBox1文本框中
            }
            else
            {
                MessageBox.Show("未选择任何文件，请重新选择","警告信息",MessageBoxButtons .OKCancel,MessageBoxIcon.Warning );
                textBox1.Text = "未选择文件";
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {//“字体”对话框
            //设置对话框包含“应用”按钮
            fontDialog1.ShowApply = true;   
            //显示字体对话框
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {//“颜色”
            DialogResult dr = colorDialog1.ShowDialog();           
            if (dr == DialogResult.OK)
            {
                //通过颜色对话框设置textBox2的背景颜色
                textBox2.BackColor = colorDialog1.Color;
            }
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {//"打印"
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                printDialog1.PrintToFile = true;
            }
        }

      
       
    }
}
