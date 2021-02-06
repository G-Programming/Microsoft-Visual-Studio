using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinForm6
{
	/// <summary>
	/// FrmArrayList 的摘要说明。
	/// </summary>
	public class FrmArrayList : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private ArrayList ManList=new ArrayList(10);

		public FrmArrayList()
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(8, 40);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 148);
			this.listBox1.TabIndex = 0;
			// 
			// listBox2
			// 
			this.listBox2.ItemHeight = 12;
			this.listBox2.Location = new System.Drawing.Point(144, 40);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(136, 148);
			this.listBox2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(48, 216);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "排序";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "排序前";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(144, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "排序后";
			// 
			// FrmArrayList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Name = "FrmArrayList";
			this.Text = "FrmArrayList";
			this.Load += new System.EventHandler(this.FrmArrayList_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			int Count=ManList.Count;
			for(int i=0;i<Count;i++)
			{
				listBox1.Items.Add(ManList[i]);
			}
			ManList.Sort();
			for(int i=0;i<Count;i++)
			{
				listBox2.Items.Add(ManList[i]);
			}

		}

		private void FrmArrayList_Load(object sender, System.EventArgs e)
		{
			ManInfo man;
			man=new ManInfo("江泽民",78);
			ManList.Add(man);

			man=new ManInfo("胡锦涛",60);
			ManList.Add(man);
			man=new ManInfo("王文",88);
			ManList.Add(man);
			man=new ManInfo("邓小平",100);
			ManList.Add(man);

		}
	
		class ManInfo: IComparable
		{
			private string Name; //姓名
			private byte Age; //年龄

			public ManInfo(string Name,Byte Age)
			{
				this.Name=Name;
				this.Age=Age;
			}
		
			public override string ToString()
			{
				return Name+"  "+Age.ToString();
				
				
				
				
			}



			#region IComparable 成员
			//实现接口方法
			public int CompareTo(object obj)
			{
				// TODO:  添加 ManInfo.CompareTo 实现
				ManInfo manInfo;
				if(this.GetType().Equals(obj.GetType()))
				{
					manInfo=(ManInfo)obj;
					if(Name.CompareTo(manInfo.Name)<0) //Name第一排序键
						return -1;
					else if(Name.CompareTo(manInfo.Name)>0)
						return 1;
					else if(Age<manInfo.Age) //Age第二排序键
						return -1;
					else if(Age>manInfo.Age)
						return 1;
					else
						return 0;

				}
				else
					throw new ArgumentException("参数类型不匹配");
				return 0;
			}

			#endregion

	
		}

	}
}
