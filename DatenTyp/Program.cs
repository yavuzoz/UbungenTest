using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenTyp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3.64;
            int ganzZahl=(int)a;

            int sayi = 65;
            char karakter = (char)sayi;

            bool dogruMu = true;
            string metin = dogruMu.ToString();

            char karakter1 = 'A';
            bool dogruMu1 = char.IsLetter(karakter1);

            Console.WriteLine(ganzZahl);
            Console.WriteLine(karakter);
            Console.WriteLine(metin);
            Console.WriteLine(dogruMu1);
            string text = " ben ";
            int anzahl = 3;
            WiederholeTextRekursion(text, anzahl);
            Console.ReadLine();
        }
        public static void WiederholeTextRekursion(string text, int anzahl)
        {
            if (anzahl > 0)
            {
                Console.Write(text);
                WiederholeTextRekursion(text, anzahl - 1);
            }
        }


    }
}
