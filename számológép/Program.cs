using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorApp();
        }
      
        
        static void ParsolasiHiba(string hibasErtek)
        {
            Console.WriteLine($"Parsolási hiba: {hibasErtek}");
        }
        static void Szamolo(Double szam1, Double szam2, string muvelet)
        {
            Double eredmeny;
            switch (muvelet)
            {
                case "+":
                    eredmeny = szam1 + szam2;
                    break;
                case "-":
                    eredmeny = szam1 - szam2;
                    break;
                case "/":
                    if (szam2 == 0)
                    {
                        Console.WriteLine("A nullavál való osztás nem értelmezhető!");
                        return;
                    }
                    eredmeny = szam1 / szam2;
                    break;
                case "*":
                    eredmeny = szam1 * szam2;
                    break;
                default:
                    Console.WriteLine("Ilyen művelet nem létezik.");
                    return;
            }
            Console.WriteLine($"Végeredmény: {eredmeny}");
        }
        static Double ConsoleDoubleParser(String consoleMessage)
        {
            Console.Write(consoleMessage);
            string szamString = Console.ReadLine();
            // Parsolás
            Double szam;
            if (!Double.TryParse(szamString, out szam))
            {
                ParsolasiHiba(szamString);
                throw new Exception($"Parse failed! {szam}");
            }
            return szam;
        }
        static bool RetryLoop()
        {
            bool loop = true;
            string csekk = "igen";
            bool continueRunning = false;
            while (loop == true)
            {
                Console.WriteLine("Akarsz egy új számolást végezni? (igen/nem)");
                csekk = Console.ReadLine();
                switch (csekk)
                {
                    case "igen":
                        loop = false;
                        continueRunning = false;
                        break;
                    case "nem":
                        loop = false;
                        continueRunning = true;
                        break;
                    default:
                        Console.WriteLine("Csak igen / nem lehet a válasz");
                        break;
                }
            }
            return continueRunning;
        }
        static void CalculatorApp()
        {
            bool run = true;
            while (run == true)
            {
                Double szam1;
                Double szam2;
                string muvelet;
                try
                {
                    szam1 = ConsoleDoubleParser("Add meg az első számot");
                    Console.Write("Milyen műveletet szeretnél (+=összeadás -=kivonás /=osztás *=szorzás): ");
                    muvelet = Console.ReadLine();
                    szam2 = ConsoleDoubleParser("Add meg a második számot");
                }
                catch (Exception e)
                {
                    Console.WriteLine("We're fucked!");
                    Console.ReadLine();
                    return;
                }
                // fo szamolas
                Szamolo(szam1, szam2, muvelet);
                run = RetryLoop();
                
            }
        }
    }
    
        
    }
