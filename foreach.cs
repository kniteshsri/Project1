using System;

class useforeach
{
	public static void Main()
	{
		string []arr={"Raj","Abhinit","Nitesh","Prashant","Gautam","Abhishek"};
		
		Console.WriteLine("Students in the batch are:");
		foreach(string k in arr)
		{
			Console.WriteLine(k);
		}
	}
}