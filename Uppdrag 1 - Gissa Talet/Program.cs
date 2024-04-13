using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag_1___Gissa_Talet
{
    internal class Program
    {
        static void Main(string[] args)
        {   Random random = new Random();   // Skapar en variabel som genererar en ny "hemlig" siffra varje gång programmet körs.
            Console.WriteLine("Gissa ett tal mellan 1 och 100!"); 
            string str = Console.ReadLine(); 
            int tal = Convert.ToInt32(str);
            int targetnumber = random.Next(1, 100);  // Här bestämmer jag mellan vilka siffror Programmet ska genera.
            while (tal != targetnumber)              // skapar en loop som låter användaren fortsätta tills den har hittat rätt siffra

                if (tal < targetnumber)              // 
                {

                    if (Math.Abs(tal - targetnumber) <= 3)  // räknar ut differensen mellan talen och om den är mindre = 3 då körs denna IF-sats annars går det vidare
                    {
                        Console.WriteLine("Du har gissat på en för låg siffra");
                        Console.WriteLine("Men du är nära nu");
                        str = Console.ReadLine();
                        tal = Convert.ToInt32(str);
                        
                    }

                    else
                    {
                        Console.WriteLine("Du gissade på en för liten siffra");
                        str = Console.ReadLine();
                        tal = Convert.ToInt32(str);
                    }


                }
                else if (tal > targetnumber)
                {
                    if (Math.Abs(targetnumber - tal) <= 3)   // räknar ut differensen mellan talen och om den är mindre = 3 då körs denna IF-sats annars går det vidare
                    {
                        Console.WriteLine("Du har gissat på en för hög siffra");
                        Console.WriteLine("Men du är nära nu");
                        str = Console.ReadLine();
                        tal = Convert.ToInt32(str);
                        
                    }
                    else
                    {
                        Console.WriteLine("Du gissade på en för hög siffra");
                        str = Console.ReadLine();
                        tal = Convert.ToInt32(str);
                    }
                }
                    

                
            Console.WriteLine("Grattis! Du gissade rätt!");






        }


    }
}   
