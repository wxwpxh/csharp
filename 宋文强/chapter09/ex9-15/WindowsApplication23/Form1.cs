using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
/*���һ��СͼƬ���������ͼ9-13��ʾ���û��������������ť�������FolderBrowserDialog��ShowDialog()�������Խ�����ʽ�ڱ���������ѡ��һ���ļ��У�
 ��ѡ�е��ļ�������ʾ���ı����У����ļ�����������ȫ���ļ����·����б������ʾ��
 �����б�����κ�һ��ѡ��������ͼƬ�ļ��������ұߵ�ͼƬ������ʾ���������ͼƬ�ļ���������Ϣ����ʾ���ļ����ʹ��󡱡�*/
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
                MessageBox.Show("�ļ����ʹ���");
            }
        }
    }
}