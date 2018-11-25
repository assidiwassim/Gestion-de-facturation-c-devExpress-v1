using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;


namespace DAL
{
    public class DAL
    {
        public static int Insert_Article(Article a)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "Insert into Article(Reference,Designation,Prix_unitaire,Quantite,status) values(?,?,?,?,1)";
            SqlCeCommand cmd = new SqlCeCommand(cm,cnn);
            cmd.Parameters.AddWithValue("Reference",a.Reference);
            cmd.Parameters.AddWithValue("Designation", a.Designation);
            cmd.Parameters.AddWithValue("Prix_unitaire", a.Prix_unitaire);
            cmd.Parameters.AddWithValue("Quantite", a.Qantite);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
      
        public static int Update1(Article e,string reference)
        { 
         
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "update Article set reference='"+ e.Reference + "',Designation=?,Prix_unitaire=?,Quantite=? where Reference=?";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
          
            cmd.Parameters.AddWithValue("Disignation", e.Designation);
            cmd.Parameters.AddWithValue("PrixUnitaire", e.Prix_unitaire);
            cmd.Parameters.AddWithValue("qte", e.Qantite);
            cmd.Parameters.AddWithValue("Ref", reference);



            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }


        public static int Updatestate( string reference)
        {
          
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "update Article set status=0 where Reference=?";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);


            cmd.Parameters.AddWithValue("Ref", reference);



            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }


        public static int UpdateQte(string reference, int quantite)
        {
          
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "update Article set Quantite=" + quantite + "where Reference=?";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            cmd.Parameters.AddWithValue("Ref", reference);



            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i;
        }


        public static int Delete(string reference)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm= "delete from Article where reference='" + reference + "'";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
        public static DataTable SelectByRf(string reference)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Reference= '" + reference + "' and status=1";
            SqlCeCommand cmd = new SqlCeCommand(cm, cnn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }



        public static DataTable SelectByDes(string designation)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Designation= '" + designation + "' and status=1";
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
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Prix_unitaire=" + prix + " and status=1 ";
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
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Prix_unitaire="+ prix +" and Quantite="+qte+ " and status=1";
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
            string cm = "select Reference,Designation,Prix_unitaire,Quantite from Article where Quantite="+ quantite +" and status=1";
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
        public static int getId(string reference)
        {
            SqlCeConnection cnn = Connection.GetConnection();
            cnn.Open();
            string cm = "select Id from Article where Reference= '"+ reference + "' ";
            SqlCeCommand cmd = new SqlCeCommand(cm,cnn);
            int i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }
        public static DataTable ChercherRef(string reference)
        {
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Reference,Designation,Prix_unitaire from Article where Reference= '" + reference + "' and status=1";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;

        }
        public static DataTable Getarticle(string reference)
        {
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select * from Article where status=1 and  Reference= '" + reference + "' and status=1 ";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

           

            connection.Close();
            return dt;

        }
        public static int Getref(string reference)
        {
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select count(*) from Article where Reference = '" + reference + "' and status=1 ";

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
            cm = "SELECT COUNT(*) FROM Article where Reference= '" + Reference + "' and status=1 ";
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

        public static DataTable GetAllRefbyid(string reference)
        {
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select * from Article where Reference='" + reference + "'and status=1";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            connection.Close();
            return dt;
        }
        public static int getQte(string reference)
        {
            int qte=0;
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select Quantite  from Article where Reference= '" + reference + "' and status=1";
            SqlCeCommand cmd = new SqlCeCommand(cm, connection);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                qte = Int32.Parse( dr[0].ToString());
            }
            return qte;
        }
        public static string[] getDesigPrix(string reference)
        {
            string Desig = "";
            string Pu = "";
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Designation,Prix_unitaire from Article where  Reference= '" + reference + "' and status=1";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
           SqlCeDataReader dr= cmd.ExecuteReader();
            while(dr.Read())
            {
                Desig = dr[0].ToString();
                Pu = dr[1].ToString();
            }
            return new string[] { Desig, Pu };
        }







        public static string[] getRefPrix(string designation)
        {
            string Desig = "";
            string Pu = "";
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Reference,Prix_unitaire from Article where  Designation= '" + designation + "' and status = 1";
            SqlCeCommand cmd = new SqlCeCommand(Req, cn);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Desig = dr[0].ToString();
                Pu = dr[1].ToString();
            }
            return new string[] { Desig, Pu };
        }
        public static string[]getRefeDes(int Prix_unitaire)
        {
            string Refs = "";
            string Des = "";
            SqlCeConnection cn = Connection.GetConnection();
            cn.Open();
            string Req = "select Reference,Designation from Article where Prix_unitaire=" + Prix_unitaire + " and status=1";
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
        public static int Insert(Facture f)
        {
            int i;
            string cm;

            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            cm = "insert into Facture(Numero,Nom_Client,Date) Values (?,?,?)";
            SqlCeParameter pr = new SqlCeParameter();

            SqlCeCommand cmd = new SqlCeCommand(cm, connection);

            cmd.Parameters.AddWithValue("Numero", f.Numero);
            cmd.Parameters.AddWithValue("Nom_Client", f.Nom_Client);
            cmd.Parameters.AddWithValue("Date", f.Date);
            i=cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT @@IDENTITY";

            i = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();
            return i;


        }




		//optimisation

        public static int getid(string reference)
        {
            int id = 0;
            SqlCeConnection connection = Connection.GetConnection();
            connection.Open();
            string cm = "select Id  from Article where Reference= '" + reference + "' and status=1";
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
            string cm = "select F.Quantite,F.Montant,Article.Reference,Article.Designation,Article.Prix_unitaire from LigneFacture F,Article,Facture where F.IdFacture=Facture.Id and Article.Id=F.IdArticle and Facture.Id = " + id+"";
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
            string cm = "select F.Quantite,F.Montant,Article.Prix_unitaire from LigneFacture F,Article,Facture where F.IdFacture=Facture.Id and Article.Id=F.IdArticle and Facture.Id = " + id + "";
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
            string cm = "delete from LigneFacture where IdFacture=" + id + "";
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
            cmd.Parameters.AddWithValue("Nom_Client", a.Nom_Client);
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

		public static int InsertF(LigneFacture l)
		{
			int i;
			string cm;

			SqlCeConnection connection = Connection.GetConnection();
			connection.Open();
			cm = "insert into LigneFacture(IdFacture,IdArticle,Quantite,Montant) Values (?,?,?,?)";
			SqlCeParameter pr = new SqlCeParameter();

			SqlCeCommand cmd = new SqlCeCommand(cm, connection);

			cmd.Parameters.AddWithValue("IdFacture", l.IdFacture);
			cmd.Parameters.AddWithValue("IdArticle", l.IdArticle);
			cmd.Parameters.AddWithValue("Quantite", l.Quantite);
			cmd.Parameters.AddWithValue("Montant", l.Montant);
			i = cmd.ExecuteNonQuery();
			cmd.Parameters.Clear();
			cmd.CommandText = "SELECT @@IDENTITY";

			i = Convert.ToInt32(cmd.ExecuteScalar());

			connection.Close();
			return i;


		}

	}
}
