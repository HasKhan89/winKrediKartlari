using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public class Silver : KrediKarti, ITaksit,IEft
    {
        public bool KisitlamaVarMi { get; set; }
        public DateTime KisitlamaTarihi { get; set; }

        public void TaksitYap(decimal tutar, int taksitSayisi)
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

        /// <summary>
        /// sadasdsadasdsad
        /// </summary>
        public string YeniMetot(string ad, int yas)
        {
            throw new System.NotImplementedException();
        }
    }
}
