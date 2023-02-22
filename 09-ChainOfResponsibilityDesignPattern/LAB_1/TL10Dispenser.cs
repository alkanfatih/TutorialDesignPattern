using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ChainOfResponsibilityDesignPattern.LAB_1
{
    public class TL10Dispenser : IDispenseChain
    {
        private IDispenseChain chain;
        public void dispense(Currency cur)
        {
            if (cur.getAmount() >= 10)
            {
                int num = cur.getAmount() / 10;
                int remainder = cur.getAmount() % 10;
                Console.WriteLine(num + " adet 10TL verildi.");
                if (remainder != 0) this.chain.dispense(new Currency(remainder));
            }
            else
            {
                this.chain.dispense(cur);
            }
        }

        public void setNextChain(IDispenseChain nextChain)
        {
            this.chain = nextChain;
        }
    }
}
