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
    public enum ConnectionType
    {
        Sql,
        Odbc
    }
}
