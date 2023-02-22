using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverDesignPattern.LAB_2
{
    //Observer
    public interface IUser
    {
        void Update(AbstractProduct product);
    }
}
