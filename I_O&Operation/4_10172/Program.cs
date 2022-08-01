using System;

namespace _4_10172
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("|\\_/|");
            // Console.WriteLine("|q p|   /}");
            // Console.WriteLine("( 0 )\"\"\"\\");
            // Console.WriteLine("|\"^\"`    |");
            // Console.WriteLine("||_/=\\\\__|");
        
            string[] dog = {"|\\_/|", "|q p|   /}", "( 0 )\"\"\"\\", "|\"^\"`    |", "||_/=\\\\__|"};
            foreach(string str in dog)
                Console.WriteLine(str);
        }
    }
}
