using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodePatterns.Factory_Method_Pattern
{
    public abstract class DatabaseFactory
    {
        public abstract IDatabaseConnection CreateConnection();

    }
}
