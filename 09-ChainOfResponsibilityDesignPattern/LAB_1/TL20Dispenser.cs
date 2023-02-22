using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ChainOfResponsibilityDesignPattern.LAB_1
{
    public class TL20Dispenser : IDispenseChain
    {
        private IDispenseChain chain;
        public void dispense(Currency cur)
        {
            if (cur.getAmount() >= 20)
            {
                int num = cur.getAmount() / 20;
                int remainder = cur.getAmount() % 20;
                Console.WriteLine(num + " adet 20TL verildi.");
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
