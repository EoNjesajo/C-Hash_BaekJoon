﻿using System;

namespace _1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(input[0] + input[1]);
            // string[] input = Console.ReadLine().Split();
            // int a = int.Parse(input[0]);
            // int b = int.Parse(input[1]);
            // Console.WriteLine(a + b);
        }
    }
}
