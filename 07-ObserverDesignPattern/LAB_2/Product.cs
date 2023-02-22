using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverDesignPattern.LAB_2
{
    //ConcreteSubject
    public class Product : AbstractProduct
    {
        public Product(string productName, decimal productPrice) : base(productName, productPrice)
        {
        }
    }
}
