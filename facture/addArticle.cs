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
    public partial class addArticle : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CrudFacture c;
        public float montant = 0;
        public DataTable dt;
        public DataRow ligne;
        public addArticle(CrudFacture c1)
        {
            InitializeComponent();
            c = c1;
            DataTable dt2 = DAL.DAL.GetAllRef();

            foreach (DataRow row in dt2.Rows)
            {

                Ref.Items.Add(row[0].ToString());

            }
          
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable t = new DataTable();
            if (Qte.Text != "0")
            {
                t = DAL.DAL.GetAllRefbyid(Ref.Text);
                if (DAL.DAL.getQte(Ref.Text) >= Int32.Parse(Qte.Text))
                {
                    ligne = c.dt.NewRow();
                    ligne["Reference"] = Ref.Text;
                    ligne["Designation"] = t.Rows[0][2].ToString();
                    ligne["Prix_unitaire"] = t.Rows[0][3].ToString();
                    ligne["Quantite"] = Qte.Text;
                    ligne["Montant"] = float.Parse(t.Rows[0][3].ToString()) * int.Parse(Qte.Text);
                    c.dt.Rows.Add(ligne);

                    montant = montant + float.Parse(t.Rows[0][3].ToString()) * int.Parse(Qte.Text);

                    int oldQte = DAL.DAL.getQte(Ref.Text);
                    DAL.DAL.UpdateQte(Ref.Text, oldQte - Int32.Parse(Qte.Text));
                    c.gridControl1.DataSource = c.dt;


                }
                else
                {
                    XtraMessageBox.Show("choisie un montant mois de " + DAL.DAL.getQte(Ref.Text));
                }
                this.Close();
            }

      

        }

        private void Ref_TextChanged(object sender, EventArgs e)
        {
           
            Qte.Text = DAL.DAL.getQte(Ref.Text).ToString();
            string[] a = DAL.DAL.getDesigPrix(Ref.Text);
            Des.Text = a[0];
            Prix.Text = a[1];
            if (Qte.Text == "0")
            {
                Des.ReadOnly = true;
                Qte.ReadOnly = true;
                Prix.ReadOnly = true;
             
            }

        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
