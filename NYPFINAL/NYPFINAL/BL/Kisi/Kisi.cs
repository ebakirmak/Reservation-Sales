using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public abstract class Kisi
    {
        private string tckn;
        public string TCKN
        {
            get { return tckn; }
            set { tckn = value; }
        }        
        public string Ad { get; set; }
        public string Soyad { get; set; }     
      
        //Yeniden kullanılabilir bir virtual metot oluşturduk.
        public virtual string BilgiGoster()
        {
            return "TC Kimlik Numarası:" + TCKN + "\nKişinin Adı:" + Ad + "\nKişinin Soyadı:" + Soyad;
        }

    }

   
}
