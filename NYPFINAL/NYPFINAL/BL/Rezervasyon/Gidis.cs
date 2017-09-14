using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public class Gidis:Rezervasyon
    {
        public DateTime TarihGidis { get; set; }
        public Gidis()
        {
            this.Odeme = Odeme;
        }
        //Rezervasyon sınıfındaki UcretHesapla metodunu ezdik.
        public override decimal UcretHesapla()
        {
            return base.UcretHesapla();
        }
        //Rezervasyon sınıfındaki UcretGoster metodunu ezdik.
        public override string UcretGoster()
        {
            return "Gidiş Rezervasyon Ucreti :" + this.Ucret.ToString()+"tl";
        }
        //Rezervasyon sınıfındaki RezervasyonBilgiGoster metodunu ezdik.
        public override string RezervasyonBilgiGoster()
        {
            string temp= base.RezervasyonBilgiGoster();
            temp += "\nGidiş Tarihi :" + TarihGidis;
            return temp;
        }
    }
}
