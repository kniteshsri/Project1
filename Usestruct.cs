using System;

struct Mystruct
{
	public int num;
	public char Mychar;
	public string name;
	public double percentage;
};

class Myclass
{
	public static void Main()
	{
		Mystruct ms;
		ms.num=10;
		ms.Mychar='M';
		ms.name="Nitesh";
		ms.percentage=99.99;

		Console.WriteLine("NUMBER is "+ms.num);
		Console.WriteLine("SEX is "+ms.Mychar);
		Console.WriteLine("NAME is "+ms.name);
		Console.WriteLine("PERCENTAGE is "+ms.percentage);
	}
}