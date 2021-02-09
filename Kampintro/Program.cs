using System;

namespace Kampintro
{
	class Program
	{
		static void Main(string[] args)
		{
			
			
			string Kategorietiketi = "Kategoriler";
			int Ogrencisayisi = 32000;
			double Faizorani = 1.45;
			bool Girisyapmismi = false;
			double dolardun = 7.30;
			double dolarbugun = 7.35;

			if (dolardun>dolarbugun)
			{
				Console.WriteLine("Azalış oku");

			}
			else if (dolardun<dolarbugun)
            {

				Console.WriteLine("Artış oku ");

			}
            else
            {
				Console.WriteLine("Değişmedi Butonu");
            }



            if (Girisyapmismi == true )
            {
				Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
				Console.WriteLine("Giriş Yap Butonu");
					
		
            }
			
			
		       

			Console.WriteLine(Kategorietiketi);

			





		}
        
			
		
	}
}
