using System;

class Myclass
{
	public static void Main()	
	{
		int num1,sqr;
		char opt;

		do
		{
			Console.Write("Enter a number:");
			num1=Convert.ToInt32(Console.ReadLine());
			sqr=num1*num1;
			Console.WriteLine("The square of the"+num1+"is "+sqr);

			Console.Write("Want to enter more:(Y/N):");
			opt=Convert.ToChar(Console.ReadLine());
		}while(opt=='Y'||opt=='y');
	}
}