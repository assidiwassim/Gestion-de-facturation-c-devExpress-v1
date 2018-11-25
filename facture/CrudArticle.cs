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
using DAL;

namespace facture
{
    
    public partial class CrudArticle : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static int value = 0;
        public  static string x;
        public static Form1 f1;
        public static string id;
        public CrudArticle(Form1 f ,string l)
        {
            InitializeComponent();
            f1 = f;
            id = l;
          

        }

      
      
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (value == 1)
            {
                
                try
                {
                    DAL.Article a = new Article(Ref.Text, Desi.Text, float.Parse(Prix.Text), Int32.Parse(Qte.Text));
                    DAL.DAL.Insert_Article(a);

                    XtraMessageBox.Show("Enregistrer avec succès");
                    f1.gridControl1.DataSource = DAL.DAL.SelectAll();
                    Ref.Text = "";
                    Desi.Text = "";
                    Prix.Text = "";
                    Qte.Text = "";
					this.Close();
				}
                catch(Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                
                try
                {
                    DAL.Article a = new Article(Ref.Text, Desi.Text, float.Parse(Prix.Text), Int32.Parse(Qte.Text));
                    DAL.DAL.Update1(a, id);
                    XtraMessageBox.Show("Modifier avec succès");
                    f1.gridControl1.DataSource = DAL.DAL.SelectAll();

                    Ref.Text = "";
                    Desi.Text = "";
                    Prix.Text = "";
                    Qte.Text = "";
                    this.Close();
                    
                }

                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
           
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (value == 1)
            {
                try
                {
                    DAL.Article a = new Article(Ref.Text, Desi.Text, float.Parse(Prix.Text), Int32.Parse(Qte.Text));
                    DAL.DAL.Insert_Article(a);
                    XtraMessageBox.Show("Enregistrer avec succès");
                    f1.gridControl1.DataSource = DAL.DAL.SelectAll();
                    Ref.Text = "";
                    Desi.Text = "";
                    Prix.Text = "";
                    Qte.Text = "";
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    DAL.Article a = new Article(Ref.Text, Desi.Text, float.Parse(Prix.Text), Int32.Parse(Qte.Text));

                    DAL.DAL.Update1(a, id);
                    XtraMessageBox.Show("Modifier avec succès");
                    f1.gridControl1.DataSource = DAL.DAL.SelectAll();
                    Ref.Text = "";
                    Desi.Text = "";
                    Prix.Text = "";
                    Qte.Text = "";
                    this.Close();
                }

                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (value == 1)
            {
                try
                {
                    DAL.Article a = new Article(Ref.Text, Desi.Text, float.Parse(Prix.Text), Int32.Parse(Qte.Text));
                    DAL.DAL.Insert_Article(a);
                    XtraMessageBox.Show("Enregistrer avec succès");
                    f1.gridControl1.DataSource = DAL.DAL.SelectAll();
                    Ref.Text = "";
                    Desi.Text = "";
                    Prix.Text = "";
                    Qte.Text = "";
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    DAL.Article a = new Article(Ref.Text, Desi.Text, float.Parse(Prix.Text), Int32.Parse(Qte.Text));

                    DAL.DAL.Update1(a, id);
                    XtraMessageBox.Show("Modifier avec succès");
                    f1.gridControl1.DataSource = DAL.DAL.SelectAll();
                    Ref.Text = "";
                    Desi.Text = "";
                    Prix.Text = "";
                    Qte.Text = "";
                    this.Close();

                }

                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Qte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CrudArticle_Load(object sender, EventArgs e)
        {

        }

		
	}
     
}
