using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int betrag;
            int summe = 0;
            string antwort;

            do
            {
                betrag = int.Parse(Console.ReadLine());

                summe = summe + betrag;

                if (betrag < 0)
                {
                    Console.WriteLine("sind sie sicher?( j/n ) ");
                    antwort = Console.ReadLine();
                    if (antwort == "j")
                    {
                        summe = summe+0;
                        if (summe < 0)
                        {
                            Console.WriteLine("summe zu klein ");
                            summe = summe - betrag;
                        }
                    }
                    else
                    {
                        summe = summe - betrag;
                    }
                }else if (summe > 1000)
                {
                    Console.WriteLine("teilzahlung notwendig, summe :" + summe);
                    break;
                }

            } while (betrag!=0);
            Console.WriteLine("summe :" + summe);
            Console.ReadLine();
        }
    }
}
