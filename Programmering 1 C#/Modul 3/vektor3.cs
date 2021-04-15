using System;

namespace vektor
{
    class Program
    {
        static void Main(string[] args)
        {
            int preSetInt = 23; // Förbestämt tal för att som användaren väljer samma. 
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
                    }
                exceptionBool = false;

                }
                catch
                {
                    Console.WriteLine("Woops! Du kan bara ange heltal, börja om från början"); //Låter användaren veta att felaktig inmatning har gjorts och användaren måste börja om. 
                    exceptionBool = true; // Loop börjar om 
                }

            } while (exceptionBool);



            //Skriver ut samtliga tal som användaren valt. Användaren får veta om hen val samma tal som datorn 
            Console.WriteLine("Du har valt dina tal, tryck enter för att visa...\n");
            Console.ReadKey();

            for (int i = 0; i < tal.Length; i++) // Loopar igenom hela vektorn och skriver ut

                if (tal[i] == preSetInt)
                {
                    Console.WriteLine(tal[i] + ", " + "datorn valde också detta talet! WOW!!\n");
                }
                else
                {
                    Console.WriteLine(tal[i] + "\n");
                }
        }
    }
}
