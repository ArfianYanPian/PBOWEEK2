using System;
using System.Collections.Generic;
using System.Text;

namespace PBOWEEK2
{
    public class MobilSedan
    {
        public string merk;
        public string warna;
        public int tahun;
        public int kecepatan;

        // Constructor
        public MobilSedan(string merk, string warna, int tahun)
        {
            this.merk = merk;
            this.warna = warna;
            this.tahun = tahun;
            kecepatan = 0;
        }

        // Method
        public void NyalakanMobil()
        {
            Console.WriteLine(merk + " dinyalakan");
        }

        public void Gas(int tambah)
        {
            kecepatan += tambah;
            Console.WriteLine("Kecepatan sekarang: " + kecepatan);
        }
    }
}