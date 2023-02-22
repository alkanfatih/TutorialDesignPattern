using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.LAB_2
{
    public class ConcreateIOS : ICreatorMobilApp
    {
        public void Platform()
        {
            Console.WriteLine("Bu uygulama IOS için çalışmaktadır...");
        }
    }
}
