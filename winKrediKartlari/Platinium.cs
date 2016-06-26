using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public class Platinium : KrediKarti, IPuanKazanma, IHavale,IEft
    {
        public bool ClubUyeligiVarMi { get; set; }
        public DateTime UyelikBaslangicTarihi { get; set; }
        public DateTime UyelikBitisTarihi { get; set; }

        public int KazanilanPuan
        {
            get;

            set;
        }

        public void UyeligiYenile()
        {

        }

        public void UyeligiBitir()
        {

        }

        public void HavaleGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void EftGonder(string iban, decimal tutar)
        {
            throw new NotImplementedException();
        }

        public void EftPostala()
        {
            throw new NotImplementedException();
        }
    }
}
