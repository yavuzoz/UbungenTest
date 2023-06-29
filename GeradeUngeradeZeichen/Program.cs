using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradeUngeradeZeichen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl, i;
            string eingabe1, eingabe2;

            Console.WriteLine("bitte eingabe1 eingeben :");
            eingabe1 = Console.ReadLine();
            Console.WriteLine("bitte eingabe2 eingeben :");           
            eingabe2 = Console.ReadLine();
            Console.WriteLine("bitte eingabe2 eingeben :");
            zahl = int .Parse(Console.ReadLine());

            i = zahl;
            while (zahl > 0)
            {
                if (zahl % 2 == 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(eingabe1);
                    }
                }
                else if (zahl % 2 == 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(eingabe2);
                    }
                }
                zahl--;
            }
            

            Console.ReadLine();

        }
    }
}
