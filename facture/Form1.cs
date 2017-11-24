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
using DevExpress.XtraGrid.Views.Grid;

namespace facture
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            DataTable dt = DAL.DAL.GetAllRef();

            foreach (DataRow row in dt.Rows)
            {

                Ref.Items.Add(row[0].ToString());

            }
            DataTable dt2 = DAL.DAL.GetAllNum();
            foreach (DataRow row in dt2.Rows)
            {

                Num.Items.Add(row[0].ToString());

            }


            gridControl1.DataSource = DAL.DAL.SelectAll();
            gridControl2.DataSource = DAL.DAL.SelectFacture();

        }

        //c bon
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        //c  bon
        private void simpleButton10_Click(object sender, EventArgs e)
        {
            CrudFacture f = new CrudFacture(this, 0, "-1");
            f.Show();
        }

        //c bon
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CrudArticle c = new CrudArticle(this, "");

            c.Show();
            CrudArticle.value = 1;
        }

        //c bon
        private void simpleButton2_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridView1.RowCount > 0)
                {
                    //MessageBox.Show("Test"+ gridView1.GetSelectedRows().GetValue(1).ToString());
                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        CrudArticle c = new CrudArticle(this, Convert.ToString(row[0]));
                        c.Ref.Text = Convert.ToString(row[0]);
                        c.Desi.Text = Convert.ToString(row[1]);
                        c.Prix.Text = Convert.ToString(row[2]);
                        c.Qte.Text = Convert.ToString(row[3]);
                        CrudArticle.value = 2;
                        CrudArticle.x = Convert.ToString(row[0]);

                        c.Show();

                    }
                }
                else
                    XtraMessageBox.Show("Selectioner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur:" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        //c bon
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Voulez vous Supprimer  ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)

            { 
                try
                {
                    if (gridView1.RowCount > 0)
                    {

                        foreach (int i in gridView1.GetSelectedRows())
                        {
                            DataRow row = gridView1.GetDataRow(i);
                            DAL.DAL.Delete(Convert.ToString(row[0]));
                            gridControl1.DataSource = DAL.DAL.SelectAll();

                        }
                    }
                    else
                        XtraMessageBox.Show("Selectioner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erreur:" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
    }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
        }


        // c bon
        private void simpleButton9_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (gridView2.RowCount > 0)
                {
                    //MessageBox.Show("Test"+ gridView1.GetSelectedRows().GetValue(1).ToString());
                    foreach (int i in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        int x = DAL.DAL.getFactuerid(Convert.ToString(row[0]));
                        
                        string l = Convert.ToString(row[0]);
                    
                        CrudFacture f = new CrudFacture(this, x, Convert.ToString(row[0]));
                        f.num.Text = Convert.ToString(row[0]);
                        f.NomC.Text = Convert.ToString(row[1]);
                        f.Date.Text = Convert.ToString(row[2]);

               
                   
                        f.Show();

                    }
                }
                else
                    XtraMessageBox.Show("Selectioner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erreur:" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




           
        }
        //c bon
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Voulez vous Supprimer  ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)

            {
                try
                {
                    if (gridView2.RowCount > 0)
                    {

                        foreach (int i in gridView2.GetSelectedRows())
                        {
                            DataRow row = gridView2.GetDataRow(i);
                            DAL.DAL.DeleteFacture(Convert.ToString(row[0]));
                            gridControl2.DataSource = DAL.DAL.SelectFacture();

                        }
                    }
                    else
                        XtraMessageBox.Show("Selectioner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erreur:" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        //c bon
        private void simpleButton5_Click(object sender, EventArgs e)
        {
          
            if (Ref.Text != "")
            {
                if (DAL.DAL.SelectByRf(Ref.Text).Rows.Count > 0)
                {
                    gridControl1.DataSource = DAL.DAL.SelectByRf(Ref.Text);
                }
                else
                {
                    XtraMessageBox.Show("Element introuvable", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Ref.Text = "";
                }
            }
            else
            {
               if((Qte.Text!="") && (prix.Text != ""))
                {
                    gridControl1.DataSource = DAL.DAL.SelectByPrixAndQte(float.Parse(prix.Text), Int32.Parse(Qte.Text));
                }

               else if ((Qte.Text != "")&&(prix.Text==""))
                {
                    gridControl1.DataSource = DAL.DAL.SelectByQuantite(Int32.Parse(Qte.Text));
                }
                else if ((Qte.Text == "") && (prix.Text != ""))
                {
                    gridControl1.DataSource = DAL.DAL.SelectByPrix(float.Parse(prix.Text));
                }
               else
                {
                    gridControl1.DataSource = DAL.DAL.SelectAll();
                }
            }
        
    }
        //c bon
        private void Ref_TextChanged_1(object sender, EventArgs e)
        {
            Qte.Text = DAL.DAL.getQte(Ref.Text).ToString();
            string[] a = DAL.DAL.getDesigPrix(Ref.Text);

            prix.Text = a[1];
            

        }

        //c bon
        private void prix_KeyPress(object sender, KeyPressEventArgs e)
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
        

        //c bon
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (Num.Text != "")
            {
                if (DAL.DAL.SelectNum(Num.Text).Rows.Count > 0)
                {
                    gridControl2.DataSource = DAL.DAL.SelectNum(Num.Text);
                }
                else
                {
                    XtraMessageBox.Show("Element introuvable", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Num.Text = "";
                }
            }
            else
            {
                if ((NomC.Text != "") && (Date.Text != ""))
                {
                    gridControl2.DataSource = DAL.DAL.SelectFacturebyBumeroClient(NomC.Text);
                }

                else if ((NomC.Text != "") && (Date.Text == ""))
                {
                    gridControl2.DataSource = DAL.DAL.SelectFacturebyBumeroClient(NomC.Text);
                }
                else if ((NomC.Text == "") && (Date.Text != ""))
                {
                    gridControl2.DataSource = DAL.DAL.SelectFacturebyBumeroClient(NomC.Text);
                }
                else
                {
                    gridControl2.DataSource = DAL.DAL.SelectFacture();
                }
            }
        }

        // c bon
        private void Num_TextChanged(object sender, EventArgs e)
        {
            string[] a = DAL.DAL.getNomDate(Num.Text);
            NomC.Text = a[0];
            Date.Text = a[1];
        }


        //facture report
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            using (factureR f = new factureR())
            {
               
                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    List<DAL.Repport> list = DAL.DAL.SelectFactuerforrapport(DAL.DAL.getFactuerid(Convert.ToString(row[0])));


                    f.print(Convert.ToString(row[1]),DateTime.Parse(Convert.ToString(row[2])), DAL.DAL.getFactuerid(Convert.ToString(row[0])),list);

                }
              
                f.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ref_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}