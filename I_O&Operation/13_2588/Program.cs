using System;

namespace _13_2588
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            
            int[] c=new int[3];
            int result = 0;

            for(int i=b.Length; i>0; i--){
                c[i-1] = a * (b[i-1]-'0');
                Console.WriteLine(c[i-1]);
                result += c[i-1]*(int)Math.Pow(10,3-i);
            }
            Console.WriteLine(result);
        }
    }
}
