using System;
using System.Linq;

namespace test
{


    class Buss
    {
        public int[] passagerare = new int[25];
        public int antalPassagerare;
        public int counter;
        public int sum;
        public bool stop = true;
        public bool tryCatchLoop = true;
        public int passagereLeft = 25; 



        public void Run() 
        {
          
            int menu = 0;

            do // Initierar menyn
            {
                Console.WriteLine("");
                Console.WriteLine("            ||Buss i väst||");
                Console.WriteLine("");
                Console.WriteLine("     Spara gärna statistik på alla \n     passagerare som kliver på bussen!");
                Console.WriteLine("");
                Console.WriteLine("     Välj meny!");
                Console.WriteLine();
                Console.WriteLine("     1. Lägg till passagerare");
                Console.WriteLine("     2. Skriv ut alla passagerare");
                Console.WriteLine("     3. Räkna ut totala åldern");
                Console.WriteLine("     4. Räkna ut medelåldern");
                Console.WriteLine("     5. Se vem som är äldst på bussen");
                Console.WriteLine("     6. Sortera bussen efter ålder");
                Console.WriteLine("     7. Sök efter passagerare baserat på ålder");
                Console.WriteLine("     0. Avsluta program");

                do// Om användaren trycker in något annat än siffror så kommer denna loop köras. 
                {


                    try 
                    {
                        menu = int.Parse(Console.ReadLine());
                        tryCatchLoop = false; // Avbryter Loop
                        Console.Clear();//Rensar console
                    }
                    catch
                    {
                        Console.Clear();//Rensar console
                        Console.WriteLine("Felaktig inmatning. Ange siffran som motsvarar menyn du vill välja");
                        Console.WriteLine("");
                        Console.WriteLine("            ||Buss i väst||");
                        Console.WriteLine("");
                        Console.WriteLine("     Spara gärna statistik på alla \n     passagerare som kliver på bussen!");
                        Console.WriteLine("");
                        Console.WriteLine("     Välj meny!");
                        Console.WriteLine();
                        Console.WriteLine("     1. Lägg till passagerare");
                        Console.WriteLine("     2. Skriv ut alla passagerare");
                        Console.WriteLine("     3. Räkna ut totala åldern");
                        Console.WriteLine("     4. Räkna ut medelåldern");
                        Console.WriteLine("     5. Se vem som är äldst på bussen");
                        Console.WriteLine("     6. Sortera bussen efter ålder");
                        Console.WriteLine("     7. Sök efter passagerare baserat på ålder");
                        Console.WriteLine("     0. Avsluta program");
                    }
                } while (tryCatchLoop);

                tryCatchLoop = true; // Återställer variablen 

                switch (menu) // Referens till menyn. 
                {

                    case 1:
                        add_passenger();

                        break;
                    case 2:
                        print_buss();
                        break;
                    case 3:
                        calc_total_age();
                        break;
                    case 4:
                        calc_average_age();
                        break;
                    case 5:
                        max_age();
                        break;
                    case 6:
                        sort_buss();
                        break;
                    case 7:
                        find_age();
                        break;
                    case 0:
                        Console.WriteLine("Avslutar program");
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning. Ange siffran som motsvarar menyn du vill välja");
                        break;

                }
            }
            while (menu != 0); // Meny kör tills meny är 0
            
        }

       
        public void add_passenger()
        {
            Console.Clear();//Rensar console
            int temp = 0;
            do // Do While loop som kör tills Try catch är FALSE
            {
                try
                {

                    Console.WriteLine("Hur många passagerare kliver på bussen?");
                    string str = Console.ReadLine();
                    temp = Convert.ToInt32(str);
                    if (temp > passagereLeft) // IF else IF statement. Användaren kan som max knappa in 25 värden.
                    {
                        Console.Clear();//Rensar console
                        Console.WriteLine("OBS! Du har totalt 25 platser på bussen");
                        Console.WriteLine($"Just nu har du {passagereLeft} platser kvar på bussen");
                        Console.WriteLine("Tryck enter för att gå vidare");
                        Console.ReadKey();
                        temp = 0;


                    }                 
                    else
                    {
                        antalPassagerare += temp; // Lägg till i variabln så for loopen(j) vet hur många gånger den skall köra. 
                        stop = false; // Avbrter Try catch loopen. 
                    }
                }
                catch
                {
                    Console.Clear();//Rensar console
                    Console.WriteLine("OBS! Du kan bara mata in heltal");

                }

            } while (stop);


            


                for (int i = 0; (i < passagerare.Length); i++) // Loopar igenom vektorn
                {
                    for (int j = 0; (j < antalPassagerare); j++) // Innre loop som matar igenom antal passagerare som användaren valt att skriva in

                    {
                        if (passagerare[i] == 0)
                          {
                            
                            try
                            {
                                Console.WriteLine("Passagerare " + (i + 1) + ". " + "Skriv in ålder... ");
                                string str = Console.ReadLine();
                                temp = Convert.ToInt32(str);
                                passagerare[i] = temp;
                                counter++;
                                passagereLeft--;
                                
                            }
                            catch
                            {
                            Console.Clear();//Rensar console
                            Console.WriteLine("Felaktig inmatning, du kan bara mata in siffror");
                            j--;
                            }
                        }
                        else if (passagerare[i] != 0) // Om element inte har värdet 0 så hoppar den över till nästa. 
                        {
                        i++;
                        antalPassagerare++;
                        }
                    }
                    
                    antalPassagerare = 0;
                }
            System.Threading.Thread.Sleep(1000);
            Console.Clear();//Rensar console
            
        }

