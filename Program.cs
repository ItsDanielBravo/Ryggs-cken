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
                bool minBool = true;
                string input = "";

                while (minBool)
                {
                    Console.WriteLine("Välkommen till menyn!");
                    Console.WriteLine("\t1. Spara ett föremål i ryggsäcken");
                    Console.WriteLine("\t2. Skriv ut föremålen i ryggsäcken");
                    Console.WriteLine("\t3. Rensa ryggsäcken");
                    Console.WriteLine("\t4. Avsluta programmet");
                    int val = Convert.ToInt32(Console.ReadLine());

                    switch (val)
                    {
                        case 1:
                            Console.WriteLine("\tAnge föremålet du vill lägga till i ryggsäcken:");
                            Console.WriteLine(input + " har lagts till i ryggsäcken!");
                            input = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Föremålet i ryggsäcken är: " + input);
                            break;

                        case 3:
                            input = ""; // Avsluta programmet
                            Console.WriteLine("Ryggsäcken är nu tom!");
                            break;
                        
                        case 4:
                            minBool = false;
                            break;
                        
                        default:
                            Console.WriteLine("Ogiltigt val! Var vänligen välj val 1 till 4.");
                            break;
                    }
                }
            }
        }
    }
}
