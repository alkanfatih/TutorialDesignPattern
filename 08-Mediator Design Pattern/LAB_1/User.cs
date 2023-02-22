using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mediator_Design_Pattern.LAB_1
{
    public abstract class User
    {
        protected IChatMediator mediator;
        protected string name;

        public User(IChatMediator med, string name)
        {
            this.mediator = med;
            this.name = name;
        }

        public abstract void send(String msg);
        public abstract void receive(String msg);
    }
}
