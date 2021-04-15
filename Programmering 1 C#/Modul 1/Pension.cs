using System;

namespace pensionCalculator
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Pensionkalkylatorn");

            //Ask user for first name
            Console.WriteLine("Ange ditt förnamn: ");
                string firstName = Console.ReadLine();

            //Ask user for last name
            Console.WriteLine("Ange ditt efternamn: ");
                string lastName = Console.ReadLine();

            //Ask user for current age
            Console.WriteLine("Hur gammal är du?");
                int currentAge = int.Parse(Console.ReadLine());

            //Retirement age
            int retirement = 65;


            //Get years left to retirement
            int yearsToRetirement = retirement - currentAge;

            if (yearsToRetirement > 30)
            {
                Console.WriteLine($"Hej {firstName} {lastName}! Det är nu {yearsToRetirement} år kvar tills du går i pension! Du har många års arbete kvar");
            }
            else
            {
                Console.WriteLine($"Hej {firstName} {lastName}! Det är nu {yearsToRetirement} år kvar tills du går i pension! Det börjar bli dags att börja pensionsspara");
            }

            




        }
    }
}
