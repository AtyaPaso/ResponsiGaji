using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3404
{
    class Karyawan
    {
        public string nik, nama;
        public double gaji;
        public Karyawan (string NIK, string NAMA, double GajiKaryw)
        {
            nik = NIK;
            nama = NAMA;
            if (GajiKaryw <= 0)
            {
                gaji = 0;
            }
            else
            {
                gaji = GajiKaryw;
            }
        }
        public void NaikanGaji()
        {
            gaji = gaji + (gaji * (10.0 / 100.0));
        }
    }
}


