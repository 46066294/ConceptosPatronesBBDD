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
    public static class Bd
    {
        public static int Execute(String sql)
        {

            if (String.IsNullOrEmpty(sql))
            {
                throw new ArgumentNullException("sql");
            }

            using (var connection = CreateConnectionDB.GetConnection())
            using (var command = CreateConnectionDB.GetCommand())
            {
                connection.Open();

                command.CommandText = sql;
                command.Connection = connection;
                return command.ExecuteNonQuery();
            }
            //Console.WriteLine("Conectado");
            //connection.Close();
        }
    }
}
