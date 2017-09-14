using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
   public class Tam:Bilet
    {
       //Tam tipinde bilet için yüzde 10 indirim yapılacak.
       protected const decimal INDIRIMORANI = 0.1M;
       //Parametre alan constroctor
       public Tam(int biletNo)
       {
           this.BiletNo = biletNo;
       }
       //Bilet sınıfındaki BiletHesapla metodunu ezdik.
       public override decimal BiletHesapla(decimal ucret)
       {
           this.Ucret = ucret-(ucret * INDIRIMORANI);
           return ucret;
       }
       //Bilet sınıfındaki BiletBilgi metodunu ezdik.
       public override string BiletBilgi()
       {
           string temp = "";
           if (Rezervasyon is GidisDonus)
           {
               GidisDonus gd = (GidisDonus)Rezervasyon;
               temp += "Tam Bilet\nBilet No:" + this.BiletNo + "\n" + gd.RezervasyonBilgiGoster();
           }
           else if (Rezervasyon is Gidis)
           {
               Gidis g = (Gidis)Rezervasyon;
               temp += "Tam Bilet\nBilet No:" + this.BiletNo + "\n" + g.RezervasyonBilgiGoster();
           }
           return temp;
       }

    }
}
