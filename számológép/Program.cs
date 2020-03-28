using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace számológép
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam1;
            double szam2;
            string művelet;
            bool elég = false;
            string csekk = ("igen");
            bool lúp = true;
            

            while (elég != true)
            {
                lúp = true;

                Console.Write("Add meg az első számot: ");
                szam1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Milyen műveletet szeretnél (+=összeadás -=kivonás /=osztás *=szorzás): ");
                művelet = Console.ReadLine();

                Console.Write("Add meg a második számot: ");
                szam2 = Convert.ToDouble(Console.ReadLine());


                if (művelet == "+")
                {
                    Console.WriteLine("Végeredmény: " + (szam1 + szam2));
                }
                else if (művelet == "-")
                {
                    Console.WriteLine("Végeredmény: " + (szam1 - szam2));
                }
                else if (művelet == "/")
                {
                    Console.WriteLine("Végeredmény: " + (szam1 / szam2));
                }
                else if (művelet == "*")
                {
                    Console.WriteLine("Végeredmény: " + (szam1 * szam2));
                }
                else
                {
                    Console.WriteLine("Ilyen művelet nem létezik.");
                }

                while (lúp == true)
                {
                    Console.WriteLine("Akarsz egy új számolást végezni? (igen/nem)");
                    csekk = Console.ReadLine();

                    switch (csekk)
                    {
                        case "igen":
                            lúp = false;
                            elég = false;
                            break;

                        case "nem":
                            lúp = false;
                            elég = true;
                            break;

                        default:
                            Console.WriteLine("Csak igen / nem lehet a válasz");
                            break;
                    }
                }
                


                

                    
                }
                





            }
            
           
        }
    }

