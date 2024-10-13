using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Observer_Pattern
{
    // Defines an Update method that observers must implement.
    public interface IObserver
    {
        void Update();
    }
}