        public void print_buss()
        {
            Console.Clear();//Rensar console
            for (int i = 0; i < passagerare.Length; i++) // Loopar igenom alla element
            {

                Console.WriteLine();

                if (passagerare[i] != 0)
                {
                    Console.WriteLine("Passagerare " + (i + 1) + ". " + "Ålder: " + passagerare[i]);// Skriver ut alla passagerare

                }
                else
                {
                    Console.WriteLine("Passagerare " + (i + 1) + ". " + "Denna platsen är ledig"); // Om ett element har värdet 0 printas detta ut
                }


            }
        }



        public int calc_total_age()
        {
            Console.Clear();//Rensar console
            for (int i = 0; i < passagerare.Length; i++) // Loopar igenom alla element
            {

                sum += passagerare[i]; // För varje element adderas detta tal till variablen sum. 
            }
            Console.WriteLine("Den totala åldern på bussen är: " + sum + " år."); // Skriver ut totalsumma. 

            return sum;
        }


        public void calc_average_age()  
        {
            Console.Clear();//Rensar console
            for (int i = 0; i < passagerare.Length; i++) // Loopar igenom vektorn
            {

                sum += passagerare[i]; // För varje element läggs det till i variablen sum. 
            }
         
            try
            {
                sum = sum / counter;
                Console.WriteLine("Medelåldern på bussen är : " + sum);
            }
            catch // Om användaren inte har lagt in några passagerare 
            {
                Console.WriteLine("Något gick fel, detta kan bero på att du t.ex bara har en passagerare på bussen eller inga alls");
                
            }
    
               
            
        }

        public int max_age() 
        {

            Console.Clear();//Rensar console

            int maxAge = passagerare[0];
            for (int i = 0; i < passagerare.Length; i++)
            {
                if (passagerare[i] > maxAge)
                {
                    maxAge = passagerare[i];
                }


            }
            Console.WriteLine($"Den äldsta pasageraren på bussen är {maxAge} år.");

            return maxAge;
        }

        public void find_age() 

        {
            Console.Clear();//Rensar console
            int keyLow = 0;
            int keyHigh = 0;
            do
            {


                try // Try catch loop som säkerställer så att användare endast matar in siffor
                {
                    Console.WriteLine("Välj ditt spann: ");

                    Console.WriteLine("Ange lägsta ålder: "); 
                    string str = Console.ReadLine();
                    keyLow = Convert.ToInt32(str);


                    Console.WriteLine("Ange högsta ålder: ");
                    str = Console.ReadLine();
                    keyHigh = Convert.ToInt32(str);

                    tryCatchLoop = false;

                }
                catch
                {
                    Console.WriteLine("Felaktig inmatning, du kan bara mata in siffror");
                    tryCatchLoop = true;
                }
            } while (tryCatchLoop);


            Console.WriteLine($"I ditt spann mellan {keyLow} - {keyHigh} finns");

            for (int i = 0; i < passagerare.Length; i++)
            {
                if (passagerare[i] >= keyLow && passagerare[i] <= keyHigh)
                {
                    
                    Console.WriteLine("Passagerare " + (i + 1) + ". Ålder: " + passagerare[i]);
                    Console.ReadLine();
                    
                }
                else if (passagerare[i] > keyLow || passagerare[i] > keyHigh)
                {
                    
                }
            }

        }
        public void sort_buss() 
        {
            Console.Clear();//Rensar console
            int temp;
            bool needsSorting = true;
            int arrayLength = passagerare.Length;

            for (int i = 1; (i <= (arrayLength - 1)) && needsSorting; i++)
            {

                needsSorting = false;

                for (int j = 0; j < (arrayLength - 1); j++)
                {
                    if (passagerare[j + 1] > passagerare[j])
                    {
                        temp = passagerare[j];
                        passagerare[j] = passagerare[j + 1];
                        passagerare[j + 1] = temp;
                        needsSorting = true;
                    }

                }
            }

            Console.WriteLine("Passagerarna är nu sorterade efter ålder. Ordning är äldst till yngst");

            for (int i = 0; i < passagerare.Length; i++)
            {

                Console.WriteLine();
                

                if (passagerare[i] != 0)
                {
                    Console.WriteLine("Passagerare " + (i + 1) + ". " + "Ålder: " + passagerare[i]);
                }
               else
               {
                Console.WriteLine("Passagerare " + (i + 1) + ". " + "Denna platsen är ledig");
               }
            }
        }


        class Program
        {

            static void Main(string[] args)
            {
                var minbuss = new Buss();
                minbuss.Run();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);

            }
        }



    }
}
