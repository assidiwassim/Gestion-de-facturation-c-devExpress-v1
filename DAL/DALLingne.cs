using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System. Data;
using System.Data.SqlServerCe;

namespace DAL
{
    public class DALLingne
    {
        public static int Insert(LigneFactuer l)
        {
            int i;
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();

            string cm = "insert into F (IdFacture,IdArticle,Quantite,Montant) Values (?,?,?,?)";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            cmd.Parameters.AddWithValue("IdFacture", l.IdFacture);

            cmd.Parameters.AddWithValue("IdArticle", l.IdArticle);
            cmd.Parameters.AddWithValue("Quantite", l.Quantite);
            cmd.Parameters.AddWithValue("Montant", l.Montant);
            i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;


        }
        public static DataTable getevrything()
        {
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select * from Facture where  ";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            connection.Close();
            return dt;
        }



    }
}
