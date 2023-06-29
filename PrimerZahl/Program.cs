
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerZahl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geben sie ein zahl :");
            int zahl = int .Parse(Console.ReadLine());

            if (zahl < 2)
            {
                Console.WriteLine("zahl ist nicht primer zahl :" + zahl);
            }else if (zahl >= 2)
            {
                 for(int i = 2; i <= zahl; i++)
                 {
                        bool isPrime=true;
                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;

                                break;
                            }
                        }
                        if (isPrime)
                        {
                            Console.WriteLine(i + " ist primer zahl ");
                        }
                 }
             }

                    Console.ReadLine();
        }
    }
}
