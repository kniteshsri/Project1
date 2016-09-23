using System;

class primeno
{
	public static void Main()
	{
		int n;
		string str;

		Console.WriteLine("Enter a Limit:");	
		str=Console.ReadLine();
		n=Int32.Parse(str);

		bool isprime=true;
		Console.WriteLine("\n The prime number are: ");
		for(int i=0;i<=n;i++)
		{
			for(int j=2;j<=n;j++)
			{
				if(i!=j&&i%j==0)
				{isprime=false;
				 break;
				}
			}
			if(isprime==true)
			{Console.WriteLine(i);}
			isprime=true;
		}
	}
}