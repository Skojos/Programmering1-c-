using System;

namespace vektor3
{
    class Program
    {
        static void Main(string[] args)

        {

            bool exceptionBool = true;

            // Vektor som kan hålla tio  heltal
            int[] tal = new int[10];
            Console.WriteLine("Du ska nu ange tio tal!");

            //Låt användaren tilldela värderna till vektorn tio element

            do // Loop fortsätter tills användaren har valt tio tal
            {
                try // Kontrollerar så att användaren bara skrivaren in heltal
                {
                    for (int i = 0; i < tal.Length; i++)
                    {
                        Console.WriteLine($"Ange talet som kommer ligga på index {i}:... ");
                        string userInput = Console.ReadLine();//Läs in värden från användaren
                        int elements = Convert.ToInt32(userInput);//Converterar till int
                        tal[i] = elements;
                        exceptionBool = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Woops! Du kan bara ange heltal, börja om från början"); //Låter användaren veta att felaktig inmatning har gjorts och användaren måste börja om. 
                    exceptionBool = true; // Loop börjar om 
                }

            } while (exceptionBool);

        }
    }
}
