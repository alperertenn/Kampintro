using System;
using System.Collections.Generic;

namespace Collections
{
    class Program4
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Alper", "Alican", "Ayhan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler = new string[4];
            //isimler[3] = "Hakkı";
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string>() { "Alper", "Alican", "Ayhan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Hakkı");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
