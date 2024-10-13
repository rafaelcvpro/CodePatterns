using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Factory_Method_Pattern
{
    public class MySqlFactory : DatabaseFactory
    {
        public override IDatabaseConnection CreateConnection()
        {
            return new MySqlServerConneciton(); 
        }
    }
}
