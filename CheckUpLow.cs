using System;
class Checkuplow
{
	public static void Main()
	{
		char  ch;
		Console.Write("Enter the letter:");
		ch=Convert.ToChar(Console.ReadLine());
		
		if(ch>=65&&ch<=90)
		{
			Console.WriteLine("Letter is in Upper case.");
		}
		else if(ch>=97&&ch<=122)
		{
			Console.WriteLine("Letter is in Lower case.");
		}
		else
		{
			Console.WriteLine("It is not a letter.");
		}
 
	}
}