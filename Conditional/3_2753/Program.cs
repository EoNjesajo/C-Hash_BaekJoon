﻿using System;

namespace _3_2753
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if(input%4==0 && (input%100!=0 || input%400==0))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
