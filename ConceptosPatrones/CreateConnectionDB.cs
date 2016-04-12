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
        public static DbConnection GetConnection()
        {   //Se está incumpliendo el principio SOLID - D
            if(Config.Instance.ConnectionType == ConnectionType.Sql)
            {
                return new SqlConnection(Config.Instance.ConnectionString);
            }
            return new OdbcConnection();

            //Documentación: https://www.connectionstrings.com/sql-server/
        }

        public static DbCommand GetCommand()
        {
            if (Config.Instance.ConnectionType == ConnectionType.Sql)
            {
                return new SqlCommand();
                
            }
            return new OdbcCommand();
        }
    }
}
