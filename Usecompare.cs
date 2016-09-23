using System;
class Usecompare
{
	public static void Main()
	{
		bool res;
		int x,y;
		Console.WriteLine("Enter value for X:");
		x=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter value for Y:");
		y=Convert.ToInt32(Console.ReadLine());
		res=x<y;

		Console.WriteLine("Is X<Y:"+res);

	}
}