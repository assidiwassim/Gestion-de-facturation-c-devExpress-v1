using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Facture
    {
       

        public string Numero { get; set; }
        public string Nom_Client { get; set; }
        public DateTime Date { get; set; }
      

        public Facture(string Numero, string NomClient, DateTime Date)
        {
            this.Numero = Numero;
            this.Nom_Client = NomClient;
            this.Date = Date;
           
        }

        public Facture()
        {
            this.Numero = "";
            this.Nom_Client = "";
            this.Date = DateTime.Now;
        }

       
    }
}
