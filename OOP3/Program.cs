using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKredisiManager = new KonutKredisiManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKredisiManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            

        }
    }
}
