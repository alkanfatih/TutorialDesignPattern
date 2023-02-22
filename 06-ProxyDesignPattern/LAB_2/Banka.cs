using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ProxyDesignPattern.LAB_2
{
    // Real Subject Class
    public class Banka
    {
        public bool Pay(double amount)
        {
            if (amount < 100)
            {
                Console.WriteLine($"Ödemeniz gereken tutar 100 TL'dir. Gereken tutardan az olamaz! Fark: {100 - amount}");
            }
            else if (amount > 100)
            {
                Console.WriteLine($"Ödemeniz gereken tutar 100 TL'dir. Gereken tutardan fazla olamaz! Fark: {amount - 100}");
            }
            else
            {
                Console.WriteLine($"Ödeme başarılı bir şekilde gerçekleşti. Tutar: {amount}");
                return true;
            }

            return false;
        }
    }
}
