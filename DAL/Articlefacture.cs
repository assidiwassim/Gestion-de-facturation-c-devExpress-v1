using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class Articlefacture
    {

       
        public string Reference { get; set; }
        public string Designation { get; set; }
        public float PrixUnitaire { get; set; }
        public int Quantite { get; set; }
        public float Montant { get; set; }


        public Articlefacture( string Reference, string designation, float PrixUnitaire, int Quantite, float Montant)
        {
          
            this.Reference = Reference;
            this.Designation = designation;
            this.PrixUnitaire = PrixUnitaire;
            this.Quantite = Quantite;
            this.Montant = Montant;

        }
    }
}
