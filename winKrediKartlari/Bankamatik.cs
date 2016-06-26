using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public class Bankamatik : Kart, IHavale
    {
        public decimal Bakiye { get; set; }
        public HesapTuru HesapTur { get; set; }

        public void HavaleGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void LimitTanimla(decimal tutar)
        {

        }
    }

    public enum HesapTuru
    {
        TL,
        USD,
        EURO,
        AUX
    }
}
