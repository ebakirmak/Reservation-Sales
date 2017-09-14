using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public class Yolcu:Kisi
    {
        //Yolcunun biletlerini tutmamızı sağlayan liste
        public List<Bilet> BiletList { get; set; }       
        //Puan Hesabı
        private decimal puan=0;
        public decimal Puan
        {
            get { return puan; }
            set { puan = value;}
        }        
        //constroctor
        public Yolcu()
        {
            
          
        }    

    //BiletList listesine bilet ekleme fonksiyonu
     public void BiletEkle(Bilet b)
       {
         
           BiletList.Add(b);
       }
    //Kisi sınıfından temel alınan BilgiGoster metodu
    public override string BilgiGoster()
    {
        string temp = base.BilgiGoster();
        foreach (var eleman in BiletList)
           {              
               temp +=  "\t\nYOLCUNUN BİLET BİLGİLERİ\n" +eleman.BiletBilgi();
           }
           return temp;
    }
    //Yolcunun puanına ödenilen bilet ücretine göre herseferinde arttırın metod
    public void PuanHesapla(decimal Ucret)
       {
           this.Puan += Ucret;
       }
    //Yolcunun Puanını string dönüş tipinde gösteren metod     
    public string PuanGoster()
      {
          return "Biriken Puan:" + this.puan.ToString();
      }
    //Yolcu puanını kullanmak istediğinde kullanılan metod
    public decimal PuanEksilt()
    {
        decimal puan = this.puan;
        this.Puan = 0;
        return puan;
    }

    }
}
