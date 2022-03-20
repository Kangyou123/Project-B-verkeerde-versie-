using System;

namespace Menu
{
    class Program
    {
        public static void Main(string[] args)
        {
            Begin: Console.WriteLine("Hallo! \n");
            Console.WriteLine(" Kies 1 voor de Voorgerechten");
            Console.WriteLine(" Kies 2 voor de Hoofdgerechten");
            Console.WriteLine(" Kies 3 voor de Vegatarische gerechten");
            Console.WriteLine(" Kies 4 voor de Dessert \n ");
            dot: Console.WriteLine("\n");

            Console.WriteLine(" Type een nummer in : ");
            int Choose_nummer = int.Parse(Console.ReadLine());

            if (Choose_nummer != 1 || Choose_nummer != 2 || Choose_nummer != 3 || Choose_nummer != 4)
            {
                Console.WriteLine("\n  Nummer mislukt,  Kies tussen de nummers 1 - 2 - 3 - 4");
                goto dot;



            }
            else if (Choose_nummer == 1)
            {
                Console.Clear();
                Console.WriteLine("Gerecht 1        Prijs :3.5 ");
                Console.WriteLine("Gerecht 2");
                Console.WriteLine("Gerecht 3");
                Console.WriteLine("Gerecht 4");
                Console.WriteLine("Gerecht 5");
                Console.WriteLine("Gerecht 6");
                Console.WriteLine("Gerecht 7");
                Console.WriteLine("Gerecht 8");
                Console.WriteLine("Gerecht 9");
                Console.WriteLine("Gerecht 10");

            }
            else if (Choose_nummer == 2)
            {
                Console.Clear();
                Console.WriteLine("Gerecht 1        Prijs :5.5 ");
                Console.WriteLine("Gerecht 2");
                Console.WriteLine("Gerecht 3");
                Console.WriteLine("Gerecht 4");
                Console.WriteLine("Gerecht 5");
                Console.WriteLine("Gerecht 6");
                Console.WriteLine("Gerecht 7");
                Console.WriteLine("Gerecht 8");
                Console.WriteLine("Gerecht 9");
                Console.WriteLine("Gerecht 10");
            }
            else if (Choose_nummer == 3)
            {
                Console.Clear();
                Console.WriteLine("Gerecht 1        Prijs :5.5 ");
                Console.WriteLine("Gerecht 2");
                Console.WriteLine("Gerecht 3");
                Console.WriteLine("Gerecht 4");
                Console.WriteLine("Gerecht 5");
            }
            else if (Choose_nummer == 4)
            {
                Console.Clear();
                Console.WriteLine("Gerecht 1        Prijs :5.5 ");
                Console.WriteLine("Gerecht 2");
                Console.WriteLine("Gerecht 3");
                Console.WriteLine("Gerecht 4");
                Console.WriteLine("Gerecht 5");
                Console.WriteLine("Gerecht 6");
            }
        }
    }

}