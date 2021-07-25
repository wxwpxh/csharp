using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*将预先准备好的一组图片加载到ImageList。单击“播放动画”按钮，
 就能自动地将ImageList中存储的图片依次取出到图片框中显示，并周而复始地循环，
 实现动画效果，此时按钮文字改为“暂停播放”。再次单击这个按钮，动画播放暂时停止。
 拖动窗体底部滚动条的滑块，可以调节图片切换的时间间隔，从而改变动画播放的速度。*/
namespace ex7_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Maximum = 300;						//动画播放的最慢速度
            hScrollBar1.Minimum = 30;						//动画播放的最快速度
            hScrollBar1.Value = 150; 						//动画画播放的初始速度
            hScrollBar1.Dock = DockStyle.Bottom;				//水平滚动条停靠在窗体底部
            hScrollBar1.RightToLeft = RightToLeft.Yes;			//右端对应Maximum，左端对应Minimum
            timer1.Interval = hScrollBar1.Value;
            timer1.Enabled = true;
            timer1.Stop();									//暂时停止播放
            string imagefile;
            imageList1.ImageSize = new Size(256, 210);			//规定载入图片的显示尺寸
            for (int k = 1; k <= 12; k++)					//逐张图片载入ImageList
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
        private void timer1_Tick(object sender, EventArgs e)		//定时播放图片
        {
            pictureBox1.Image = imageList1.Images[i];	//在图片框中显示ImageList存储的第i张图片
            i++;									//调整指针，指向下一张图片
            if (i >= imageList1.Images.Count) i = 0;	//如果最后一张图片已显示，重新指向开头的图片
        }
        private void button1_Click(object sender, EventArgs e)		//“播放动画”或“暂停播放”
        {
            if (button1.Text == "播放动画")
            {
                timer1.Start();
                button1.Text = "暂停播放";
            }
            else
            {
                timer1.Stop();
                button1.Text = "播放动画";
            }
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)//调节奔跑速度
        {
            timer1.Interval = hScrollBar1.Value;
        }
        private void button2_Click(object sender, EventArgs e)			//结束程序
        {
            this.Close();
        }

    }
}
