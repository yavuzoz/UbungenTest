using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseZahl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("geben sie sieben Ziffern zahl : ");
            int number = int .Parse(Console.ReadLine());   
            bool isSevenDigit= number >= 1000000 && number <= 9999999;

            if (isSevenDigit)
            {
                Console.WriteLine("Girilen sayı 7 basamaklıdır.");
                string result = "";
                char zeichen;
                int zeichenCode=72;
                for (int i = number.ToString().Length - 1; i >= 0; i--)
                {
                    result = result + (number.ToString()[i])+ (char)(zeichenCode-i);

                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Girilen sayı 7 basamaklı değildir." + number);
            }
            
            Console.ReadLine();
        }
    }
}
