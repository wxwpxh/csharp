using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace usePictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 打开图像
        private void button1_Click(object sender, EventArgs e)
        {
            // 创建“打开文件”对话框
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // 设置打开文件的类型
            openFileDialog1.Filter = "所有合适文件(*.bmp/*.jpg/*.gif)|" +
                "*.*|Bitmap文件(*.bmp)|*.bmp|Jpeg文件(*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;        // 设置对话框中筛选器的索引
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }

        // 保存图像
        private void button2_Click(object sender, EventArgs e)
        {
            string str;
            Bitmap box1 = new Bitmap(pictureBox1.Image);       // 创建Bitmap对象
            // 创建“另存为”对话框
            SaveFileDialog savaFileDialog1 = new SaveFileDialog();
            savaFileDialog1.Filter = "所有合适文件(*.bmp/*.jpg/*.gif)|" +
                "*.*|Bitmap文件(*.bmp)|*.bmp|Jpeg文件(*.jpg)|*.jpg";
            savaFileDialog1.ShowDialog();
            str = savaFileDialog1.FileName;
            box1.Save(str);         // 将pictureBox1中的图像保存到指定位置
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str;
            System.Drawing.Imaging.ImageFormat ext;
            Bitmap box1 = new Bitmap(pictureBox1.Image);       // 创建Bitmap对象
            // 创建“另存为”对话框
            SaveFileDialog savaFileDialog1 = new SaveFileDialog();
            savaFileDialog1.Filter = "所有合适文件(*.bmp/*.jpg/*.gif)|" +
                "*.*|Bitmap文件(*.bmp)|*.bmp|Jpeg文件(*.jpg)|*.jpg";
            savaFileDialog1.ShowDialog();
            str = savaFileDialog1.FileName;
           // ext = (System.Drawing.Imaging.ImageFormat)("System.Drawing.Imaging.ImageFormat." + comboBox1.SelectedItem.ToString());
            box1.Save(str, System.Drawing.Imaging.ImageFormat.Gif );         // 将pictureBox1中的图像保存到指定位置
        }
    }
}
