using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 例8._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected string OverPath = "";//上级目录字符串
        protected void SearchFolderInfo(string path)
        {//实现显示文件夹信息
            DirectoryInfo di = new DirectoryInfo(path );
            if (!di.Exists)
            {
                MessageBox.Show("文件" + di + "没有找到！");
            }
            //清除文件详细信息、文件夹、文件列表的所有内容
            Folder.Items.Clear();
            Files.Items.Clear();
            FileSize.Text = "";
            CreationTime.Text = "";
            LastAccessTime.Text = "";
            LastModifyTime.Text = "";
            OverPath = di.FullName;
            //添加文件夹列表的内容
            foreach (DirectoryInfo dir in di.GetDirectories())
                Folder.Items.Add(dir);
            //添加文件列表的内容
            foreach (FileInfo  file in di.GetFiles ())
                Files.Items.Add(file); 
        }
        protected void SearchFileInfo(string path)
        {
            FileInfo fileInfo = new FileInfo(path );
            if (!fileInfo.Exists)
            {
                MessageBox.Show("文件" + fileInfo + "没有找到！");
            }
            else
            {
                FileFullName.Text = fileInfo.FullName.ToString();//文件的完整路径
                FileSize.Text = fileInfo.Length.ToString() + "字节";//文件的大小
                CreationTime.Text = fileInfo.CreationTime.ToString();//文件的创建时间
                LastModifyTime.Text = fileInfo.LastWriteTime.ToString();//最后修改时间
                LastAccessTime.Text = fileInfo.LastAccessTime.ToString();//最后访问时间
            }
 
        }
        private void Search_Click(object sender, EventArgs e)
        {//单击“搜索”按钮
            if (FileName.Text != "")
            {//文本框内容不为空时
                try
                {
                    string path = FileName.Text;//获得输入的文件名
                    DirectoryInfo FileFolder = new DirectoryInfo(path);
                    if (FileFolder.Exists)
                    {//如果输入的文件名是目录
                        SearchFolderInfo(FileFolder.FullName);//搜索该目录下的所有文件夹
                        return;
                    }
                    FileInfo File = new FileInfo(path);
                    if (File.Exists)
                    {
                        SearchFileInfo(File.Directory .FullName);
                        int count = Files.Items.IndexOf(File.Name);
                        Files.SetSelected(count, true);
                        return;
                    }
                    throw new FileNotFoundException("未找到文件" + FileName.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("文件路径必须输入！");
                FileName.Focus();//将焦点移动到文件名文本框上
            }    


        }

        private void Folder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //获取文件夹列表框中选中的内容
                string selectedRow = Folder.SelectedItem.ToString();
                //将上级目录和当前文件名连接
                string fileFullName = Path.Combine(OverPath ,selectedRow );
                SearchFolderInfo(fileFullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );                
            }
        }

        private void Files_SelectedIndexChanged(object sender, EventArgs e)
        {//单击所有文件列表
            try
            {
                string selectedFileRow = Files.SelectedItem.ToString();
                string folderFullName = Path.Combine(OverPath, selectedFileRow);
                SearchFileInfo(folderFullName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message );
            }

        }
        
      

       
    }
}
