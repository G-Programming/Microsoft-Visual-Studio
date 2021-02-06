using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Knowledge
{
	/// <summary>
	/// FrmKnowledge ��ժҪ˵����
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
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		private static string CurrentFolder;//��ǰ�ļ���
		private const string DataFileName=@"DataFile\PromptInfo.Dat";
		private const string InfoFileName=@"DataFile\adage.Txt";
		private System.Windows.Forms.Label labInfo; //����Ķ����ݵ��ļ�
		private long ReadPosition=0;  //�´ζ����ݵ�λ��
		
		//��̬���캯��
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
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//��õ�ǰ�ļ���
			//CurrentFolder=Directory.GetCurrentDirectory();
			//if(CurrentFolder.Substring(CurrentFolder.Length-1,1)!="\\")
				//CurrentFolder+="\\";
			ReadPosition=NextPosition; //�����λ��
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.label2.Text = "��֪����?";
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
			this.chkPrompt.Text = "�´�����ʱ��ʾ";
			this.chkPrompt.CheckedChanged += new System.EventHandler(this.chkPrompt_CheckedChanged);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(176, 184);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(88, 32);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "��һ��ʾ";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(176, 232);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(88, 32);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "�ر�";
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
			//д�����ݵ��ļ���
			bool IsPrompt=chkPrompt.Checked;
			WriteInfo(IsPrompt,ReadPosition);

		}

		private void FrmKnowledge_Load(object sender, System.EventArgs e)
		{
			string aLine=ReadNextLine(); //��ȡһ����Ϣ
			labInfo.Text=aLine;
		}
		public static  bool GetStatus(out long Position)
		{
			//�ö������������ݿ�����ȷ�õ����ĵ�ǰλ�ã�
			string FileName;
			//string CurFolder=Directory.GetCurrentDirectory();
			//if(CurFolder.Substring(CurFolder.Length-1,1)!="\\")
				//CurFolder+="\\";

			FileName=CurrentFolder+DataFileName;
			//MessageBox.Show(FileName);
			bool IsPrompt=true; //�Ƿ���ʾ��ʾ
			long NextPosition=0; //��һ�ζ�ȡλ��
			FileStream fs;
			if(File.Exists(FileName)==true) //����,��ȡ����
			{	
				fs=new FileStream(FileName,FileMode.Open,FileAccess.Read);
				BinaryReader r=new BinaryReader(fs);
				IsPrompt=r.ReadBoolean(); //��ȡ�Ƿ���Ҫ��ʾ
				NextPosition=r.ReadInt64(); //��ȡλ��
				

				r.Close();
				fs.Close();
			}
			
			Position=NextPosition;
			return IsPrompt;
		}
		//���ļ���ǰλ�ã���һ�������Ƿ���ʾ"С֪ʶѧϰ����"������д�������ļ�
		private void WriteInfo(bool IsPrompt,long NextPosition)
		{
			string FileName=CurrentFolder+DataFileName; //��������ļ�
			FileStream fs=new FileStream(FileName,FileMode.Create,FileAccess.Write);
			BinaryWriter w=new BinaryWriter(fs);
			w.Write(IsPrompt);
			w.Write(NextPosition);
			
			w.Close();

		}
		//���ı��ļ���ǰλ�ö�һ����Ϣ������
		private string  ReadNextLine()
		{
			//����FileStream��֧���ı��ļ���Position���ԣ�
			//���Բ�����Position������ȷ����ı��ļ����ĵ�ǰλ��!!
			//ֻ����Ѱ��·��!
			string FileName=CurrentFolder+InfoFileName;
			FileStream fs=new FileStream(FileName,FileMode.Open,FileAccess.Read);

			StreamReader sr=new StreamReader(fs,System.Text.Encoding.Default);
			//��λ�ļ���λ�ã�׼����ȡ
			fs.Seek(ReadPosition,SeekOrigin.Begin); 

			string sLine=sr.ReadLine(); //��һ���ַ���
			//��������ַ�����ռ���ֽ���
			int byteLength=System.Text.Encoding.Default.GetByteCount(sLine);

			ReadPosition+=byteLength+2;// 2 ��ʾ�����س����ͻ��з�(\r\n)�������ֽ�
			if(sr.ReadLine()==null) //�ļ��Ѷ���
				ReadPosition=0;//�ص��ļ���ͷ	
			sr.Close();
			fs.Close();
			return sLine; //����������Ϣ
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			labInfo.Text=ReadNextLine(); //��ȡһ�в���ʾ
		}

		private void chkPrompt_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
