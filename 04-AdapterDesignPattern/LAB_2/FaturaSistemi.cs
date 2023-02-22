using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AdapterDesignPattern.LAB_2
{
    public class FaturaSistemi
    {
        private readonly ITarget _calisanlar;

        public FaturaSistemi(ITarget calisanlar)
        {
            _calisanlar = calisanlar;
        }

        public void CalisanGoster()
        {
            List<string> personeller = _calisanlar.GetEmployeeList();

            Console.WriteLine("-----*** Çalışanlar Listesi ***-----");

            foreach (var item in personeller)
            {
                Console.Write(item);
            }
        }
    }
}
