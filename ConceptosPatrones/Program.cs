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
            string comando = "insert into [table](Name) values('Marc')";
            Bd.Execute(comando);
            Console.WriteLine("...Execute(comando)::OK");
        }
    }
}
