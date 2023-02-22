using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ChainOfResponsibilityDesignPattern.LAB_1
{
    public class ATMDispenseChain
    {
        public IDispenseChain c1;

        public ATMDispenseChain()
        {
            // initialize the chain
            this.c1 = new TL50Dispenser();
            IDispenseChain c2 = new TL20Dispenser();
            IDispenseChain c3 = new TL10Dispenser();

            // set the chain of responsibility
            c1.setNextChain(c2);
            c2.setNextChain(c3);
        }
    }
}
