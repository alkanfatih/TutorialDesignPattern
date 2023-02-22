using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverDesignPattern.LAB_1
{
    public class SubjectSubscriber : IObserver
    {
        private string name;
        private ISubject topic;
        public SubjectSubscriber(string nm)
        {
            this.name = nm;
        }
        public void setSubject(ISubject sub)
        {
            this.topic = sub;
        }

        public void update()
        {
            string msg = (string)topic.getUpdate(this);
            if (msg == null) 
            {
                Console.WriteLine(name + ":: No new message");
            }
            else
            {
                Console.WriteLine(name + ":: Consuming message::" + msg);
            }
        }
    }
}
