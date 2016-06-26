using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public interface IHavale
    {
        void HavaleGonder(string iban, decimal tutar);
    }
}
