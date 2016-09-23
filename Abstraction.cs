using System;

class Myclass
{
	public int num=6;
	public void Mymethod()
	{
		Console.WriteLine("HELLO");
	}
}
class Urclass
{
	public static void Main()
	{
		Myclass mc = new Myclass();
		Console.WriteLine(mc.num);
		mc.Mymethod();
	}
}