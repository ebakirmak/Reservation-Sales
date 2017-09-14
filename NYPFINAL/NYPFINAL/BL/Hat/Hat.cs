using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFINAL
{
   public class Hat
    {
          
        public int No { get; set; }
        public string Sefer { get; set; }
        public decimal Fiyat { get; set; }

       //Constroctor
        public Hat()
        {
           
        }
       //Parametre alan constroctor
        public Hat(int rastgele)
        {
            this.No = rastgele;
        }
       
    }
}
