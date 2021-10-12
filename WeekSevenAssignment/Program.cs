using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int ctr = 0;

            while (ctr < 3)
            {
                Console.WriteLine("Sisestage PIN");
                string PIN = Console.ReadLine();
                Console.WriteLine("Sisestage nimi");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisestage password");
                string password = Console.ReadLine();

                if (PIN.Length == 4)
                {
                    if (userName != "admin" || password != "admin1234" || PIN != "1234")
                    {
                        Console.WriteLine("Midagi läks valesti. Proovige uuesti.");
                        ctr++;
                    }
                    else if (userName == "admin" && password == "admin1234" && PIN == "1234")
                    {
                        Console.Write("\nThe password entered successfully\n\n");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Vale PIN, proovi uuesti");
                    ctr++;
                    continue;
                }







            }
            









        }
    }
}
