using System;
using System.Collections;

class Myarraylist
{
	public static void Main()
	{
		ArrayList AL=new ArrayList();
		AL.Add("Nitesh");
		AL.Add("Abhinit");
		AL.Add("Chandan");
		AL.Add("Arun");
		AL.Add("Rajesh");

		Console.WriteLine("Elements inthe list are: ");
		for(int i=0;i<AL.Count;i++)
		{
			Console.WriteLine(AL[i]);
		}
	}
}