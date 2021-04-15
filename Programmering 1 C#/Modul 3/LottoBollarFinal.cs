using System;

namespace LottoBollarFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exceptionBool = true; // Exception för trycatch loopen
            int count = 1; //Räknare som håller reda på vilken boll som skall väljas

            // Vektor som kan hålla tio  heltal
            int[] tal = new int[10];

            Console.WriteLine("Välkommen till dagens Lotto! Idag krävs ingen insats för att vara med");
            Console.WriteLine();
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
                        System.Threading.Thread.Sleep(800); // Fördröjning innan rensning
                        Console.Clear();//Rensar console
                    }
                    catch
                    {
                        Console.WriteLine("Du kan bara ange heltal!");
                        exceptionBool = true;
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
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Skickar in rad...");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine("Här är din lottorad:..");

            foreach (int x in tal) //Loopar igenom vektorns alla element...
            {
                Console.WriteLine("   " + x + "    "); //Skriver ut alla lotto bollar
            }

            Console.WriteLine("");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine("");
            Console.WriteLine("Nu är väntan över! Dags för dragning! Lycka till!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();


            int[] lotto = new int[5]; // Vektor som håller 5 element
            int lottoBalls = 0;

            Random randomTal = new Random();
            for (int i = 0; i < lotto.Length; i++) //Loppar igenom lotto vektor till alla element har ett värde
            {
                lottoBalls = randomTal.Next(1, 25); // sparar random tal till i denna variabel 
                if (lottoBalls != lotto[0] && lottoBalls != lotto[1] && lottoBalls != lotto[2] && lottoBalls != lotto[3] && lottoBalls != lotto[4]) // Denna loop säkerställer så att varje lotto boll blir unik
                {
                    lotto[i] = lottoBalls; // Random tal läggs in i vektor om villkor är true 

                }
                else
                {
                    i--; //Index backar om random tal redan finns i vektor. Slumpar nytt tal
                }
            }

            Console.WriteLine("Dragning pågår...");

            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Alla bollar är nu dragna.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Dagens lottobollar är...");
            

            foreach (int x in lotto) //Loopar igenom vektorns alla element...
            {

                Console.WriteLine("   " + x + "  "); //Skriver ut alla vinnande bollar

            }

            int winningBall = 0; // Sparar antal rätta lottobollar

            for (int i = 0; i < tal.Length; i++) // Loopar användarens tal
            {
                for (int j = 0; j < lotto.Length; j++) //Loopar den rätta Lottoraden med användarens rad
                {
                    if (tal[i] == lotto[j])
                    {
                        winningBall++; // Adderar 1 för varje tal som är lika. 
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Rättar din rad...");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine();
            Console.WriteLine("Resultat har kommit!");
            Console.WriteLine("Tryck enter för att visa resultat:....");
            Console.ReadKey();
            Console.WriteLine();

            // If else villkor som avgör vinstpengar efter antal rätt. Printar ut till användaren ev vinst

            if (winningBall == 1)
            {
                Console.WriteLine($"Du hade {winningBall} rätt. Vinst: 20kr");
            }
            else if (winningBall == 2 || winningBall == 3)
            {
                Console.WriteLine($"Du hade {winningBall} rätt. Vinst: 5000kr");
            }
            else if (winningBall == 4)
            {
                Console.WriteLine($"Du hade {winningBall} rätt. Vinst: 10000kr");
            }
            else if (winningBall == 5)
            {
                Console.WriteLine($"Du hade {winningBall} rätt. JACKPOT!! Vinst: 1,000,000 kr");
            }
            else
            {
                Console.WriteLine("Ingen vinst idag tyvärr, lycka till nästa gång!");
            }
        }
    }
}
