using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public class Rezervasyon
    {
        public int YolcuSayi { get; set; }
        public Odeme Odeme { get; set; }
        public Hat Hat { get; set; }
        public decimal Ucret { get; set; }
        public Rezervasyon()
        {
            Hat = new Hat();         
        }
        //Virtual tipinde Rezervasyon Ucretini Hesaplayan metod. (Çok biçimlilik-polymorphosim)
        public virtual decimal UcretHesapla()
        {
            this.Ucret = (decimal)this.YolcuSayi * this.Hat.Fiyat;
            return Ucret;
        }
        //Virtual tipinde Rezervasyon Ucretini Gösteren bir fonksiyon. (Çok biçimlilik-polymorphosim)
        public virtual string UcretGoster()
        {
            return "";
        }

        //Virtual tipinde Rezervasyon bilgisini gösteren metod.  (Çok biçimlilik-polymorphosim)
        public virtual string RezervasyonBilgiGoster()
        {
            string temp = "";
            //Ödeme değişkenine atılan sınıf bir alt sınıflarından hangisiyse ona göre işlem yapılır. 
            Hatlar hatlar=new Hatlar();           
            temp +=  "Hat Bilgileri:\n" + hatlar.SeferBilgiGoster(Hat.No);
            if(Odeme is KrediKart)
            {
                KrediKart kk = (KrediKart)Odeme;
                temp += kk.OdemeBilgiGoster();
            }
            else if(Odeme is Havale)
            {
                Havale havale = (Havale)Odeme;
                temp += havale.OdemeBilgiGoster();
            }
            return temp;
        }      
     }
 }
