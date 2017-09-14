using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public abstract class Bilet
    { 
        public Rezervasyon Rezervasyon { get; set; }
        public int BiletNo { get; set; }
        public decimal Ucret { get; set; }
        public Bilet()
        {
            //Rezervasyon üyesine atanan değere göre cast işlemi yapılır.
            if (Rezervasyon is Gidis)
            {
                Gidis gidis = (Gidis)Rezervasyon;
            }
            else if (Rezervasyon is GidisDonus)
            {
                GidisDonus gidisdonus = (GidisDonus)Rezervasyon;
            }
        }
        //Tam ve öğreni sınıflarında ezilen BiletHesapla ve BiletBilgi metotları. (Çok biçimlilk-polymorphosim)
        public abstract decimal BiletHesapla(decimal ucret);
        public abstract string BiletBilgi();
 }
}
