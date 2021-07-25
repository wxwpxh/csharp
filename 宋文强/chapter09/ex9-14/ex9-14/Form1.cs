using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//利用BinaryReader和BinaryWriter类的实例对灰度格式的位图文件进行加亮处理。
namespace ex9_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Dispose();					//清除图片框中原有内容
                FileStream fs = new FileStream(@"桔子.bmp", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);			//创建BinaryReader对象
                byte[] bmpfile = br.ReadBytes((int)fs.Length);	//读取整个图片文件到数组
                fs.Close();									//关闭输入流
                for (int i = 1078; i < bmpfile.Length; i++)		//前1078字节为文件结构
                {
                    if (bmpfile[i] <= 225)					//图像元素加亮校正
                        bmpfile[i] += 30;
                    else
                        bmpfile[i] = 255;						//每个像素的最高亮度为255
                }
                FileStream sw = new FileStream(@"加亮桔子.bmp", FileMode.Create);
                BinaryWriter bw = new BinaryWriter(sw);			//创建BinaryWriter对象
                bw.Write(bmpfile);							//把二进制流写入图片文件
                sw.Close();									//关闭输出流
                Bitmap bmp = new Bitmap(@"加亮桔子.bmp");
                pictureBox1.Image = bmp;						//显示加亮后的图片
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "文件错误",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"桔子.bmp");			//创建Bitmap类的实例
            pictureBox1.Image = bmp;							//指定的图片加载到图片框
        }
    }
}
