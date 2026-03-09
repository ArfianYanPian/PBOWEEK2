using System;
using System.Collections.Generic;
using System.Text;

namespace PBOWEEK2
{
    public class ikan
    {
        public string Jenis;
        public string Habitat;
        public int KecepatanBerenang;

        public ikan(string jenis, string habitat, int kecepatan)
        {
            Jenis = jenis;
            Habitat = habitat;
            KecepatanBerenang = kecepatan;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine("Ikan berjenis " + Jenis + " hidup di habitat " + Habitat + ".");
        }
        public void Berenang()
        {
            Console.WriteLine("ikan Berjenis " + Jenis + " berenang dengan kecepatan " + KecepatanBerenang + " km/jam.");
        }

    }

}
