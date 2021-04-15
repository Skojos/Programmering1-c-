using System;

namespace hemligaTalet
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            //Create a random int
            Random randomInt = new Random();
            int randomNumber = randomInt.Next(1, 101);

            //Ask user for a number
            Console.WriteLine("Nu skall du gissa på ett tal mellan 1 och 100");
            


            int userInput;
            int count = 0;
            //Lopp that check userInput and randomNumber
            do
            {
                count++; //count how many times user guesses the number.
                Console.WriteLine("Vilket tal väljer du?");
                string input = Console.ReadLine();
                userInput = Convert.ToInt32(input);

                //Tell user if randomNumber is > or < than userInput
                if (userInput > randomNumber && userInput > 0 && userInput < 100)
                {
                    Console.WriteLine($"Talet är lägre än {userInput}");
                }
                    if (Math.Abs(randomNumber - userInput) <= 2) //Tell user if guessed number is close.
                    {
                        Console.WriteLine("Nu bränns det verkligen!");
                    }

                else if (userInput < randomNumber && userInput > 0 && userInput < 100)
                {
                    Console.WriteLine($"Talet är högre än {userInput}");
                }
                else
                {
                    Console.WriteLine("Du har gissat på ett tal som ligger utanför spannet");
                }

             }
            while (userInput != randomNumber);

            
            Console.WriteLine($"Wow, du gissade rätt. Det rätta talet är {randomNumber}");
            Console.WriteLine($"Du gissade totalt {count} gånger");


        }
    }
}
