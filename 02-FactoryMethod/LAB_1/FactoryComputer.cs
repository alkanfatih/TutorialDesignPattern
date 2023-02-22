using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.LAB_1
{
    //Artık süper sınıflarımız ve alt sınıflarımız hazır olduğuna göre fabrika sınıfımızı yazabiliriz.
    public class FactoryComputer
    {
        public static CreatorComputer FactoryMethod(string type, string ram, string hdd, string cpu)
        {

            if (type == "gamePC")
            {
                return new ConcreateCreatorGamePC(ram, hdd, cpu);
            }
            else if (type == "developerPC")
            {
                return new ConcreateCreatorDeveloperPC(ram, hdd, cpu);
            }
            else
            {
                return null;
            }
        }
    }
}
