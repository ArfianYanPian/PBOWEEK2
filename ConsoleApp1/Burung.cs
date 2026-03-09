using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PBOWEEK2
{
    public class Burung
    {
        public string Nama { get; set; }
        public bool punyaSayap { get; set; }
        public bool punyaParuh { get; set; }

        public Burung(string nama, bool sayap, bool paruh)
        {
            Nama = nama;
            punyaSayap = sayap;
            punyaParuh = paruh;
        }

        public void Terbang()
        {
            if (punyaSayap)
            {
                Console.WriteLine($"Burung {Nama} sedang terbang.");
            }
            else
            {
                Console.WriteLine($"Burung {Nama} tidak bisa terbang karena tidak memiliki sayap.");
            }
        }

        public void makan()
        {
            if (punyaParuh)
            {
                Console.WriteLine($"Burung {Nama} sedang makan menggunakan paruhnya.");
            }
            else
            {
                Console.WriteLine($"Burung {Nama} tidak bisa makan karena tidak memiliki paruh.");
            }
        }
    }
}
