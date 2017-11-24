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
        public string NomClient { get; set; }
        public DateTime Date { get; set; }
      

        public Facture(string Numero, string NomClient, DateTime Date)
        {
            this.Numero = Numero;
            this.NomClient = NomClient;
            this.Date = Date;
           
        }

        public Facture()
        {
            this.Numero = "";
            this.NomClient = "";
            this.Date = DateTime.Now;
        }

       
    }
}
