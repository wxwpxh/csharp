// csc /t:winexe secondWinForm.cs
using System ;
using System.Windows.Forms ;
using System.Drawing ;
public class Form2 : Form
{	
	public static void Main( ){
	  Application.Run(new Form2());
	}
	public Form2( ){
	  this.Location = new System.Drawing.Point( 100 , 100 ) ;
	  this.Cursor = System.Windows.Forms.Cursors.Hand;
	  // 定义在窗体上，光标显示为手形
	  this.Text = "透明的WinForm窗体！";
	  // 定义窗体的标题名称
	  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	  // 定义窗体的开始显示位置是屏幕的中间
	  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
	  // 窗体的边界是Fixed3D类型
	  this.ForeColor = System.Drawing.SystemColors.Desktop;
	  //以桌面的前景色作为窗体的前景色
	  this.Font = new System.Drawing.Font ( "宋体", 9 ) ;
	  // 定义字体类型，大小
	  this.BackColor = System.Drawing.Color.Blue;
	  // 定义背景色为蓝色
	  this.ClientSize = new System.Drawing.Size( 440 , 170 ) ;
	  // 设置窗体的大小
	  // Opacity属性设立窗体的透明程度，只对于视窗2000有效
	  this.Opacity = 0.60 ;
  }

  
	/*	

	private Label label1 ;
	
	public Form3(){
	  // 建立标签并且初始化
	  this.label1 = new System.Windows.Forms.Label( ) ;
	  //先继承一个Label 类
	  label1.Location = new System.Drawing.Point( 24 , 16 ) ;
	  //设定 Label的显示位置
	  label1.Text = "这是一个WinForm中的标签";
	  label1.Size = new System.Drawing.Size ( 200, 50 );
	  //设定标签的大小
	  label1.TabIndex = 0 ;
	  label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	  // 设定标签的对齐方式
	  this.Text = "在WinForm中加入一个标签！";
	  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
	} 
	*/	
	
}