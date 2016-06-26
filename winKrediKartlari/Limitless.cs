using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public class Limitless : KrediKarti, IHavale, IEft, ITaksit, IPuanKazanma
    {
        public int KazanilanPuan
        {
            get;

            set;
        }

        public void EftGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void EftPostala()
        {
            throw new NotImplementedException();
        }

        public void HavaleGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void TaksitYap(decimal tutar, int taksitSayisi)
        {
            throw new NotImplementedException();
        }
    }
}
