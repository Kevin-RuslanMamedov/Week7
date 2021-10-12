using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda eesnimi");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta enda perekonna nimi");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere, {firstName[0]} {lastName[0]}");


        }
    }
}
