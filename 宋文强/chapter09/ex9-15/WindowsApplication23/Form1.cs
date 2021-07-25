using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
/*设计一个小图片浏览器，如图9-13所示。用户单击“浏览”按钮，便调用FolderBrowserDialog的ShowDialog()方法，以交互方式在本机磁盘上选择一个文件夹，
 被选中的文件夹名显示在文本框中，该文件夹所包含的全部文件在下方的列表框中显示。
 单击列表框中任何一个选项，如果它是图片文件，则在右边的图片框中显示；如果不是图片文件，则用消息框显示“文件类型错误”。*/
namespace WindowsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                if (folderBrowserDialog1.SelectedPath.Trim() != "")
                    textBox1.Text = folderBrowserDialog1.SelectedPath.Trim();
            DirectoryInfo di = new DirectoryInfo(textBox1.Text);
            listBox1.Items.AddRange(di.GetFileSystemInfos());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string imgfile = textBox1.Text + "\\" + listBox1.SelectedItem.ToString();
                Bitmap bmp = new Bitmap(imgfile);
                pictureBox1.Image = bmp;
            }
            catch 
            {
                MessageBox.Show("文件类型错误");
            }
        }
    }
}