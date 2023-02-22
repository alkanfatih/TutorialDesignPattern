using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod.LAB_1
{
    //Super Class Tasarımı: Creator görevi görecek olan class.
    /*
     Fabrika tasarım modelindeki süper sınıf, bir arayüz, soyut sınıf veya normal bir sınıf olabilir.
    Bu örneğimizde bir bilgisayar yaratan bir creator süper class oluşturyoruz.
     */
    public abstract class CreatorComputer
    {
        public abstract string getRAM();
        public abstract string getHDD();
        public abstract string getCPU();

        public override string ToString()
        {
            return "RAM: " + getRAM() + ", HDD: " + getHDD() + ", CPU: " + getCPU();
        }
    }
}
