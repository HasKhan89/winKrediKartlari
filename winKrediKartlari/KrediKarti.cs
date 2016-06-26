using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public class KrediKarti : Kart
    {
        public DateTime SonKullanimTarihi { get; set; }
        public bool EkKartMi { get; set; }

        public void BorcOde(decimal tutar)
        {

        }
    }
}
