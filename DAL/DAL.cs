using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace DAL
{
    public class DAL
    {
        public static int Insert(Article a)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "Insert into Article(Reference,Designation,Prix_unitaire,Quantite,status) values(?,?,?,?,1)";
            SqlCeCommand cmd = new SqlCeCommand(cm,cnn);
            cmd.Parameters.AddWithValue("Reference",a.Reference);
            cmd.Parameters.AddWithValue("Designation", a.Disignation);
            cmd.Parameters.AddWithValue("Prix_unitaire", a.PrixU);
            cmd.Parameters.AddWithValue("Quantite", a.Qte2);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
      
        public static int Update1(Article e,string txt)
        { 
         
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "update [article] set reference='"+ e.Reference + "',Designation=?,Prix_unitaire=?,Quantite=? where Reference=?";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
          
            cmd.Parameters.AddWithValue("Disignation", e.Disignation);
            cmd.Parameters.AddWithValue("PrixUnitaire", e.PrixU);
            cmd.Parameters.AddWithValue("qte", e.Qte2);
            cmd.Parameters.AddWithValue("Ref", txt);



            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }


        public static int Updatestate( string txt)
        {
          
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "update [article] set status=0 where Reference=?";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);


            cmd.Parameters.AddWithValue("Ref", txt);



            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }


        public static int UpdateQte(string Ref, int txt)
        {
          
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "update [article] set Quantite="+ txt +"where Reference=?";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            cmd.Parameters.AddWithValue("Ref", Ref);



            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }


        public static int Delete(string rf)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm="delete from Article where reference='"+rf+"'";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
        public static DataTable SelectByRf(string rf)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Reference='"+rf+"'";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }



        public static DataTable SelectByDes(string des)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Designation='" + des + "'";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public static DataTable SelectByPrix(float prix)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Prix_unitaire=" + prix + "";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable SelectByPrixAndQte(float prix,int qte)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Prix_unitaire=" + prix +"and Quantite="+qte+"";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public static DataTable SelectByQuantite(int quantite)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Quantite=" + quantite +"";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public static DataTable SelectAll()
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where status=1";
            SqlCeCommand cmd = new SqlCeCommand(cm,cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); ;
            cnn.Close();
            return dt;
        }
        public static int getId(string rf)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Id from Article where Reference='"+rf+"'";
            SqlCeCommand cmd = new SqlCeCommand(cm,cnn);
            int i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }
        public static DataTable ChercherRef(string Ref)
        {
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Reference,Designation,Prix_unitaire from Article where Reference='" + Ref + "'";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;

        }
        public static DataTable Getarticle(string r)
        {
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select * from Article where status=1 and  Reference='" + r + "' ";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

           

            connection.Close();
            return dt;

        }
        public static int Getref(string r)
        {
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select count(*) from Article where Reference = '" + r + "'";

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            int i = (int)cmd.ExecuteScalar();

            connection.Close();
            return i;
        }
        public static int count(string Reference)
        {

            string cm;

            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            cm = "SELECT COUNT(*) FROM Article where Reference= '" + Reference + "'";
            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            return (int)cmd.ExecuteScalar();

        }
        public static DataTable GetAllRef()
        {
           
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select Reference from Article where status=1 ";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            connection.Close();
            return dt;
        }


        public static DataTable GetAllNum()
        {

            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select Numero from Facture ";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            connection.Close();
            return dt;
        }

        public static DataTable GetAllRefbyid(string refs)
        {
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select * from Article where Reference='" + refs + "'";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            connection.Close();
            return dt;
        }
        public static int getQte(string refs)
        {
            int qte=0;
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select Quantite  from Article where Reference='" + refs + "'";
            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                qte = Int32.Parse( dr[0].ToString());
            }
            return qte;
        }
        public static string[] getDesigPrix(string refs)
        {
            string Desig = "";
            string Pu = "";
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Designation,Prix_unitaire from Article where  Reference='" + refs + "' ";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
           SqlCeDataReader dr= cmd.ExecuteReader();
            while(dr.Read())
            {
                Desig = dr[0].ToString();
                Pu = dr[1].ToString();
            }
            return new string[] { Desig, Pu };
        }







        public static string[] getRefPrix(string Des)
        {
            string Desig = "";
            string Pu = "";
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Reference,Prix_unitaire from Article where  Designation='" + Des + "' ";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Desig = dr[0].ToString();
                Pu = dr[1].ToString();
            }
            return new string[] { Desig, Pu };
        }
        public static string[]getRefeDes(int pu)
        {
            string Refs = "";
            string Des = "";
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Reference,Designation from Article where Prix_unitaire='" + pu + "' ";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
            SqlCeDataReader dr = cmd.ExecuteReader();
            //cn.Close();
            while(dr.Read())
            {
                Refs = dr[0].ToString();
                Des = dr[1].ToString();
            }
            return new string[] { Refs, Des };
        }
        public static int Insert(Facture e)
        {
            int i;
            string cm;

            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            cm = "insert into Facture(Numero,Nom_Client,Date) Values (?,?,?)";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);

            cmd.Parameters.AddWithValue("Numero", e.Numero);
            cmd.Parameters.AddWithValue("Nom_Client", e.NomClient);
            cmd.Parameters.AddWithValue("Date", e.Date);
            i=cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT @@IDENTITY";

            i = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();
            return i;


        }


        public static int InsertF(LigneFactuer l)
        {
            int i;
            string cm;

            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            cm = "insert into F(IdFacture,IdArticle,Quantite,Montant) Values (?,?,?,?)";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);

            cmd.Parameters.AddWithValue("fact", l.IdFacture);
            cmd.Parameters.AddWithValue("article", l.IdArticle);
            cmd.Parameters.AddWithValue("qte", l.Quantite);
            cmd.Parameters.AddWithValue("Montant", l.Montant);
            i = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT @@IDENTITY";

            i = Convert.ToInt32(cmd.ExecuteScalar());
            
            connection.Close();
            return i;


        }




        public static int getid(string refs)
        {
            int id = 0;
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select Id  from Article where Reference='" + refs + "'";
            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Int32.Parse(dr[0].ToString());
            }
            return id;
        }
        public static int getFactuerid(string numm)
        {
            int id = 0;
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select Id  from Facture where Numero='" + numm + "'";
            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Int32.Parse(dr[0].ToString());
            }
            return id;
        }


        public static DataTable SelectFacture()
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Numero,Nom_Client,Date from Facture";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteReader();
            cnn.Close();
            return dt;
        }

        public static DataTable SelectFacturebyBumeroClient(string num)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Numero,Nom_Client,Date from Facture where Nom_Client='" + num+"'";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteReader();
            cnn.Close();
            return dt;
        }


        public static DataTable SelectF(int id)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select F.Quantite,F.Montant,Article.Reference,Article.Designation,Article.Prix_unitaire from F,Article,Facture where F.IdFacture=Facture.Id and Article.Id=F.IdArticle and Facture.Id = " + id+"";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteReader();
            cnn.Close();
            return dt;
        }

        public static List<Repport> SelectFactuerforrapport(int id)
        {
            List<Repport> fl = new List<Repport>();
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select F.Quantite,F.Montant,Article.Prix_unitaire from F,Article,Facture where F.IdFacture=Facture.Id and Article.Id=F.IdArticle and Facture.Id = " + id + "";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteReader();
            cnn.Close();
            foreach (DataRow row in dt.Rows)
            {
                Repport f = new Repport(Int32.Parse (row[0].ToString()),Int32.Parse( row[2].ToString()),Int32.Parse (row[1].ToString()));
               
                fl.Add(f);
            }
            return fl;
        }

        public static int DeleteLigneFacture(int id)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "delete from F where IdFacture=" + id + "";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }




        public static int UpdateFacture(Facture a,int Num)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "update Facture set Numero=?,Nom_Client=?,Date=? where Id="+ Num + "";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            cmd.Parameters.AddWithValue("Numero", a.Numero);
            cmd.Parameters.AddWithValue("Nom_Client", a.NomClient);
            cmd.Parameters.AddWithValue("Date", a.Date);
           // cmd.Parameters.AddWithValue("Numero", a.Numero);
           
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }



        public static int DeleteFacture(string Num)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "delete from Facture where Numero='" + Num + "'";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
        public static string[] getNomDate(string Num)
        {
            string NomClient = "";
            string Date = "";
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Nom_Client,Date from Facture where  Numero='" + Num + "' ";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NomClient = dr[0].ToString();
                Date = dr[1].ToString();
            }
            return new string[] { NomClient, Date };
        }
        public static string[] getNumDate(string Nom)
        {
            string Num = "";
            string Date = "";
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Numero,Date from Facture where  Nom_Client='" + Nom + "' ";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Num = dr[0].ToString();
                Date = dr[1].ToString();
            }
            return new string[] { Num, Date };
        }
        public static DataTable SelectNum(string rf)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Numero,Nom_Client,Date from Facture where Numero='" + rf + "'";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

    }
}
