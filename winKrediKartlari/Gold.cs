using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public class Gold : KrediKarti, IPuanKazanma, IHavale, ITaksit
    {
        public bool IndirimOzelligiVarMi { get; set; }
        public bool KampanyaTanimliMi { get; set; }
        public DateTime KampanyaBaslangicTarihi { get; set; }
        public DateTime KampanyaBitisTarihi { get; set; }

        public int KazanilanPuan
        {
            get;

            set;
        }

        public void KampanyaTanimla()
        {

        }

        public void KampanyaBitir()
        {

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
