using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public class Yolcular
    {
        //Bütün yolcuları ve biletlerini tutan liste
        public List<Yolcu> YolcuListe { get; set; }
        //Yolcu nesnesi
        public Yolcu Yolcu { get; set; }

        public Yolcular()
        {
            YolcuListe = new List<Yolcu>();
            Yolcu = new Yolcu();
        }
        //YolcuListe'sine yolcu nesnesini ekleyen metot.
        public void Ekle(Yolcu yolcu)
        {
            YolcuListe.Add(yolcu);          
                    
        }
        //Tüm Yolcuların Kisisel bilgilerini ve biletlerini gösteren metot
        public string BilgiGöster()
        {
            string temp = "";
            foreach (var yolcu in YolcuListe)
            {
                if (yolcu.TCKN == Yolcu.TCKN)
                    temp = "TC Kimlik No:" + yolcu.TCKN + "\nYolcunun Adı:" + yolcu.Ad + "\nYolcunun Soyadı:" + yolcu.Soyad + yolcu.BilgiGoster();
            }
            return temp;
        }       


    }
}
