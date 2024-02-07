using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rewrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool minBool = true; //Jag skapa en bool-variabel för att kontrollera loopen.
                string input = ""; // Jag skapa en strängvariabel för att kunna lagra användarens inmatning.

                while (minBool) // Här vill jag att menyn ska loopa tills användaren väljer att avsluta.
                {
                    //Här är min meny där man kan välja mellan olika menyval.
                    Console.WriteLine("Välkommen till menyn!");
                    Console.WriteLine("\t1. Spara ett föremål i ryggsäcken");
                    Console.WriteLine("\t2. Skriv ut föremålen i ryggsäcken");
                    Console.WriteLine("\t3. Rensa ryggsäcken");
                    Console.WriteLine("\t4. Avsluta programmet");

                    int val = Convert.ToInt32(Console.ReadLine()); // Här läser jag in användarens val och konverterar det till en integer


                    switch (val) // Här hanterar vi användarens val med en switch-sats.
                    {
                        case 1:
                            Console.WriteLine("\tAnge föremålet du vill lägga till i ryggsäcken:"); // Här låter vi användaren ange ett föremål att lägga till i ryggsäcken.
                            Console.WriteLine(input + " har lagts till i ryggsäcken!"); // Här lägger vi till det angivna föremålet i ryggsäcken och ger feedback till användaren.
                            input = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Föremålet i ryggsäcken är: " + input); // Här skriver vi ut föremålet som finns i ryggsäcken.
                            break;

                        case 3:
                            input = ""; // Här tömmer vi ryggsäcken genom att sätta input till en tom sträng.
                            Console.WriteLine("Ryggsäcken är nu tom!");
                            break;
                        
                        case 4:
                            minBool = false; // Här avslutar vi programmet genom att sätta minBool till false.
                            break;
                        
                        default: 
                            Console.WriteLine("Ogiltigt val! Var vänligen välj val 1 till 4."); // Här hanterar vi ogiltiga val från användaren.
                            break;
                    }
                }
            }
        }
    }
}
