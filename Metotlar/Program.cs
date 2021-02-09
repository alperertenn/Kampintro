using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string Aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.fiyatı = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.fiyatı = 30;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            //type-safe - - tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("- - - - - - - ");

            }

            Console.WriteLine("----------Metodlar----------");
            //encapsulation
            
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2( "Kitap" , "Mavi Kitap" , 20, 4);
            sepetManager.Ekle2("Kitap", "Yeşil Kitap", 20, 6);
            sepetManager.Ekle2("Kitap", "Siyah Kitap", 20, 7);



        }
    }
}
