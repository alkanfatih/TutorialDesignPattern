using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecoratorDesignPattern.LAB_2
{
    public abstract class CarBase
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }
}
