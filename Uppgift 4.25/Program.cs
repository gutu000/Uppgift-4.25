using System;
namespace Uppgift_4._25
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            string l = Console.ReadLine();
            string k = Console.ReadLine();
            int tal1 = Convert.ToInt32(l);
            int tal2 = Convert.ToInt32(k);

            Console.WriteLine("Välj ett av följande");
            Console.WriteLine("1. Subtraktion");
            Console.WriteLine("2. Divition");
            Console.WriteLine("3. Avsluta programmet :) ");
            string räknesätt = Console.ReadLine();
            int Svar = int.Parse(räknesätt);


            switch (Svar)
            {
                case 1:
                    Console.WriteLine(tal1 - tal2);
                    break;
                case 2:
                    Console.WriteLine(tal1 / tal2);
                    break;

            }


        }
    }
}