using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrototypeDesignPattern.LAB_1
{
    //Prototype Design Pattern'nı kullanmak için .NET'de bulunan System ICloneable interface'ini kullanabiliriz.
    public class Employees : ICloneable
    {
        private List<string> empList;
        public Employees()
        {
            empList = new List<string>();
        }
        public Employees(List<string> empList)
        {
            this.empList = empList;
        }
        public void loadData()
        {
            empList.Add("Fatih");
            empList.Add("Beyazıt");
            empList.Add("Yavuz");
            empList.Add("Zeynep");
            empList.Add("Ayse");
        }
        public List<string> getEmpList()
        {
            return empList;
        }
        //Klonlama işlemini Icloneable interface üzerinden implement ettiğimiz clone metotu üzerinde gerçekleştiriyoruz.
        public object Clone()
        {
            List<string> temp = new List<string>();
            foreach (string item in getEmpList())
            {
                temp.Add(item);
            }

            return new Employees(temp);
        }
    }
}
