using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Observer_Pattern
{
    //Maintains a list of observers and notifies them of any state changes.
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int state;
        public int State
        {
            get { return state; }
            set
            {
                state = value;
                NotifyAllObservers();
            }
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void NotifyAllObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
