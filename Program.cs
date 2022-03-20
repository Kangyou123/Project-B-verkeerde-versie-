using System;

namespace ProjectB_Leeftijd
{
    internal class Program
    {    // de gebruiker is minstens 16 
        static void checkAge()
        {
            int input;

            Console.Write("\nVoer uw leeftijd in: ");

            // Zorg ervoor dat de waarde geldig is, en niet letters
            while (!int.TryParse(Console.ReadLine(), out input) || input > 102 || input < 16)
            {
               
                if (input == 0 || input > 102)
                {
                    Console.WriteLine("Ongeldige waarde, voer uw echte leeftijd in: ");
                }
                else if (input > 3)
                {
                    Console.WriteLine("U kunt geen account aanmaken.");
                    break;
                }
                else
                {
                    Console.WriteLine("Ongeldige leeftijd Data!");
                }

                Console.Write("\nVoer uw echte leeftijd in: ");
            }

            if (input > 15 && input < 102)
            {
                Console.WriteLine("U kunt een account aanmaken.\n");
            }
        }
        // Hoofd Method 
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom in ons resturant!");
            checkAge();
        }
    }
}
