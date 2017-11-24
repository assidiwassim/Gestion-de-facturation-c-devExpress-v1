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
        public string Disignation { get; set; }
        public float PrixU { get; set; }
        public int Qte2 { get; set; }

        public Article(string Reference, string Disignation, float PrixU, int qte2)
        {
            this.Reference = Reference;
            this.Disignation = Disignation;
            this.PrixU = PrixU;
            this.Qte2 = qte2;
        }

        public Article()
        {
            this.Reference = "";
            this.Disignation = "";
            this.PrixU = float.NaN ;
            this.Qte2 = 0;
        }



    }
}
