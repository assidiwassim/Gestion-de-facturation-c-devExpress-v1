using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;

namespace facture
{
    public partial class CrudFacture : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form1 f3;
       public DataTable dt;

        string val;
        int idfact;
        public CrudFacture(Form1 f1 ,int x,string value)
        {
         
            InitializeComponent();
            f3 = f1;
            val = value;
            dt = new DataTable();
            idfact = x;
           
        
            dt = DAL.DAL.SelectF(x);
            gridControl1.DataSource = dt;
          


        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
            if (val == "-1")
            {
                DAL.Facture f = new DAL.Facture(num.Text, NomC.Text, DateTime.Parse(Date.Text));
                int id = DAL.DAL.Insert(f);


                foreach (DataRow row in dt.Rows)
                {

                    int idatricle = DAL.DAL.getId(Convert.ToString(row[2]));

                    DAL.LigneFactuer f2 = new DAL.LigneFactuer(id, idatricle, Int32.Parse(Convert.ToString(row[0])), float.Parse(Convert.ToString(row[1])));
                    DAL.DAL.InsertF(f2);
                  
                }
                f3.gridControl2.DataSource = DAL.DAL.SelectFacture();
                XtraMessageBox.Show("Enregistrer avec succès");
          
            }
            else
            { 
                
                    //int id = DAL.DAL.getFactuerid(idfact);

                    DAL.DAL.DeleteLigneFacture(idfact);
                    DAL.DAL.UpdateFacture(new DAL.Facture(num.Text, NomC.Text, DateTime.Parse(Date.Text)), idfact);
                /*    foreach (DataRow row in dt.Rows)
                    {

                        int idatricle = DAL.DAL.getId(Convert.ToString(row[2]));

                        DAL.LigneFactuer f2 = new DAL.LigneFactuer(idfact, idatricle, Int32.Parse(Convert.ToString(row[0])), float.Parse(Convert.ToString(row[1])));
                        DAL.DAL.InsertF(f2);

                    }
                    f3.gridControl2.DataSource = DAL.DAL.SelectFacture();
                    XtraMessageBox.Show("Modifier avec succès"); */
                if (gridView1.RowCount > 0)
                {
               
                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        DataRow row = gridView1.GetDataRow(i);

                        int idatricle = DAL.DAL.getId(Convert.ToString(row[2]));

                        DAL.LigneFactuer f2 = new DAL.LigneFactuer(idfact, idatricle, Int32.Parse(Convert.ToString(row[0])), float.Parse(Convert.ToString(row[1])));
                        DAL.DAL.InsertF(f2);
                        

                    }
                }
                f3.gridControl2.DataSource = DAL.DAL.SelectFacture();
                XtraMessageBox.Show("Modifier avec succès");



            }
            
           
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            addArticle a = new addArticle(this);
            a.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                int oldQte = DAL.DAL.getQte(Convert.ToString(row[2]));
                int newQte = oldQte + Int32.Parse(Convert.ToString(row[0]));
                DAL.DAL.UpdateQte(Convert.ToString(row[2]), newQte);
                row.Delete();

            }
        }

		
	}
}
