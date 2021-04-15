using System;

namespace americanInSauna
{
    class Program

    {

        //METHOD: Convert fahrenheit to celcius
        public static int FahrenheitToCelcius(int fahrenheit)
        {
            int celcius = ((fahrenheit - 32) * 5) / 9;
            return celcius;
        }


        public static void Main(string[] args)
        {

            int celcius = 0; //intialize global variable celcius
            int fahrenheit;
            bool inputExLoop = true;
            string userInput;




            // Do while loop to notify if user choosed the correct temperature that is suitable in the sauna

            do
            {


                do
                {
                    Console.WriteLine("Please turn on the heat, enter desired temperature: ");
                    userInput = Console.ReadLine();

                    try
                    {
                        fahrenheit = Convert.ToInt32(userInput);
                        celcius = FahrenheitToCelcius(fahrenheit);
                        inputExLoop = false;
                    }
                    catch
                    {
                        Console.WriteLine("Du kan bara ange temperature med siffror!");
                       
                    }

                } while (inputExLoop);



                if (celcius < 73)
                {
                    Console.WriteLine($"{celcius} celcius is to low temperature. You can turn the heat up");
                    Console.WriteLine("Note that 167 fahrenheit is a perfect temperature for the sauna.");
                }
                else if (celcius > 77)
                {
                    Console.WriteLine($"{celcius} celcius is to hot. Turn it down a little bit");
                    Console.WriteLine("Note that 167 fahrenheit is a perfect temperature for the sauna.");
                }
                else if (String.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Tryck enter för att ange temperatur igen: ");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"The heat is now set to {celcius} celcius. Enjoy the sauna");
                }

            } while (celcius != 75);

        }






    }
}
