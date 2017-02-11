using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sinavHazirlamaProgrami
{
    class KlasikSoru
    {

        public int Id { get; set; }
        public string Soru { get; set; }
        public string Cevap { get; set; }
        public string  Sinif { get; set; }
        public string  Donem { get; set; }
        public string Yazili { get; set; }
        public int Ders_Id { get; set; }
        public string Kolaylik { get; set; }
    }
}
