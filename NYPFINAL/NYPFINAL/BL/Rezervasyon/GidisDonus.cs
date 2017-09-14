using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public class GidisDonus:Rezervasyon
    {
        public DateTime TarihGidis { get; set; }
        public DateTime TarihDonus { get; set; }
       
        public GidisDonus()
        {

        }
        //Rezervasyon sınıfındaki UcretHesapla metodunu ezdik.
        public override decimal UcretHesapla()
        {
            this.Ucret=  base.UcretHesapla()*2;
            return Ucret;
              
        }
        //Rezervasyon sınıfındaki UcretGoster metodunu ezdik.
        public override string UcretGoster()
        {
            return "Gidiş-Dönüş Rezervasyon Ücreti :" + this.Ucret.ToString()+"tl";
        }
        //Rezervasyon sınıfındaki RezervasyonBilgiGoster metodunu ezdik.
        public override string RezervasyonBilgiGoster()
        {
            string temp=base.RezervasyonBilgiGoster();
            temp += "\nGidiş Tarihi:" + this.TarihGidis.Date + "\nDönüş Tarihi:" + this.TarihDonus.Date + "\n";

            return temp;

        }
    }
}
