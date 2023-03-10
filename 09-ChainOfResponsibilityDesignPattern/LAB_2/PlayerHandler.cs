using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ChainOfResponsibilityDesignPattern.LAB_2
{
    public abstract class PlayerHandler
    {
        protected PlayerHandler _nextHandler;

        public PlayerHandler NextHandler { set => _nextHandler = value; }

        public abstract void Player(string fileType);
    }
}
