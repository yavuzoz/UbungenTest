using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Namen eingeben");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            bool hasError = false;
            if (name.Equals("") || !char.IsLetter(name[0]))
            {
                Console.WriteLine("Leere Eingabe");
                hasError = true;
            }
            else if (char.IsLower(name[0]))
            {
                Console.WriteLine("Erster Buchstabe nicht gross");
                hasError = true;
            }
            else if (!name.Substring(1).ToLower().Equals(name.Substring(1)))
            {
                Console.WriteLine("Nur erster Buchstabe gross");
                hasError = true;
            }
            Console.ResetColor();
            if (!hasError)
            {
                Console.WriteLine("Vielen Dank");
            }
            Console.ReadKey();
        }
    }
}
