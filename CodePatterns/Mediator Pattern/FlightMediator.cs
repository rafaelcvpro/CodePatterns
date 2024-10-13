using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Mediator_Pattern
{
    public class FlightMediator 
    {
        private Engine _engine;
        private Aviation _aviation;
        private Wheels _wheels;
        private Cockpit _cockpit;

        public FlightMediator(Engine engine, Aviation aviation, Wheels wheels, Cockpit cockpit)
        {
            _engine = engine;
            _aviation = aviation;
            _wheels = wheels;
            _cockpit = cockpit;
        }
    }
}
