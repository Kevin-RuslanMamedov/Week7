using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda eesnimi");
            string userName = Console.ReadLine();
            
            if (userName.Length >= 5)
            {
                for (int i = userName.Length - 1; i >= 0-+; i--)
                {
                    Console.Write($"{userName}{i}");
                }
            }
            else
            {
                Console.WriteLine($"{userName}");
            }



        }
    }
}
