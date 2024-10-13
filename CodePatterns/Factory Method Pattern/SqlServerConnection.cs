using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.Common;


namespace CodePatterns.Factory_Method_Pattern
{
    public class SqlServerConnection : IDatabaseConnection
    {
        public void Connect()
        {
            //Code to connect to SQL Server
        }

       
    }
}
