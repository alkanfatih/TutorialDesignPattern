using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mediator_Design_Pattern.LAB_1
{
    public class UserImpl : User
    {
        public UserImpl(IChatMediator med, string name):base(med, name)
        {
            
        }
        public override void send(string msg)
        {
            Console.WriteLine(this.name+": Sending Message: "+msg);
            mediator.sendMessage(msg, this);
        }

        public override void receive(string msg)
        {
            Console.WriteLine(this.name+": Received Message: "+msg);
        }
    }
}
