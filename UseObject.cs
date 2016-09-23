class Bike
{
	public void Accept()
	{
		System.Console.WriteLine("Accepting Bike Details");
	}
	public void Display()
	{
		System.Console.WriteLine("Displaying Bike Details");
	}	

	public static void Main()
	{
		Bike cfs = new Bike();
		cfs.Accept();
		cfs.Display();
	}
}