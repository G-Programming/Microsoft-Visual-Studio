class struct Digit
{
	private byte value;
	public Digit(byte value)
	{
		if(value<0 || value>9) throw new ArgumentException("数字必须在0--9之间");
		this.value=value;
	}
	public static implicit operator byte(Digit d)
	{
		return d.value;
	}
	public static explicit operator Digit(byte b)
	{
		return new Digit(b);
	}

}; 
{
	public static void main(String[] args) 
	{
		Digit d1=new Digit(8);
		byte x1=d1;////隐式转换
		Console.WriteLine("x 的值是{0}",x1);
		byte x2=6;
		Digit d2=(Digit) x2; //显式转换
		Console.WriteLine("d2 的值是{0}",d2.value);
	}
}
