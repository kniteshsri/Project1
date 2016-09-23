using System;
class Student
{
	string name;
	int age;
	char sex;

	public void AcceptStDetails()
	{
		Console.Write("Enter the Student's name:");
		name=Console.ReadLine();
		Console.Write("Enter the Student's age:");
		age=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the Student's name:");
		sex=Convert.ToChar(Console.ReadLine());
	}
	
	public void DisplayStDetails()	
	{
		Console.WriteLine("=================================");
		Console.WriteLine("The name is:"+name);
		Console.WriteLine("The age is:"+age);
		Console.WriteLine("The sex is:"+sex);
	}
}
class Mainclass
{
	public static void Main()
	{
		Student St=new Student();
		St.AcceptStDetails();
		St.DisplayStDetails();
	}
}