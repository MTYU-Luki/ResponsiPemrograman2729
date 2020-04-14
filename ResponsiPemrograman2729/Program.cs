using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2664
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Karyawan kr1 = new Karyawan(345435, "Luki", 300000);
            Karyawan kr2 = new Karyawan(435454, "Fiagnia", 200000);


            Console.WriteLine(" Nim\tNama\tGaji Bulanan");
            Console.WriteLine(" ============================");
            Console.WriteLine(" {0}\t{1}\t{2}     ", kr1.Nik, kr1.Nama, kr1.Gaji);
            Console.WriteLine(" {0}\t{1}\t{2}     ", kr2.Nik, kr2.Nama, kr2.Gaji);

            Console.WriteLine(" Setelah Menambah gaji 10%");

            Console.WriteLine(" Nim\tNama\tGaji Bulanan");
            Console.WriteLine(" ============================");
            Console.WriteLine(" {0}\t{1}\t{2}     ", kr1.Nik, kr1.Nama, kr1.Gaji);
            Console.WriteLine(" {0}\t{1}\t{2}     ", kr2.Nik, kr2.Nama, kr2.Gaji);

            Console.ReadLine();
        }

    }
}