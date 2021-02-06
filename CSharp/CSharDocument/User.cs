namespace Yq.WinForm
{

	class User
	{
		public string UserName;
		public string Password;
		private string m_Rights;
		//构造函数
		public User(string UserName,string Password):this(UserName,Password,"11")
		{}
		public User(string UserName,string Password,string Rights)
		{
			this.UserName=UserName;
			this.Password=Password;
			m_Rights=Rights;
		}
		//属性
		public string 	Rights
		{
			get
			{
				return m_Rights;
			}
			set
			{
				
				if(!IsValid(value))
					//throw new ArgumentException("权限错误!");
					m_Rights="00"; //没有任何权限!
				m_Rights=value;
			}
		}
		//检查权限设置的有效性
		private bool IsValid(string rights)
		{
			//权限取值
			//例如： "00" 没有任何权限; "01" 加粗；"10" 下划线 ;"11" 倾斜 ;
			string[] Valid=new string[]{"00","01","10","11"};
			int i;
			for(i=0;i<Valid.Length;i++)
				if(rights==Valid[i])
					break;
			if(i==Valid.Length) //非法
				return false;
			return true; //合法

		}
		//比较是否为统一用户
		public bool IsSameUser(User user)
		{
			bool SameUser;
			SameUser=(this.UserName==user.UserName) && (this.Password==user.Password);
			return SameUser;

		}
	}
	//权限枚举
	enum RightsEnum
	{
		None=0,
		Bold,
		UnderLine,
		ITalic=3

	}

}
