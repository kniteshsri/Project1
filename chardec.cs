using System;

class Myclass
{
	public static void Main()	
	{
		double val;
		char ch;
		
		Console.Write("Enter a decimal value ");
		val=Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter a Character ");
		ch=Convert.ToChar(Console.ReadLine());
	
		Console.WriteLine("The decimal value is "+val);
		Console.WriteLine("The Character is "+ch);
	}
}
