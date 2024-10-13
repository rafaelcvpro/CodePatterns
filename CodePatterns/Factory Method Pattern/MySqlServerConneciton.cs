using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Factory_Method_Pattern
{
    public class MySqlServerConneciton : IDatabaseConnection
    {
        public void Connect()
        {
            //Code to Connect to MySqlServer
        }

        
    }
}
