﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace DAL
{
    class Connection
    {
        public static SqlCeConnection GetConnection()
        {
            return new SqlCeConnection(@"Data Source=C:\Users\wassim\Documents\GitHub\Gestion-de-facturation-c-devExpress-v1\Facture.sdf");
        }
    }
}