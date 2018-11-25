using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Article
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public float Prix_unitaire { get; set; }
        public int Qantite { get; set; }

        public Article(string Reference, string Disignation, float PrixU, int qte2)
        {
            this.Reference = Reference;
            this.Designation = Disignation;
            this.Prix_unitaire = PrixU;
            this.Qantite = qte2;
        }

        public Article()
        {
            this.Reference = "";
            this.Designation = "";
            this.Prix_unitaire = float.NaN ;
            this.Qantite = 0;
        }



    }
}
