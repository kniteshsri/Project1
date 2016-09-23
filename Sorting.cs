using System;
using System.Collections.Generic;
using System.Text;

namespace Selectionsort
{
    class Sorting
    {
        static int []arr = new int[5];
        public static void Insert()
        {
            Console.Write("Enter 5 values=>");
            for(int i=0;i<5;i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public static void Display1()
        {
            Console.Write("5 values are =>");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void Selection()
        {
            int temp;
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void Display2()
        {
            Console.Write("5 Sorted values are =>");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Sorting sr = new Sorting();
            Insert();
            Display1();
            Selection();
            Display2();
            Console.ReadLine();
        }
    }
}
