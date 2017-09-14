using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{

    public class Hatlar
    {
        //Hat listelerini tutan liste
        public List<Hat> HatList { get; set; }
        private Hat Hat { get; set; }
        public Hatlar()
        {

            Hat = new Hat();
            HatList = new List<Hat> 
            { 
             new Hat(){No=1,Sefer="İstanbul-İzmir", Fiyat=65,},
             new Hat(){No=2,Sefer="İstanbul-Ankara",Fiyat=50},
             new Hat(){No=3,Sefer="İstanbul-Manisa",Fiyat=65},
             new Hat(){No=4,Sefer="İstanbul-Erzurum",Fiyat=260},
             new Hat(){No=5,Sefer="İstanbul-Trabzon",Fiyat=200}            
            };
         
        }
        //Hat Ekleme metodu. Hat tipinde hat alıyor ve seferlere ekliyor.
        public void Ekle(Hat hat)
        {
            HatList.Add(hat);
        }
        //Kayıtlı olan sefer bulma işlemleri.
        public Hat SeferBul(int no)
        {           
            foreach (var eleman in HatList)
            {
                Hat = HatList.Where(x => x.No == no).FirstOrDefault();
            }
            return Hat;
        }
        //
        public string SeferBilgiGoster(int no)
        {
            string temp = "";
            foreach (var eleman in HatList)
            {
                if (eleman.No == no)
                    temp += "Hat No: " + eleman.No + "\nHat Seferi: " + eleman.Sefer + "\nHat Fiyat: " + eleman.Fiyat;
            }
            return temp;
        }

        
    }
}
