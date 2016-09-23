using System;
class Myclass
{
	enum name{Raj,Narendra,Anu,Aarti,Alam,Nitesh};

	public static void Main()
	{
		int rank;
		rank = (int)name.Nitesh;
		Console.WriteLine("Position of name Nitesh is "+rank);
	}
}