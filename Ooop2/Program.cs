using System;

namespace Ooop2
{
    class Program
    {
        static void Main(string[] args)
        {   //Mustafa Alper Erten
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = 111222;
            musteri1.Adi = "Mustafa Alper";
            musteri1.Soyadı = "Erten";
            musteri1.TcNo = "12345678910";

            // website.com //

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 123;
            musteri2.MusteriNo = 333;
            musteri2.SirketAdi = "?";
            musteri2.VergiNo = "123";


            // Gerçek Müşteri - Tüzel Müşteri

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            

        }
    }
}
