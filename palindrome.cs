using System;

class Palin
{
	public static void Main()
	{
	bool val=true;
	string str;

	Console.WriteLine("Enter any string : ");
	str=Console.ReadLine();
	char []ch=str.ToCharArray();
	int n=str.Length-1;
	int i=0;
	while(i<=n)
	{
		if(ch[i]==ch[n])
		{
			i++;
			n--;
		}
		else
		{
			val=false;
			break;
		}
	}
	if(val==true)
	{Console.Write(str+" is Palindrome.");}
	else
	{Console.Write(str+" is not a Palindrome.");}
	}
}