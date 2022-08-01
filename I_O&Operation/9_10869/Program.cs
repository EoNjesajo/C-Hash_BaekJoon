using System;

namespace _9_10869
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] result = {input[0]+input[1], input[0]-input[1], input[0]*input[1], input[0]/input[1], input[0]%input[1]};

            Console.WriteLine(input[0]+input[1]);
            Console.WriteLine(input[0]-input[1]);
            Console.WriteLine(input[0]*input[1]);
            Console.WriteLine(input[0]/input[1]);
            Console.WriteLine(input[0]%input[1]);

            foreach(int value in result)
                Console.WriteLine(value);
        }
    }
}
