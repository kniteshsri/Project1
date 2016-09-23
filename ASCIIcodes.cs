//Program to change the letter int ASCII codes.

using System;
class Changecode
{
	public static void Main()
	{
		char  ch;
		int acc;
		Console.Write("Enter the letter:");
		ch=Convert.ToChar(Console.ReadLine());
		
		acc=(int)ch;

		Console.WriteLine("ASCII code of {0} is {1}",ch,acc);
	}
}