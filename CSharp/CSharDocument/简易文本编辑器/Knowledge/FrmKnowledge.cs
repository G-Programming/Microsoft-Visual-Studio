using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Knowledge
{
	/// <summary>
	/// FrmKnowledge 的摘要说明。
	/// </summary>
	public class FrmKnowledge : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox chkPrompt;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		private static string CurrentFolder;//当前文件夹
		private const string DataFileName=@"DataFile\PromptInfo.Dat";
		private const string InfoFileName=@"DataFile\adage.Txt";
		private System.Windows.Forms.Label labInfo; //存放阅读内容的文件
		private long ReadPosition=0;  //下次读数据的位置
		
		//静态构造函数
		static  FrmKnowledge()
		{
			CurrentFolder=Application.StartupPath;
			if(CurrentFolder[CurrentFolder.Length-1]!='\\')
				CurrentFolder+="\\";
			
		}
		public FrmKnowledge():this(0)
		{
		}
		public FrmKnowledge(long NextPosition)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//获得当前文件夹
			//CurrentFolder=Directory.GetCurrentDirectory();
			//if(CurrentFolder.Substring(CurrentFolder.Length-1,1)!="\\")
				//CurrentFolder+="\\";
			ReadPosition=NextPosition; //保存读位置
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmKnowledge));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.labInfo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.chkPrompt = new System.Windows.Forms.CheckBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.labInfo);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(272, 160);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "你知道吗?";
			// 
			// labInfo
			// 
			this.labInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.labInfo.ForeColor = System.Drawing.Color.Blue;
			this.labInfo.Location = new System.Drawing.Point(88, 8);
			this.labInfo.Name = "labInfo";
			this.labInfo.Size = new System.Drawing.Size(176, 144);
			this.labInfo.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 72);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 88);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// chkPrompt
			// 
			this.chkPrompt.Checked = true;
			this.chkPrompt.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPrompt.Location = new System.Drawing.Point(8, 192);
			this.chkPrompt.Name = "chkPrompt";
			this.chkPrompt.Size = new System.Drawing.Size(112, 24);
			this.chkPrompt.TabIndex = 1;
			this.chkPrompt.Text = "下次启动时提示";
			this.chkPrompt.CheckedChanged += new System.EventHandler(this.chkPrompt_CheckedChanged);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(176, 184);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(88, 32);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "下一提示";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(176, 232);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(88, 32);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "关闭";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// FrmKnowledge
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.chkPrompt);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FrmKnowledge";
			this.Text = "FrmKnowledge";
			this.Load += new System.EventHandler(this.FrmKnowledge_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			//写入数据到文件中
			bool IsPrompt=chkPrompt.Checked;
			WriteInfo(IsPrompt,ReadPosition);

		}

		private void FrmKnowledge_Load(object sender, System.EventArgs e)
		{
			string aLine=ReadNextLine(); //获取一行信息
			labInfo.Text=aLine;
		}
		public static  bool GetStatus(out long Position)
		{
			//用二进制流读数据可以正确得到流的当前位置！
			string FileName;
			//string CurFolder=Directory.GetCurrentDirectory();
			//if(CurFolder.Substring(CurFolder.Length-1,1)!="\\")
				//CurFolder+="\\";

			FileName=CurrentFolder+DataFileName;
			//MessageBox.Show(FileName);
			bool IsPrompt=true; //是否显示提示
			long NextPosition=0; //下一次读取位置
			FileStream fs;
			if(File.Exists(FileName)==true) //存在,读取内容
			{	
				fs=new FileStream(FileName,FileMode.Open,FileAccess.Read);
				BinaryReader r=new BinaryReader(fs);
				IsPrompt=r.ReadBoolean(); //读取是否需要提示
				NextPosition=r.ReadInt64(); //读取位置
				

				r.Close();
				fs.Close();
			}
			
			Position=NextPosition;
			return IsPrompt;
		}
		//将文件当前位置，下一次运行是否显示"小知识学习窗口"等数据写入数据文件
		private void WriteInfo(bool IsPrompt,long NextPosition)
		{
			string FileName=CurrentFolder+DataFileName; //获得数据文件
			FileStream fs=new FileStream(FileName,FileMode.Create,FileAccess.Write);
			BinaryWriter w=new BinaryWriter(fs);
			w.Write(IsPrompt);
			w.Write(NextPosition);
			
			w.Close();

		}
		//从文本文件当前位置读一行信息并返回
		private string  ReadNextLine()
		{
			//由于FileStream不支持文本文件的Position属性，
			//所以不能用Position属性正确获得文本文件流的当前位置!!
			//只能另寻它路了!
			string FileName=CurrentFolder+InfoFileName;
			FileStream fs=new FileStream(FileName,FileMode.Open,FileAccess.Read);

			StreamReader sr=new StreamReader(fs,System.Text.Encoding.Default);
			//定位文件流位置，准备读取
			fs.Seek(ReadPosition,SeekOrigin.Begin); 

			string sLine=sr.ReadLine(); //读一行字符串
			//获得所读字符串所占的字节数
			int byteLength=System.Text.Encoding.Default.GetByteCount(sLine);

			ReadPosition+=byteLength+2;// 2 表示跳过回车符和换行符(\r\n)共两个字节
			if(sr.ReadLine()==null) //文件已读完
				ReadPosition=0;//回到文件开头	
			sr.Close();
			fs.Close();
			return sLine; //返回所读信息
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			labInfo.Text=ReadNextLine(); //读取一行并显示
		}

		private void chkPrompt_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
