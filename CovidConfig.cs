using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL9_103022430007
{
    internal class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_deman { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }
        public void UbahSatuan()
        {
            if (satuan_suhu == "celcius")
            {
                satuan_suhu = "fahrenheit";
            }
            else if (satuan_suhu == "fahrenheit")
            {
                satuan_suhu = "celcius";
            }
        }
    }
}
