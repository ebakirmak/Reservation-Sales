using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
  public  class KrediKart:Odeme
    {
        public string KKNo { get; set; }
        public string KKAdi { get; set; }

      //Odeme sınıfındaki OdemeBilgiGoster metodunu ezdik. (Çok Biçimlilik-Polymorphsim)
        public override string OdemeBilgiGoster()
        {
            return "\nÖdeme Stili: Kredi Kartı\n" + "Kredi Kartı No:" + KKNo + "\nKredi Kartı Adı:" + KKAdi+"\nÖdenilen Tutar:"+Odenilen.ToString();
        }
    }
}
