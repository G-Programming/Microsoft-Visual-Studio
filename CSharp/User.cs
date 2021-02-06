namespace Yq.WinForm
{

	class User
	{
		public string UserName;
		public string Password;
		private string m_Rights;
		//���캯��
		public User(string UserName,string Password):this(UserName,Password,"11")
		{}
		public User(string UserName,string Password,string Rights)
		{
			this.UserName=UserName;
			this.Password=Password;
			m_Rights=Rights;
		}
		//����
		public string 	Rights
		{
			get
			{
				return m_Rights;
			}
			set
			{
				
				if(!IsValid(value))
					//throw new ArgumentException("Ȩ�޴���!");
					m_Rights="00"; //û���κ�Ȩ��!
				m_Rights=value;
			}
		}
		//���Ȩ�����õ���Ч��
		private bool IsValid(string rights)
		{
			//Ȩ��ȡֵ
			//���磺 "00" û���κ�Ȩ��; "01" �Ӵ֣�"10" �»��� ;"11" ��б ;
			string[] Valid=new string[]{"00","01","10","11"};
			int i;
			for(i=0;i<Valid.Length;i++)
				if(rights==Valid[i])
					break;
			if(i==Valid.Length) //�Ƿ�
				return false;
			return true; //�Ϸ�

		}
		//�Ƚ��Ƿ�Ϊͳһ�û�
		public bool IsSameUser(User user)
		{
			bool SameUser;
			SameUser=(this.UserName==user.UserName) && (this.Password==user.Password);
			return SameUser;

		}
	}
	//Ȩ��ö��
	enum RightsEnum
	{
		None=0,
		Bold,
		UnderLine,
		ITalic=3

	}

}
