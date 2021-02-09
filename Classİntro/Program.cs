using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Alper";
            int yas = 19;

            Kurs kurs1 = new Kurs();
            kurs1.Kursadı = "C#";
            kurs1.Egitmen = "Alper Erten";

            Kurs kurs2 = new Kurs();
            kurs2.Kursadı = "Java";
            kurs2.Egitmen = "Kilimci";

            Kurs kurs3 = new Kurs();
            kurs3.Kursadı = "C#";
            kurs3.Egitmen = "Zink";

            Console.WriteLine(kurs1.Kursadı + " : " + kurs1.Egitmen);



        }
  
    class Kurs
    {
            public string Kursadı { get; set; }
            public string Egitmen { get; set; }
            public string MyProperty { get; set; }


   }



