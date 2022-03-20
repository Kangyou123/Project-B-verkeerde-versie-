﻿using System;
using System.Linq;



namespace Antal_Bezoker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bezoeker moet minimaal 1 en maximaal 8 personen zijn

            Console.WriteLine("Vul het aantal personen in: ");
            string x;
            int person;
            x = Console.ReadLine();



            // Controleer of het letters of cijfer zijn
            while (!x.All(char.IsDigit))
            {
                Console.WriteLine("Invalid value, Vul het aantal personen in: ");
                x = Console.ReadLine();
            }



            person = int.Parse(x);




            if (person > 0 && person < 9)
            {
                Console.WriteLine("We reserveren de plaats voor u voor " + person + " persoon/personen");



            }
            else if (person < 1)
            {
                Console.WriteLine("Er moet voor minimaal één persoon woerden gereserveerd.");
            }
            else // meer dan 8 personen
            {
                Console.WriteLine("Als u meer dan 8 personen wilt boeken, neem dan telefonisch contact met ons op.\nT: 01 7245 754");
            }
        }



    }
}