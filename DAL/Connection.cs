using System;
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
            return new SqlCeConnection(@"Data Source=Facture.sdf");
        }
    }
}