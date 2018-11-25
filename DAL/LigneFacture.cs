using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LigneFacture
    {

        public int IdFacture { get; set; }
        public int IdArticle { get; set; }
        public int Quantite { get; set; }
        public float Montant { get; set; }

        public LigneFacture(int Id_Facture, int Id_Article, int Quantite, float Montant)
        {
            this.IdArticle = Id_Article;
            this.IdFacture = Id_Facture;
            this.Quantite = Quantite;
            this.Montant = Montant;


        }
        public LigneFacture()
        {

        }


    }
}
