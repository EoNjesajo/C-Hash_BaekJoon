using System;

namespace _8_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            Console.WriteLine(input[0] / input[1]);
            // string[] input = Console.ReadLine().Split();
            // double a = double.Parse(input[0]);
            // double b = double.Parse(input[1]);
            // Console.WriteLine(a / b);
        }
    }
}
