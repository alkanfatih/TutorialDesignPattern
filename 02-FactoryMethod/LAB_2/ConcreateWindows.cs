using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.LAB_2
{
    public class ConcreateWindows : ICreatorMobilApp
    {
        public void Platform()
        {
            Console.WriteLine("Bu uygulama Windows Mobile için çalışmaktadır...");
        }
    }
}
