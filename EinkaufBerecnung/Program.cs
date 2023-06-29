using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinkaufBerecnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bitte total des einkaufs eingeben :");
            int ausgabe = int .Parse(Console.ReadLine());
            int betrag=0;
            berechnenEinkaufs(ausgabe, betrag);
            Console.WriteLine("vilen dank !");
            Console.ReadLine();

        }

        static int berechnenEinkaufs(int ausgabe, int betrag)
        {

            bool checking= true;
            do
            {
                Console.WriteLine("bitte bezahlten betarg eingeben : ");
                betrag = int.Parse(Console.ReadLine());
                ausgabe = ausgabe - betrag;

                if (ausgabe > 0)
                {
                    Console.WriteLine("differenz :" + ausgabe);
                }else if(ausgabe < 0)
                {
                    Console.WriteLine("rückgeld : " + (-ausgabe));
                    checking = false;
                }
                else
                {
                    Console.WriteLine(ausgabe);
                    checking = false;
                }

            } while (checking == true);
            return ausgabe;
            
        }
    }
}
