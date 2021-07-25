using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UseToolTip
{
    public partial class RichTextBox的使用 : Form
    {
        public RichTextBox的使用()
        {
            InitializeComponent();
        }
        string path = ".\test1.rtf";//保存文件的路径
        //加载窗体时，如果程序中存在RTF文件，那么就直接显示在RichTextBox控件中
        private void Form1_Load(object sender, EventArgs e)
        {          
            //当在指定路径下存在该文件时
            if (File.Exists(path))
            {                
                //从指定的位置加载RTF文件
                this.richTextBox1.LoadFile(path,RichTextBoxStreamType.RichText);
                //设定“打开”按钮为不可用状态
                Open.Enabled = false;
            }            
            //设定“保存”按钮为不可用状态
            Save.Enabled = false;    
        }
        //当程序中不存在RTF文件时，单击“打开”按钮选定要打开的文件
        private void Open_Click(object sender, EventArgs e)
        {
            //声明一个用于打开文件对话框的对象
            OpenFileDialog TxTOpenDialog = new OpenFileDialog();
            //定义打开文件对话框的过滤参数
            TxTOpenDialog.Filter = "RTF文件(*.RTF)|*.RTF";
            //当在打开对话框中单击“打开”按钮时
            if (TxTOpenDialog.ShowDialog() == DialogResult.OK)       
            {
                //保存打开文件的路径
                path = TxTOpenDialog.FileName;         
                //从指定的位置加载RTF文件
                this.richTextBox1.LoadFile(TxTOpenDialog.FileName, RichTextBoxStreamType.RichText);
                //设置“保存”按钮为不可用状态
                Save.Enabled = false;
                //设置“打开”按钮为不可用状态
                Open.Enabled = false;          
                //弹出读取成功时的提示信息
                MessageBox.Show("读取成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //如果电脑中没有RTF文件，那么可以直接在RichTextBox控件中输入内容，然后单击“保存”按钮创建一个RTF文件
        private void Save_Click(object sender, EventArgs e)
        {
            //定义一个用于保存文件的保存对话框
            SaveFileDialog TxTSaveDialog = new SaveFileDialog();
            //设置保存文件的过滤参数
            TxTSaveDialog.Filter = "RTF文件（*.RTF）|*.RTF";
            //当在指定路径下存在该路径时
            if (File.Exists(path))                                    
            {
                //保存指定文件到指定位置
                this.richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);       
                //弹出保存成功的提示信息
                MessageBox.Show("保存成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.richTextBox1.Clear();     //清空RichTextBox控件中的所有内容
                Save.Enabled = false;             //设置“保存”按钮为不可用状态
            }
            else
            {
                if (TxTSaveDialog.ShowDialog() == DialogResult.OK)              //当在保存对话框中单击“保存”按钮时
                {
                    //保存文件到指定的位置
                    this.richTextBox1.SaveFile(TxTSaveDialog.FileName, RichTextBoxStreamType.RichText);
                    //弹出保存成功的提示信息
                    MessageBox.Show("保存成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.richTextBox1.Clear();     //清空RichTextBox控件中的所有内容
                    Save.Enabled = false;    //设定“保存”按钮为不可用状态
                }
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //设置保存按钮为可用状态
            Save.Enabled = true;  
            //当RichTextBox控件中的内容不存在或者为空值时
            if (this.richTextBox1.Text == "" || this.richTextBox1.Text == null)
            {
                //设置打开按钮为可用状态
                Open.Enabled = true;           
            }
        }
        //当单击左对齐按钮时，选定的文本就居左对齐
        private void justifyLeft_Click(object sender, EventArgs e)
        {
            //设置选定的文本为左对齐
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;   
        }

        private void justifyCenter_Click(object sender, EventArgs e)
        {
            //设置选定的文本为居中对齐
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center; 
        }
        //当单击右对齐按钮时，选定的文本就居右对齐
        private void justifyRight_Click(object sender, EventArgs e)
        {
            //设置选定的文本为右对齐
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right; 
        }


    }
}
