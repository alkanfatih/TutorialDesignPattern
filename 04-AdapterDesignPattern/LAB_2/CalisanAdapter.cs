using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AdapterDesignPattern.LAB_2
{
    public class CalisanAdapter : CalisanSistemi, ITarget
    {
        public List<string> GetEmployeeList()
        {
            List<string> calisanList = new List<string>();
            string[][] employees = CalisanlariGetir();

            foreach (string[] employee in employees)
            {
                calisanList.Add(employee[0]);
                calisanList.Add(", ");
                calisanList.Add(employee[1]);
                calisanList.Add(", ");
                calisanList.Add(employee[2]);
                calisanList.Add("\n");
            }

            return calisanList;
        }
    }
}
