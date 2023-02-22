using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.LAB_1
{
    //Süper class (Creator) üzerinden iki adet GamePc ve DeveloperPc alt sınıfı üretiyoruz.
    public class ConcreateCreatorGamePC : CreatorComputer
    {
        private string ram;
        private string hdd;
        private string cpu;
        public ConcreateCreatorGamePC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public override string getCPU()
        {
            return cpu;
        }

        public override string getHDD()
        {
            return hdd;
        }

        public override string getRAM()
        {
            return ram;
        }
    }
}
