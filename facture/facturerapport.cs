using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Collections.Generic;

namespace facture
{
    public partial class facturerapport : DevExpress.XtraReports.UI.XtraReport
    {
        public facturerapport()
        {
            InitializeComponent();
        }
        public void intdata(string x,DateTime y,int n,List<DAL.Repport> dt)
        {
            Nomclient.Value = x;
            date.Value = y;
            Numero.Value = n;
            objectDataSource1.DataSource = dt;
        }
    }
}
