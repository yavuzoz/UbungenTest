using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbungenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int buchstabenCode;
            bool leer, erstebuchstabenGross;
            bool nurersteBuchstabenGross=false;

            Console.WriteLine("Bitte Namen eingeben :");
            name = Console.ReadLine();

            leer = string.IsNullOrEmpty(name);

            if (leer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("leere eingabe");

            }
            else
            {
                buchstabenCode = name[0];
                erstebuchstabenGross = buchstabenCode < 65 || buchstabenCode > 90;

                for (int i = 1; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i]))
                    {
                        nurersteBuchstabenGross = true;
                        break;
                    }
                }

                if (erstebuchstabenGross)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("erste buchstaben nicht gross");
                }
                else if (nurersteBuchstabenGross)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nur erste buchstaben gross");
                }
                else
                {
                    Console.WriteLine(name);
                    Console.WriteLine("vielen dank");
                }

            }  Console.ReadLine();
            
        }
    }
}
