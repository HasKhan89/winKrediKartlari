using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public class Kart
    {
        public string KartAdi { get; set; }
        public string BankaAdi { get; set; }
        public int CVCKodu { get; set; }
        public KartTuru Tur { get; set; }

        public void ParaCek(decimal tutar)
        {

        }

        public void ParaYatirma(decimal tutar)
        {

        }
    }

    public enum KartTuru
    {
        Visa = 20,
        Master = 22
    }
}
