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

namespace facture
{
    public partial class factureR : DevExpress.XtraEditors.XtraForm
    {
        public factureR()
        {
            InitializeComponent();
        }
        public void print(string nom , DateTime date, int id, List<DAL.Repport> dt)
        {
            facturerapport f = new facturerapport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in f.Parameters)
                p.Visible = false;
            f.intdata(nom, date, id,dt);
            documentViewer1.DocumentSource = f;
            f.CreateDocument();

        }
    }
}
