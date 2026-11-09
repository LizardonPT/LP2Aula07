using System;
using System.Collections.Generic;

namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private string item;
        public string Item
        {
            get =>item;
            protected set
            {
                item = value;
                NotifyObservers();
            }
        }
        
        private readonly ISet<IObserver<AbstractStringSubject>> observers;

        public AbstractStringSubject()
        {
            observers = new HashSet<IObserver<AbstractStringSubject>>();
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Remove(obs);
        }

        public void NotifyObservers()
        {
            foreach (IObserver<AbstractStringSubject> obs in observers)
            {
                obs.Update(this);
            }
        }
    }
}