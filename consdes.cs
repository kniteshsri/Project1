using System;

class student
{
	public student()
	{Console.WriteLine("CONSTRUCTOR called");}
	~student()
	{Console.WriteLine("DESTRUCTOR called");}
	public void disp()
	{Console.WriteLine("DISPLAY METHOD called");}
	public static void Main()
	{
		student st =new student();
		st.disp();
	}
}