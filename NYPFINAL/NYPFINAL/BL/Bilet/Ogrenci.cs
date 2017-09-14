using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{

    public class Ogrenci:Bilet
    {
        //Öğrenci tipindeki bilet için indirim oranı
        public const decimal INDIRIMORANI=0.4M;
        //Parametre alan constroctor
        public Ogrenci(int biletNo)
        {
            this.BiletNo = biletNo;           
        } 
        //Bilet sınıfındaki BiletBilgi metodunu ezdik
        public override string BiletBilgi()
        {
            string temp = "";
            if (Rezervasyon is GidisDonus)
            {
                GidisDonus gd = (GidisDonus)Rezervasyon;
                temp += "Öğrenci Bilet\nBilet No:" + this.BiletNo + "\n" + gd.RezervasyonBilgiGoster();
            }
            else if(Rezervasyon is Gidis)
            {
                Gidis g = (Gidis)Rezervasyon;
                temp += "Öğrenci Bilet No:" + this.BiletNo + "\n" + g.RezervasyonBilgiGoster();
            }
            return temp;
                                                                                                                                                                                                                                               }
        //Bilet sınıfındaki BiletHesapla metodunu ezdik
        public override decimal BiletHesapla(decimal ucret)
        {
            this.Ucret = ucret - (ucret*INDIRIMORANI);
            return ucret;
        }    
    }
}
