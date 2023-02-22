using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ProxyDesignPattern.LAB_1
{
    public class CommandExecutorProxy : ICommandExecutor
    {
        private bool isAdmin;
        private ICommandExecutor executor;
        //Yapıcı metodun görevi kullancı bilgileri doğru ise bir vekil komut nesnesini oluşturacak.
        public CommandExecutorProxy(string user, string pwd)
        {
            if (user == "admin" && pwd=="123")
            {
                isAdmin = true;
                executor = new CommandExecutorImp();
            }
        }

        public void runCommand(string cmd)
        {
            if (isAdmin)
            {
                executor.runCommand(cmd);
            }
            else
            {
                Console.WriteLine("this command is not allowed for non-admin users.");
            }
        }
    }
}
