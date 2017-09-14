using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public class Havale:Odeme
    {
        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public string HesapNo { get; set; }
        public string IBANNo { get; set; }
        //Odeme sınıfındaki OdemeBilgiGoster metodunu ezdik. (Çok biçimlilik- Polymorphosim)
        public override string OdemeBilgiGoster()
        {
           string temp="\nBanka Adı:"+BankaAdi+"\nŞube Adı:"+SubeAdi+"\nHesap No:"+HesapNo+"\nIBAN No:"+IBANNo;
            return temp;
        }
    }
}
