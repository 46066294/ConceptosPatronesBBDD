using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.Common;

namespace ConceptosPatrones
{
    //Factory
    public static class CreateConnectionDB
    {
        public static DbConnection GetConnection(ConnectionType connectionType)
        {
            if(connectionType == ConnectionType.Sql)
            {
                return new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=cursoC#;Integrated Security=True");
            }

            return new OdbcConnection();
        }
    }
}
