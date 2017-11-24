using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Repport
    {
        public int Quantite { get; set; }
        public int prix { get; set; }
        public int montant { get; set; }
      public Repport(int qte, int p,int mon)
        {
            Quantite = qte;
            prix = p;
            montant = mon;
        }
    }
}
