﻿using System;

namespace Example1
{
    class Program
    {       public static void Main(string[] args)
        {
            int a = 0, b = 0;
            
            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());
            
            System.Console.WriteLine($"Subtracting {a} - {b} equals {AddNumbers(a, b)} ");
        }
        public static int AddNumbers(int a, int b)
        {
            // Changed addition into subtraction (Modification #1)
            return a - b;
        }
    }
}
