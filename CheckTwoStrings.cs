using System;

class compare
{
	public static void Main()
	{
		string str1,str2;
		Console.Write("Enter Ist String:");
		str1=Console.ReadLine();
		char []ch1=str1.ToCharArray();
		int n1=str1.Length-1;

		Console.Write("Enter IInd String:");
		str2=Console.ReadLine();
		char []ch2=str2.ToCharArray();
		int n2=str2.Length-1;

		if(n1>n2)
		{
			Console.Write(str1+"\n"+str2);
		}
		else if(n2>n1)
		{
			Console.Write(str2+"\n"+str1);
		}
		else
		{
			for(int i=0;i<n1;i++)
			{
				int c1,c2;
				c1=ch1[i];
				c2=ch2[i];
				if(c1==c2)
				{}
				else if(c1>c2)
				{
					Console.Write(str1+"\n"+str2);
				}
				else
				{
					Console.Write(str2+"\n"+str1);
				}
			}
			
		}
	}
}