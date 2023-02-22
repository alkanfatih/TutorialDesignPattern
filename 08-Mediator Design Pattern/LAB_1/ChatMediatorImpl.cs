using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mediator_Design_Pattern.LAB_1
{
    public class ChatMediatorImpl : IChatMediator
    {
        private List<User> users;
        public ChatMediatorImpl()
        {
            this.users = new List<User>();
        }
        public void addUser(User user)
        {
            this.users.Add(user);
        }

        public void sendMessage(string msg, User user)
        {
            foreach (User u in this.users)
            {
                //Mesaj gönderen kullanıcı tarafından alınmamalı
                if (u != user)
                {
                    u.receive(msg);
                }
            }
        }
    }
}
