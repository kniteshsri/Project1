using System;
class Myclass
{
	public static void main()
	{
		char cnum;	
		Console.Write("Enter the leter:");
		cnum=Convert.ToChar(Console.ReadLine());
		switch(cnum)
		{
			case 'A':
			case 'a':
				Console.Write(cnum+" is a vowel");
				break;
			case 'E':
			case 'e':
				Console.Write(cnum+" is a vowel");
				break;
			case 'I':
			case 'i':
				Console.Write(cnum+" is a vowel");
				break;
			case 'O':
			case 'o':
				Console.Write(cnum+" is a vowel");
				break;
			case 'U':
			case 'u':
				Console.Write(cnum+" is a vowel");
				break;
		}
	}
}