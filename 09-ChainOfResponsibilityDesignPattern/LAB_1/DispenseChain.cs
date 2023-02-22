using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ChainOfResponsibilityDesignPattern.LAB_1
{
    public interface IDispenseChain
    {
        void setNextChain(IDispenseChain nextChain);

        void dispense(Currency cur);
    }
}
