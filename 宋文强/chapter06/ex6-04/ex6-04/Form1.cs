using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
 表6-2 学生成绩表
姓  名	语文	数学	外语	物理	化学
李晓强	70	85	92	74	62
何萍萍	92	79	95	68	75
郭晓薇	93	82	89	76	90
张  超	79	62	44	92	56
艾小兰	61	77	91	57	72
周世平	81	74	68	79	91
何  伟	83	90	86	85	82
*/
//将表6-2中的学生成绩数据预先保存到二维数组score中，把学生姓名预先保存到一维数组student中，并且在窗体上显示成7行×5列
/*
 分析：表5-2中列出了7位学生5门课程的成绩数据，因而可以按如下的方法定义一个具有7行×5列的二维数组score，用来表示这些数据：
float[,] score = new float[7,5];
这样，数组score的第一个下标用来表示行号，第二个下标用来表示列号，两者共同确定一个元素，即某个学生的某门课程成绩
*/
namespace ex6_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string[] student = { "李晓强", "何萍萍", "郭晓薇", "张  超", "艾小兰", "周世平", "何  伟" };
            float[,] score ={{70,85,92,74,62},
                     {92,79,95,68,75},
                     {93,83,89,76,90},
                     {79,62,44,92,56},
                     {61,77,91,57,72},
                     {81,74,68,79,91},
                     {83,90,86,85,82}};		//这种写法只是为了便于读者看清数据的行、列
            label1.Text += "姓 名     语文 数学 外语 物理 化学" + "\n";
            for (int i = 0; i < 7; i++)
            {
                label1.Text += student[i] + "    ";     	//显示一个学生的姓名
                for (int j = 0; j < 5; j++)                	//在同一行上显示一个学生的各科成绩
                {
                    label1.Text += score[i, j] + "    ";
                }
                label1.Text += "\n";                  	//换行转义符“\n”
            }

        }
    }
}
