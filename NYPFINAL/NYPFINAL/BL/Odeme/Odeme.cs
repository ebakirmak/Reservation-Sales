using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
    public abstract class Odeme
    {
        
        private decimal odenilen;
        public decimal Odenilen
        {
            get
            {                
                return odenilen;
            }
            set 
            {                 
                odenilen = value; 
            }
        }     
        //Kendisinden kalıtılan sınıflarda kullanılacak OdemeBilgiGoster metodu.
        public abstract string OdemeBilgiGoster();      
    }

 
}
