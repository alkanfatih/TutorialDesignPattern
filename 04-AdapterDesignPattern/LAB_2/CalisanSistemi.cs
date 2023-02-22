using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AdapterDesignPattern.LAB_2
{
    public class CalisanSistemi
    {
        public string[][] CalisanlariGetir()
        {
            string[][] calisanlar = new string[4][];
            calisanlar[0] = new string[] { "100", "Bilge", "Yazılım" };
            calisanlar[1] = new string[] { "101", "Ali", "Muhasebe" };
            calisanlar[2] = new string[] { "102", "Ayşe", "Yönetim" };
            calisanlar[3] = new string[] { "103", "Fatma", "Eğitim" };

            return calisanlar;
        }
    }
}
