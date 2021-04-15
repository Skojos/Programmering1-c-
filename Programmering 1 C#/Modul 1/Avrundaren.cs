using System;
using System.Threading;
using System.Timers;

namespace Avrundaren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avrundaren");


            //userInput, decimal
            Console.WriteLine("Ange ett decimaltal som du vill avrunda, ange ett tal med max 20 decimaler:  ");
            string input = Console.ReadLine();
            decimal tal = Convert.ToDecimal(input);

            //Ask user for how many decimals that program round off to
            Console.WriteLine("Hur många deciamler vill du avrunda ditt tal till? Du kan som mest avrunda till 20 decimaler");
            string str = Console.ReadLine();
            int numberOfDecimals = Convert.ToInt32(str);

            //Make round off to 3 deciamls unavaliable, and max round off to 20
            while (numberOfDecimals == 3 || numberOfDecimals > 20)
            {
                Console.WriteLine("Något gick fel. Försökt igen..");
                str = Console.ReadLine();
                numberOfDecimals = Convert.ToInt32(str);
            }
            Console.WriteLine("Strålande! Ditt tal avrundas nu");


            //Round off userInput to choosen numberOfDecimals.
            decimal resultOne = Math.Round(tal, numberOfDecimals);

            //Round off userInput to 3 decimals
            decimal resultTwo = Math.Round(tal, 3);

            //Print result 
            Console.WriteLine($"Ditt tal avrundades till: {resultOne}");
            Console.WriteLine($"Ditt tal ser ut såhär om det avrundas till tre decimaler {resultTwo}");



















        }
    }
}
