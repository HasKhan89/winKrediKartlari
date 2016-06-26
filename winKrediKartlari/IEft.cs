using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winKrediKartlari
{
    public interface IEft
    {
        void EftGonder(string iban, decimal tutar);
        void EftPostala();
    }
}
