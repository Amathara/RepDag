using Microsoft.VisualBasic;

namespace RepOpgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            //Udskriv værdier:
            /*
                        int age = 5;

                        double height = 90.5;

                        double weight = 20.5;

                        char firstLetter = 'A';

                        string name = "Alfred";

                        bool isStudent = true;

                        Console.WriteLine($"Age: {age} \nHeight: {height}\nWeight: {weight}\nInitial: {firstLetter}\nName: {name}\nIs Student: {isStudent}");
                        Console.ReadLine();

                        //Opgave 2
                        //Omregning mellem celcius og fahrenheit
                        /* formler:
                        F=c*(9/5)+32
                        C=f-32*(5/9)
                         */
            /* Console.WriteLine("Først omregner vi fra Fahrenheit til Celcius!");
             Console.WriteLine("Intast temp i Fahrenheit:");
             double f = Convert.ToDouble(Console.ReadLine());

             double c = ((f - 32.0) * (5.0 / 9.0));

             Console.WriteLine($"{f}°F is {c}°C");

             Console.WriteLine("Nu omregner vi fra Celcius til Fahrenheit!");
             Console.WriteLine("Intast temp i Celcius:");

             double newC = Convert.ToDouble(Console.ReadLine());

             double newF = (newC*(9.0 / 5.0)+32);

             Console.WriteLine($"{newC}°C is {newF}°F");

             */




            //Opgave 3
            //BMI opgave
            //formel: BMI=vægten/højde^2
            /*
            Console.WriteLine("Nu skal vi udregne BMI!");
            Console.WriteLine("Indtast vægt (kg):");
            double vægt = Double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast højde (meter):");
            double højde = Double.Parse(Console.ReadLine());

            

          

            double bmi = vægt / (højde * højde);

            Console.WriteLine($"Dit bmi er:{bmi}");

            */

            // Opgave 7
            //Er tallet negativt, positivt eller lig 0?

            /*  Console.WriteLine("Skriv et tal:");
               double tal = Convert.ToDouble(Console.ReadLine());

               if (tal > 0)
               {
                   Console.WriteLine("Du skrev et positivt tal");
               }

               else if (tal <0)
                   {

                   Console.WriteLine("Du skrev et negativt tal");
               }
              else if (tal == 0)
               {
                   Console.WriteLine("Du skrev 0");
               }

                   Console.ReadLine(); */

            // Opgave 8
            /*  Console.WriteLine("Har du bestået prøven? \nSkriv din karakter (mellem -3 til 12):");
              int karakter = Convert.ToInt32(Console.ReadLine());

              if (karakter >= 2)
              {
                  Console.WriteLine("Yay! Du bestod");
              }

              else
              {
                  Console.WriteLine("Desværre, du bestod ikke denne gang.");
              }
            */
            // Console.ReadLine();



            // Opgave 9
            //Er der skudår? Vi skal lave en if-else som tjekker om der er skudår.

            /* Console.WriteLine("Kan du finde et skudår? \nSkriv et årstal:");
             int årstal = Convert.ToInt32(Console.ReadLine());

             if ((årstal % 4 == 0 && årstal % 100 != 0) || (årstal % 400 == 0))
             {
                 Console.WriteLine("Yay! Du fandt et skudår");
             }

             else {
                 Console.WriteLine("Du fandt IKKE et skudår");
             }
            */

            //Opgave 10
            // Skriv en ugedag
            /* Console.WriteLine("Hej!\nLad os finde en ugedag\nSkriv et tal mellem 1 og 7");
             int dag = Convert.ToInt32(Console.ReadLine());

             switch(dag)
             {
                 case 1:
                     Console.WriteLine("Det er Mandag!");
                     break;
                     case 2:
                     Console.WriteLine("Det er Tirsdag!");
                     break;
                     case 3:
                     Console.WriteLine("Det er Onsdag!");
                     break;
                     case 4:
                     Console.WriteLine("Det er Torsdag!");
                     break;
                     case 5:
                     Console.WriteLine("Det er Fredag! (så det snart weekend)");
                     break;
                     case 6:
                     Console.WriteLine("Det er Lørdag! Enjoy!");
                     break;
                     case 7:
                     Console.WriteLine("Det er Søndag!");
                     break;



             }
             Console.ReadLine();

             // Opgave 11
             // Årets måneder!
             Console.WriteLine("Hej!\nLad os finde en måned!\nSkriv et tal mellem 1 og 12");
             int måned = Convert.ToInt32(Console.ReadLine());

             switch (måned)
             {
                 case 1:
                     Console.WriteLine("Januar: en vintermåned der er mørk og grå. Giver tendens til vinterdeprression ;)");
                     break;
                 case 2:
                     Console.WriteLine("Februar: også en vintermåned. Lidt mindre mørk og grå end januar.");
                     break;
                 case 3:
                     Console.WriteLine("Marts");
                     break;
                 case 4:
                     Console.WriteLine("April");
                     break;
                 case 5:
                     Console.WriteLine("Maj");
                     break;
                 case 6:
                     Console.WriteLine("Juni");
                     break;
                 case 7:
                     Console.WriteLine("Juli");
                     break;
                 case 8:
                     Console.WriteLine("August");
                     break;
                 case 9:
                     Console.WriteLine("September");
                     break;
                 case 10:
                     Console.WriteLine("Oktober");
                     break;
                 case 11:
                     Console.WriteLine("November");
                     break;
                 case 12:
                     Console.WriteLine("December!");
                     break;
             } */

            //Opgave 12
            Console.WriteLine("Nu skriver vi tal fra 1 til 10");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
