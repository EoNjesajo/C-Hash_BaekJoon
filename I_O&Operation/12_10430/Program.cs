using System;

namespace _12_10430
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] result = {(input[0]+input[1])%input[2], ((input[0]%input[2])+(input[1]%input[2]))%input[2], 
                    (input[0]*input[1])%input[2], ((input[0]%input[2])*(input[1]%input[2]))%input[2]};

            foreach(int value in result)
                Console.WriteLine(value);
        }
    }
}


// 첫째 줄에 (A+B)%C, 둘째 줄에 ((A%C) + (B%C))%C, 셋째 줄에 (A×B)%C, 넷째 줄에 ((A%C) × (B%C))%C를 출력한다.