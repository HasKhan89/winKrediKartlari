using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winKrediKartlari
{
    public class Titanium : KrediKarti, IEft, IHavale, ITaksit, IPuanKazanma
    {
        public int KazanilanPuan
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
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