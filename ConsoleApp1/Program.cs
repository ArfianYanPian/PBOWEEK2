using System;
using PBOWEEK2;

namespace PBOWEEK2
{
    class Program
    {
        static void Main()
        {
            //Mobil
            MobilSedan mobil1 = new MobilSedan("Toyota", "Hitam", 2020);
            MobilSedan mobil2 = new MobilSedan("Honda", "Putih", 2022);

            mobil1.NyalakanMobil();
            mobil1.Gas(60);

            mobil2.NyalakanMobil();
            mobil2.Gas(80);

            // Ikan
            ikan ikan1 = new ikan("Pari", "Laut", 20);
            ikan ikan2 = new ikan("Gurame", "Air Tawar", 5);

            ikan1.TampilkanInfo();
            ikan2.Berenang();

            // Burung
            Burung burung1 = new Burung("Elang", true, false);
            Burung burung2 = new Burung("Merpati", false, true);

            burung1.Terbang();
            burung2.makan();


            // Komputer
            Komputer komputer1 = new Komputer("Intel Core i7", 16);
            Komputer komputer2 = new Komputer("AMD Ryzen 3", 6);

            komputer1.Nyalakan();
            komputer2.Nyalakan();
            komputer1.JalankanProgram("Visual Studio Community");
            komputer2.JalankanProgram("Microsoft Word");
        }
    }
}