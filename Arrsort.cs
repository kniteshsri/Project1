using System;
using System.Collections.Generic;
using System.Text;

namespace ArraySortng
{
    class Arrsort
    {
        static int[] arr1;
        static int[] arr2;
        static int[] arr3 = new int[10];

        public static void Insert()
        { 
            arr1 = new int[10] {23,2,32,15,54,33,78,89,91,9};
            arr2 = new int[10] {26, 27, 5, 48, 13, 64, 79, 22, 90, 95 };
            
            for(int i=0;i<10;i++)
            {
                arr3[i]=arr1[i]+arr2[i];
            }
        }
        public static void Selection()
        {
            int temp;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)

                {
                    if (arr3[i] > arr3[j])
                    {
                        temp = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = temp;
                    }
                }
            }
        }

        public static void Display1()
        {
            Console.Write("The 1st array is:\t" );
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr1[i] + ",");
            }
            Console.WriteLine();

            Console.Write("The 2nd array is:\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr2[i] + ",");
            }
            Console.WriteLine();

            Console.Write("The 3rd array sum is => ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr3[i] + ",");
            }
            Console.WriteLine();
        }

        public static void Display2()
        {
            Console.Write("Sorted Array is =>\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr3[i] + ",");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Insert();
            Display1();
            Selection();
            Display2();
            Console.ReadLine();
        }
    }
}
