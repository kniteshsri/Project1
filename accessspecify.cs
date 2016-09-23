using System;

class Myclass
{
	public int num=6;
	public void Mymethod()
	{
		Console.Writeline("HELLO");
	}
}
class urclass
{
	public static void Main()
	{
		Myclass mc=new Myclass();
		Console.WriteLine(mc.num);
		mc.Mymethod();
	}
}