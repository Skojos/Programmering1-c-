using System;

namespace hemligaTalet
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            //Create a random int
            Random randomInt = new Random();
            int randomNumber = randomInt.Next(0, 101);

            //Ask user for a number
            Console.WriteLine("Nu skall du gissa på ett tal mellan 1 och 100");
            Console.WriteLine("Vilket tal väljer du?");
            int userInput = int.Parse(Console.ReadLine());

            //Lopp that check userInput and randomNumber
            while (userInput != randomNumber)
            {
                //Tell user if randomNumber is > or < than userInput
                if (userInput > randomNumber)
                {
                    Console.WriteLine($"Talet är lägre än {userInput}");
                }
                else if (userInput < randomNumber)
                {
                    Console.WriteLine($"Talet är högre än {userInput}");
                }

                //User can now guess for a new number with som knowledge about the number.
                Console.WriteLine("Du gissade fel. Försök igen..!");
                Console.WriteLine("Vilket tal väljer du nu?");
                userInput = int.Parse(Console.ReadLine());

                
            }

            Console.WriteLine($"Wow, du gissade rätt. Det rätta talet är {randomNumber}");


        }
    }
}
