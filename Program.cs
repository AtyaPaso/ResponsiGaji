using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ResponsiPemrograman3404
{
    class Program
    {
        static string formatmatauang(int angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", angka);
        }

        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("20113404", "Atya", 1000000000);
            Karyawan karyawan2 = new Karyawan("12345677", "ChaEunWoo", 400000000);

            Console.WriteLine("\nNO Nik/Nama            Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" {0} {1}                 {2}", karyawan1.nik, karyawan1.nama, formatmatauang((int)karyawan1.gaji));
            Console.WriteLine(" {0} {1}                 {2}", karyawan2.nik, karyawan2.nama, formatmatauang((int)karyawan2.gaji));

            karyawan1.NaikanGaji();
            karyawan2.NaikanGaji();


            Console.WriteLine("\nAlhamdulilah naik gaji 10%");

            Console.WriteLine("\nNO Nik/Nama            Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" {0} {1}                  {2}", karyawan1.nik, karyawan1.nama, formatmatauang((int)karyawan1.gaji));
            Console.WriteLine(" {0} {1}                  {2}", karyawan2.nik, karyawan2.nama, formatmatauang((int)karyawan2.gaji));

            Console.ReadKey();

        }

    }
}
    
