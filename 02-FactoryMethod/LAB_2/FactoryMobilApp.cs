using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.LAB_2
{
    public class FactoryMobilApp
    {
        public static ICreatorMobilApp FactoryMethod(string type)
        {
            if (type == "windows")
            {
                return new ConcreateWindows();
            }
            else if ( type == "android")
            {
                return new ConcreateAndroid();
            }
            else if (type == "ios")
            {
                return new ConcreateIOS();
            }
            else
            {
                return null;
            }

        }
    }
}
