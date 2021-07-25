using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*将预先准备好的一组图片加载到ImageList组件的Images集合。快速连续单击“动画效果”按钮，
 将ImageList中存储的图片依次取出到图片框中显示，并且使之周而复始地循环*/
namespace ex7_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;					//将按钮单击事件过程重复执行时引用的变量定义在过程的前面
        private void Form1_Load(object sender, EventArgs e)
        {
            string imagefile;								//用来表示图片文件名的字符串变量
            imageList1.ImageSize = new Size(256, 210);			//规定载入图片的显示尺寸
            for (int k = 1; k <= 12; k++)					//将12张图片依次载入ImageList
            {
                if (k < 10)								//凑成图片文件名runboy01 ~ runboy12
                    imagefile = "runboy0" + k.ToString() + ".gif";
                else
                    imagefile = "runboy" + k.ToString() + ".gif";
                imageList1.Images.Add(Image.FromFile(imagefile));//加载图片到ImageList
            }
            pictureBox1.Image = imageList1.Images[0];			//图片框中显示ImageList的首张图片
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;	//根据图片尺寸自动调整图片框大小
        }
        private void button1_Click(object sender, EventArgs e)	//动画效果
        {
            pictureBox1.Image = imageList1.Images[i];	//在图片框中显示ImageList存储的第i张图片
            i++;									//调整指针，指向下一张图片
            if (i >= imageList1.Images.Count) i = 0;	//如果最后一张图片已显示，重新指向开头的图片
        }
        private void button2_Click(object sender, EventArgs e)	//结束程序
        {
            this.Close();
        }

    }
}
