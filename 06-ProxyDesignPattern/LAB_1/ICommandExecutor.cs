using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ProxyDesignPattern.LAB_1
{
    public interface ICommandExecutor
    {
        public void runCommand(string cmd);
    }
}
