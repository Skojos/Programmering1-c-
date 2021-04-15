using System;

namespace aktivitetsDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            string userInput = Console.ReadLine();
            int userAge = Convert.ToInt32(userInput);

            int money = 15000;

            do
            {
                if (money > 20000 || userAge < 60)
                {
                    Console.WriteLine("You are saving little");
                    money = money + 500;
                }
                else
                {
                    Console.WriteLine("You are saving a lot");
                    money = money + 1000;
                }
                userAge++;
            }
            while (money < 2000 && userAge > 65);


            Console.WriteLine($"You are retired by the age of {userAge}");
            Console.WriteLine($"You are saved {money} dollars");
            



        }
    }
}
