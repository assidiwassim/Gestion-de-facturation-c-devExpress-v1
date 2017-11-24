using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LigneFactuer
    {

        public int IdFacture { get; set; }
        public int IdArticle { get; set; }
        public int Quantite { get; set; }
        public float Montant { get; set; }

        public LigneFactuer(int Id_Facture, int Id_Article, int Quantite, float Montant)
        {
            this.IdArticle = Id_Article;
            this.IdFacture = Id_Facture;
            this.Quantite = Quantite;
            this.Montant = Montant;


        }
        public LigneFactuer()
        {

        }


    }
}
