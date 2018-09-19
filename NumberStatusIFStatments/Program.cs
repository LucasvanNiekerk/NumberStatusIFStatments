using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberStatusIFStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            Everything();
        }

        private static void Everything()
        {
            Console.WriteLine(
                "Velkommen til - Vil du vide om et heltal er (p)ositivt eller (n)egativt eller om hvilket af to heltal er (s)tørst?");
            String information = Console.ReadLine();
            if (information == "p" || information == "n" || information == "P" || information == "N") //Hvis brugeren vi vide om tallet er et positivt, negativt eller 0.
            {
                Console.WriteLine("Indtast venligst det tal du vil vide mere om.");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine(number + " er et negativt tal! \n");
                    Everything();
                }

                if (number == 0)
                {
                    Console.WriteLine(number + " er nul! \n");
                    Everything();
                }

                if (number > 0)
                {
                    Console.WriteLine(number + " er et positivt tal! \n");
                    Everything();
                }
            }

            if (information == "s" || information == "S") //Hvis brugeren vil vide hvilket tal er størst
            {
                Console.WriteLine("Indtast venligst det første tal!");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast venligst det andet tal!");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                if (numberOne < numberTwo)
                {
                    Console.WriteLine(numberTwo + " er større end " + numberOne + "! \n");
                    Everything();
                }

                if (numberOne > numberTwo)
                {
                    Console.WriteLine(numberOne + " er større end " + numberTwo + "! \n");
                    Everything();
                }
            }
            else
            {
                Console.WriteLine("Det var desværre ikke en mulighed prøv igen. \n");
                Everything();
            }
        }
    }
}
