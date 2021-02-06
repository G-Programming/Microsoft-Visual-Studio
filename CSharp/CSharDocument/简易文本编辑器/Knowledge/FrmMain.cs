using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Knowledge
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox txtEditor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnCut;
		private System.Windows.Forms.Button btnPaste;
		private System.Windows.Forms.Button btnSelAll;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox chkStrikeout;
		private System.Windows.Forms.CheckBox chkUnderline;
		private System.Windows.Forms.CheckBox chkItalic;
		private System.Windows.Forms.CheckBox chkBold;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnSaveAs;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnFont;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.CheckBox chkWordwrap;
		private System.Windows.Forms.Button btnVersion;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btnLearn;
		private System.Windows.Forms.Timer timer1;
		
		private string FileName="";
		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLearn = new System.Windows.Forms.Button();
			this.btnVersion = new System.Windows.Forms.Button();
			this.chkWordwrap = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnFont = new System.Windows.Forms.Button();
			this.btnColor = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chkStrikeout = new System.Windows.Forms.CheckBox();
			this.chkUnderline = new System.Windows.Forms.CheckBox();
			this.chkItalic = new System.Windows.Forms.CheckBox();
			this.chkBold = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnSelAll = new System.Windows.Forms.Button();
			this.btnPaste = new System.Windows.Forms.Button();
			this.btnCut = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSaveAs = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.txtEditor = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLearn);
			this.panel1.Controls.Add(this.btnVersion);
			this.panel1.Controls.Add(this.chkWordwrap);
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 72);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnLearn
			// 
			this.btnLearn.Image = ((System.Drawing.Image)(resources.GetObject("btnLearn.Image")));
			this.btnLearn.Location = new System.Drawing.Point(760, 16);
			this.btnLearn.Name = "btnLearn";
			this.btnLearn.Size = new System.Drawing.Size(24, 24);
			this.btnLearn.TabIndex = 18;
			this.toolTip1.SetToolTip(this.btnLearn, "小知识");
			this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
			// 
			// btnVersion
			// 
			this.btnVersion.Image = ((System.Drawing.Image)(resources.GetObject("btnVersion.Image")));
			this.btnVersion.Location = new System.Drawing.Point(720, 16);
			this.btnVersion.Name = "btnVersion";
			this.btnVersion.Size = new System.Drawing.Size(24, 24);
			this.btnVersion.TabIndex = 17;
			this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
			// 
			// chkWordwrap
			// 
			this.chkWordwrap.Location = new System.Drawing.Point(664, 16);
			this.chkWordwrap.Name = "chkWordwrap";
			this.chkWordwrap.Size = new System.Drawing.Size(48, 24);
			this.chkWordwrap.TabIndex = 16;
			this.chkWordwrap.Text = "折行";
			this.chkWordwrap.CheckedChanged += new System.EventHandler(this.chkWordwrap_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnFont);
			this.groupBox4.Controls.Add(this.btnColor);
			this.groupBox4.Location = new System.Drawing.Point(560, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(88, 48);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "字体和颜色";
			// 
			// btnFont
			// 
			this.btnFont.Image = ((System.Drawing.Image)(resources.GetObject("btnFont.Image")));
			this.btnFont.Location = new System.Drawing.Point(40, 16);
			this.btnFont.Name = "btnFont";
			this.btnFont.Size = new System.Drawing.Size(32, 24);
			this.btnFont.TabIndex = 8;
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click_1);
			// 
			// btnColor
			// 
			this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
			this.btnColor.Location = new System.Drawing.Point(8, 16);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(24, 24);
			this.btnColor.TabIndex = 7;
			this.toolTip1.SetToolTip(this.btnColor, "设置文本颜色");
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chkStrikeout);
			this.groupBox3.Controls.Add(this.chkUnderline);
			this.groupBox3.Controls.Add(this.chkItalic);
			this.groupBox3.Controls.Add(this.chkBold);
			this.groupBox3.Location = new System.Drawing.Point(288, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(264, 48);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "字体风格";
			// 
			// chkStrikeout
			// 
			this.chkStrikeout.Location = new System.Drawing.Point(200, 24);
			this.chkStrikeout.Name = "chkStrikeout";
			this.chkStrikeout.Size = new System.Drawing.Size(64, 16);
			this.chkStrikeout.TabIndex = 15;
			this.chkStrikeout.Text = "删除线";
			this.chkStrikeout.CheckedChanged += new System.EventHandler(this.chStrikeout_CheckedChanged);
			// 
			// chkUnderline
			// 
			this.chkUnderline.Location = new System.Drawing.Point(128, 24);
			this.chkUnderline.Name = "chkUnderline";
			this.chkUnderline.Size = new System.Drawing.Size(64, 16);
			this.chkUnderline.TabIndex = 14;
			this.chkUnderline.Text = "下划线";
			this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
			// 
			// chkItalic
			// 
			this.chkItalic.Location = new System.Drawing.Point(72, 24);
			this.chkItalic.Name = "chkItalic";
			this.chkItalic.Size = new System.Drawing.Size(48, 16);
			this.chkItalic.TabIndex = 13;
			this.chkItalic.Text = "斜体";
			this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
			// 
			// chkBold
			// 
			this.chkBold.Location = new System.Drawing.Point(16, 24);
			this.chkBold.Name = "chkBold";
			this.chkBold.Size = new System.Drawing.Size(48, 16);
			this.chkBold.TabIndex = 12;
			this.chkBold.Text = "粗体";
			this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnSelAll);
			this.groupBox2.Controls.Add(this.btnPaste);
			this.groupBox2.Controls.Add(this.btnCut);
			this.groupBox2.Controls.Add(this.btnCopy);
			this.groupBox2.Location = new System.Drawing.Point(128, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(152, 48);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "编辑";
			// 
			// btnSelAll
			// 
			this.btnSelAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSelAll.Image")));
			this.btnSelAll.Location = new System.Drawing.Point(112, 16);
			this.btnSelAll.Name = "btnSelAll";
			this.btnSelAll.Size = new System.Drawing.Size(24, 24);
			this.btnSelAll.TabIndex = 9;
			this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
			// 
			// btnPaste
			// 
			this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
			this.btnPaste.Location = new System.Drawing.Point(72, 16);
			this.btnPaste.Name = "btnPaste";
			this.btnPaste.Size = new System.Drawing.Size(32, 24);
			this.btnPaste.TabIndex = 8;
			this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
			// 
			// btnCut
			// 
			this.btnCut.Image = ((System.Drawing.Image)(resources.GetObject("btnCut.Image")));
			this.btnCut.Location = new System.Drawing.Point(40, 16);
			this.btnCut.Name = "btnCut";
			this.btnCut.Size = new System.Drawing.Size(24, 24);
			this.btnCut.TabIndex = 7;
			this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
			this.btnCopy.Location = new System.Drawing.Point(8, 16);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(24, 24);
			this.btnCopy.TabIndex = 6;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSaveAs);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnOpen);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(112, 48);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "文件操作";
			// 
			// btnSaveAs
			// 
			this.btnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Image")));
			this.btnSaveAs.Location = new System.Drawing.Point(72, 16);
			this.btnSaveAs.Name = "btnSaveAs";
			this.btnSaveAs.Size = new System.Drawing.Size(24, 24);
			this.btnSaveAs.TabIndex = 3;
			this.toolTip1.SetToolTip(this.btnSaveAs, "文件另存为");
			this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.Location = new System.Drawing.Point(40, 16);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(24, 24);
			this.btnSave.TabIndex = 2;
			this.toolTip1.SetToolTip(this.btnSave, "保存");
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
			this.btnOpen.Location = new System.Drawing.Point(8, 16);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(24, 24);
			this.btnOpen.TabIndex = 1;
			this.toolTip1.SetToolTip(this.btnOpen, "文件打开");
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// txtEditor
			// 
			this.txtEditor.AcceptsReturn = true;
			this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtEditor.Location = new System.Drawing.Point(0, 72);
			this.txtEditor.Multiline = true;
			this.txtEditor.Name = "txtEditor";
			this.txtEditor.Size = new System.Drawing.Size(800, 262);
			this.txtEditor.TabIndex = 1;
			this.txtEditor.Text = "textBox1";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(800, 334);
			this.Controls.Add(this.txtEditor);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "简易文本编辑器";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			toolTip1.SetToolTip(btnCopy,"复制");
			toolTip1.SetToolTip(btnCut,"剪切");
			toolTip1.SetToolTip(btnPaste,"粘贴");
			toolTip1.SetToolTip(btnSelAll,"全选");
			toolTip1.SetToolTip(btnVersion,"版本信息");
			txtEditor.WordWrap=false;

			long Position;
			if(FrmKnowledge.GetStatus(out Position)==true)
			{
				FrmKnowledge fd=new FrmKnowledge(Position);
				fd.ShowDialog();
				fd.Dispose(); //释放资源
			}

		}

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog of=new OpenFileDialog();
			of.Filter="文本文件|*.txt;*.Sys;*.bat";
			if(of.ShowDialog()==DialogResult.OK)
			{
				ReadFileContent(of.FileName);
				FileName=of.FileName; //保存文件名
			}

		}
		private void ReadFileContent(string FileName)
		{
			StreamReader sr=new StreamReader(FileName,System.Text.Encoding.Default);
			txtEditor.Text=sr.ReadToEnd();
			sr.Close();
			txtEditor.Modified=false; //没有被修改
		}

		private void btnColor_Click(object sender, System.EventArgs e)
		{
			ColorDialog cc=new ColorDialog();
			if(cc.ShowDialog()==DialogResult.OK)
			{
				txtEditor.ForeColor=cc.Color;
			}
		}

		private void btnCut_Click(object sender, System.EventArgs e)
		{
			txtEditor.Cut();
		}

		private void btnCopy_Click(object sender, System.EventArgs e)
		{
			txtEditor.Copy();
		}

		private void btnPaste_Click(object sender, System.EventArgs e)
		{
			txtEditor.Paste();
		}

		private void btnFont_Click(object sender, System.EventArgs e)
		{
			FontDialog fd=new FontDialog();
			if(fd.ShowDialog()==DialogResult.OK)
			{
				txtEditor.Font=fd.Font;
			}
		}

		private void btnSelAll_Click(object sender, System.EventArgs e)
		{
			//txtEditor.SelectionStart=0;
			//txtEditor.SelectionLength=txtEditor.Text.Length;
			txtEditor.SelectAll();
			txtEditor.Focus();

			//MessageBox.Show(FontBold.ToString());
		}

		private void chkBold_CheckedChanged(object sender, System.EventArgs e)
		{
			FontBold=chkBold.Checked;
		}



		private void chkItalic_CheckedChanged(object sender, System.EventArgs e)
		{
			FontItalic=chkItalic.Checked;
		}

		private void chkUnderline_CheckedChanged(object sender, System.EventArgs e)
		{
			FontUnderline=chkUnderline.Checked;
		}

		private void chStrikeout_CheckedChanged(object sender, System.EventArgs e)
		{
			FontStrikeout=chkStrikeout.Checked;
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void btnColor_Click_1(object sender, System.EventArgs e)
		{
			ColorDialog cc=new ColorDialog();
			if(cc.ShowDialog()==DialogResult.OK)
			{
				txtEditor.ForeColor=cc.Color;
			}
		}

		private void btnFont_Click_1(object sender, System.EventArgs e)
		{
			FontDialog fd=new FontDialog();
			if(fd.ShowDialog()==DialogResult.OK)
			{
				txtEditor.Font=fd.Font;
			}
			
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			
		}

		private void chkWordwrap_CheckedChanged(object sender, System.EventArgs e)
		{
			txtEditor.WordWrap=chkWordwrap.Checked;
		}

		private void btnVersion_Click(object sender, System.EventArgs e)
		{
			FrmVersion Version=new FrmVersion();
			Version.ShowDialog();
		}
		//保存文件
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			SaveText();
			

		}
		private void SaveText()
		{

			StreamWriter sw=new StreamWriter(FileName,false,System.Text.Encoding.Default);
			sw.Write(txtEditor.Text);
			sw.Close();
			txtEditor.Modified=false; //没有修改

		}
		private void btnLearn_Click(object sender, System.EventArgs e)
		{
			long Position;
			bool bPrompt=FrmKnowledge.GetStatus(out Position);
			//强制显示小知识
			FrmKnowledge fd=new FrmKnowledge(Position);
			fd.ShowDialog(this);
			fd.Dispose(); //释放资源
					
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(txtEditor.Modified) //已被修改
			{
				DialogResult dr=MessageBox.Show("数据已改变,要保存吗? ","提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
				if(dr==DialogResult.Cancel)
				{
					e.Cancel=true;
					return;
				}
				else if(dr==DialogResult.Yes) //保存内容
					SaveText();
				


			}
		}
		//获取或设置编辑器字体Bold
		protected bool FontBold
		{
			
			get
			{
				return (txtEditor.Font.Style & FontStyle.Bold)==FontStyle.Bold;
			}
			set
			{
				Font NewFont;
				Font OldFont=txtEditor.Font;
				if(value==true)
					NewFont=new Font(OldFont.Name,OldFont.Size,OldFont.Style | FontStyle.Bold);
				else
					NewFont=new Font(OldFont.Name,OldFont.Size,OldFont.Style & (~FontStyle.Bold));
				txtEditor.Font=NewFont;
			}

		}
		//获取或设置编辑器字体Italic
		protected bool FontItalic
		{
			
			get
			{
				return (txtEditor.Font.Style & FontStyle.Bold)==FontStyle.Italic;
			}
			set
			{
				Font NewFont;
				Font OldFont=txtEditor.Font;
				if(value==true)
					NewFont=new Font(OldFont.Name,OldFont.Size,OldFont.Style | FontStyle.Italic);
				else
					NewFont=new Font(OldFont.Name,OldFont.Size,OldFont.Style & (~FontStyle.Italic));
				txtEditor.Font=NewFont;
			}

		}
		//获取或设置编辑器字体Underline
		protected bool FontUnderline
		{
			
			get
			{
				return (txtEditor.Font.Style & FontStyle.Bold)==FontStyle.Underline;
			}
			set
			{
				Font NewFont;
				Font OldFont=txtEditor.Font;
				if(value==true)
					NewFont=new Font(OldFont.Name,OldFont.Size,OldFont.Style | FontStyle.Underline);
				else
					NewFont=new Font(OldFont.Name,OldFont.Size,OldFont.Style & (~FontStyle.Underline));
				txtEditor.Font=NewFont;
			}

		}
		//获取或设置编辑器字体StrikeOut
		protected bool FontStrikeout
		{
			
			get
			{
				return (txtEditor.Font.Style & FontStyle.Bold)==FontStyle.Strikeout;
			}
			set
			{
				Font NewFont;
				Font OldFont=txtEditor.Font;
				if(value==true)
					NewFont=new Font(OldFont.Name,OldFont.Size,OldFont.Style | FontStyle.Strikeout);
				else
					NewFont=new Font(OldFont.Name,OldFont.Size,OldFont.Style & (~FontStyle.Strikeout));
				txtEditor.Font=NewFont;
			}

		}
		


		private void timer1_Tick(object sender, System.EventArgs e)
		{
			const string sCaption="简易文本编辑器";
			string Space=new string(' ',5);
			this.Text=sCaption+Space+"北京时间 "+DateTime.Now.ToLongTimeString();//在标题栏显示系统时间
			btnCut.Enabled=txtEditor.SelectionLength!=0;
			btnCopy.Enabled=txtEditor.SelectionLength!=0;
		
		}

		private void btnSaveAs_Click(object sender, System.EventArgs e)
		{
		
		}


	}
}
