using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverDesignPattern.LAB_1
{
    public class Subject : ISubject
    {
        private List<IObserver> observers;
        private String message;
        private bool changed;
        private Object MUTEX= new Object();
        public Subject()
        {
            observers = new List<IObserver>();
        }
        public object getUpdate(IObserver obj)
        {
            return this.message;
        }

        public void notifyObservers()
        {
            List<IObserver> observerslocal = null;
            //lock, mesaj alındıktan sonra kaydedilen herhangi bir gözlemcinin bilgilendirilmediğinden emin olmak için kullanılır.
            lock (MUTEX)
            {
                if (!changed)
                {
                    return;
                }
                observerslocal = new List<IObserver>(this.observers);
                this.changed = false;
            }
            foreach (IObserver obj in observerslocal)
            {
                obj.update();
            }

        }

        public void register(IObserver obj)
        {
            if (obj == null)
            {
                throw new Exception("Null Observer");
            }
            else
            {
                lock (MUTEX)
                {
                    if (!observers.Contains(obj))
                    {
                        observers.Add(obj);
                    }
                }
            }

        }

        public void unregister(IObserver obj)
        {
            lock (MUTEX)
            {
                observers.Remove(obj);
            }
        }

        //Konuya mesaj gönderme metodu
        public void postMessage(String msg)
        {
            Console.WriteLine("Message Posted to Topic:" + msg);
            this.message = msg;
            this.changed = true;
            notifyObservers();
        }
    }
}
