using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Mediator_Pattern
{
    public class Aviation
    {
        private int _FuelLevel = 1000; 
        public bool IsReady()
        {
            return _FuelLevel > 5000; 
        }
    }
}
