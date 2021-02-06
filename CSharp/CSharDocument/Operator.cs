class struct Digit
{
	private byte value;
	public Digit(byte value)
	{
		if(value<0 || value>9) throw new ArgumentException("���ֱ�����0--9֮��");
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
		byte x1=d1;////��ʽת��
		Console.WriteLine("x ��ֵ��{0}",x1);
		byte x2=6;
		Digit d2=(Digit) x2; //��ʽת��
		Console.WriteLine("d2 ��ֵ��{0}",d2.value);
	}
}
