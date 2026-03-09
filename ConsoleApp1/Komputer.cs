using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace PBOWEEK2
{
    public class Komputer
    {
        public string Prosesor;
        public int RAM;
        public bool Menyala;

        public Komputer(string prosesor, int ram)
        {
            Prosesor = prosesor;
            RAM = ram;
            Menyala = false;
        }
        public void Nyalakan()
        {
            Menyala = true;
            Console.WriteLine($"Komputer dengan processor {Prosesor} dinyalakan.");
        }
        public void JalankanProgram(string namaProgram)
        {
            if (Menyala && RAM >= 8)
            {
                Console.WriteLine($"Komputer dengan processor {Prosesor} dan RAM {RAM}GB menjalankan program {namaProgram}.");
            }
            else if (!Menyala)
            {
                Console.WriteLine($"Komputer dengan processor {Prosesor} tidak bisa menjalankan program karena belum dinyalakan.");
            }
            else
            {
                Console.WriteLine($"Komputer dengan processor {Prosesor} tidak bisa menjalankan program karena RAM kurang dari 8GB.");
            }
        }
    
    }
}