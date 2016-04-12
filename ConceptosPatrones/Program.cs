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
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = CreateConnectionDB.GetConnection(Config.Instance.ConnectionType))
            {
                connection.Open();
                //using (var command = new SqlCommand())
                //{
                //    command.CommandText = "insert into [table](Name) values('Xavi')";
                //    command.Connection = connection as SqlConnection;
                //    command.ExecuteNonQuery();
                //}
                Console.WriteLine("...conectado");
                connection.Close();
            }
            //https://www.connectionstrings.com/sql-server/
            //nombre del servidor (LocalDb)\v11.0

        }
    }
}
