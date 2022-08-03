using System;

namespace _1_1330
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if(input[0]<input[1])
                Console.WriteLine("<");
            else if(input[0]>input[1])
                Console.WriteLine(">");
            else
                Console.WriteLine("==");
        }
    }
}
