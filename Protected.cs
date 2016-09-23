using System;

class Myclass
{
	protected int num=6;
	public void Mymethod()
	{
		Console.WriteLine("HELLO");
	}
}
class Urclass :Myclass
{
	public static void Main()
	{
		Urclass mc = new Urclass();
		Console.WriteLine(mc.num);
		mc.Mymethod();
	}
}