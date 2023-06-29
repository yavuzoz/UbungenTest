using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabeKontrolle
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            bool leer, ersteBuchstaben;
            bool folgendeBuchstaben = false;

            Console.WriteLine("bitte namen eingeben ");
            name = Console.ReadLine();

            leer = string.IsNullOrEmpty(name);

            if (leer || !char.IsLetter(name[0]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Leere eingabe ");
            }
            else
            {
                ersteBuchstaben = char.IsLower(name[0]);
                for(int i=0; i<name.Length; i++)
                {
                    char c = name[i];
                    if (char.IsUpper(c))
                    {
                        folgendeBuchstaben = true;
                        break;
                    }
                }
                if (ersteBuchstaben)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("erste buchstaben nicht gross ");

                }else if(folgendeBuchstaben==true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nur erste buchstaben gross ");
                }
            }

            Console.ReadLine();
        }
    }
}
