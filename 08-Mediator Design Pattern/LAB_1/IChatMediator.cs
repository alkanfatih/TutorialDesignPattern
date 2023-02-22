using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mediator_Design_Pattern.LAB_1
{
    public interface IChatMediator
    {
        public void sendMessage(string msg, User user);
        void addUser(User user);
    }
}
