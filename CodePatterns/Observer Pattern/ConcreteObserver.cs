using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Observer_Pattern
{
    //  Implements the Update method to react to state changes in the subject
    public class ConcreteObserver : IObserver
    {
        private Subject subject;
        public ConcreteObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("State changed to: " + subject.State);
        }
    }
}
