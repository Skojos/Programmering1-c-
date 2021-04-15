using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exceptionBool = true; // Exception för trycatch loopen
            int count = 1; //Räknare som håller reda på vilken boll som skall väljas

            // Vektor som kan hålla tio  heltal
            int[] tal = new int[10];
            Console.WriteLine("Du ska nu välja tio bollar mellan 1 & 25!");



            for (int i = 0; i < tal.Length; i++) /*En for-loop som loppar igenom alla
                                                  element tills användaren har valt sina tal*/
            {
                do /* TryCatch loop för att säkerställa att användaren skriver in heltal-
                    -ett heltal. Detta fixar också så att programmet inte crashar*/
                {
                    try

                    {
                        Console.WriteLine($"Välj boll: {count}");
                        tal[i] = int.Parse(Console.ReadLine());
                        count++;//Räknare som håller reda på vilket tal som användaren skall fylla i
                        exceptionBool = false;
                    }
                    catch
                    {
                        Console.WriteLine("Du kan bara ange heltal!");
                    }

                } while (exceptionBool);

                if (tal[i] < 1 || tal[i] > 25) // Om användaren matar in ett felaktigt tal utanför spannet
                {
                    Console.WriteLine("Du kan endast välja bollar mellan 1 & 25");  
                    i--; // Index backar ett steg.
                    count--; //Räknaren backar ett steg
                }
                else // Om användaren matar in ett tal som redan valts
                {
                    for (int j = 0; j < tal.Length; j++) //Loppar igenom vektorn för att kontrollera om en boll redan har valts.
                    {
                        if (j != i && tal[j] == tal[i])
                        {
                            Console.WriteLine("Du har redan valt:" + tal[i] + ", välj ett annat tal");
                            tal[i] = 0;
                            i--; // Index backar ett steg i vektorn. 
                            count--; //Räknaren backar ett steg
                        }
                    }                   
                }
                exceptionBool = true; 
            }


            //Slumpa fram ett tal
            Random randomTal = new Random();
            int slumpTal = randomTal.Next(1, 26);


            Console.WriteLine();
            Console.WriteLine("Bra jobbat, dina tio valda lottobollar är:");

            foreach (int x in tal) //Loopar igenom vektorns alla element...
            {
                
                Console.WriteLine("| " + x + " |"); //Skriver ut alla lotto bollar
              
            }


            int win = 0; // Lagrar om det var vinst

            int[] lotto = new int


            for (int i = 0; i < tal.Length; i++)
            {
                if (i == slumpTal)
                {
                    win++;
                }

            }

            if (win > 0)
            {
                Console.WriteLine($"Du hade rätt, rätt nummer idag var {slumpTal}");
            }
            else
            {
                Console.WriteLine($"Inga rätt idag bättre lycka nästa gång, rätt nummer idag var {slumpTal}");
            }


              
            

    






        }
    }
}
