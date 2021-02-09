using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
         {
            string kurs1 = "Alicanı geliştirme kampı";
            string kurs2 = "Köpek geliştirme kampı";
            string kurs3 = "Tavşan geliştirme kampı";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);


            string[] kurslar = new string[] { "Alicanı geliştirme kampı", "Köpek geliştirme kampı", "Tavşan geliştirme kampı" };
            
            
            
            for (int i = 0; i<3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti ");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }   
            
    }
}
