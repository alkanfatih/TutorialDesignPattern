using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonDesignPattern.LAB_1
{
    public class SystemManager
    {
        private static SystemManager systemManager;
        private SystemManager() { } 
        //Buradaki amaç bu sınıfın dışarıdan erişilerek örneklemini alınmasını engellemektir.

        //Sınıfın örnkelemini dışarıda alamayacağız çünkü constructor private yaptık, bunun yerine nesneyi sınıfın kendi içerisinde kontrollü bir şekilde custom bir method yada propety üzerinden nesnenin üretimini kontrol altına alarak üretilmesini temin ettik.
        public static SystemManager CreateSingletonObject()
        {
            //Uygulamaın herhangi bir yerinde "SystemManager." diyerek CreateSingletonObject() methodunu çağırabilirim bu method ta bana SystemManager sınfının örneklemini bir şart doğruştusunda yaratır yada var olanu tesim eder.
            if (systemManager == null) // eğer _systemManage filed içerisi boşsa şart tutar
            {
                systemManager = new SystemManager(); // nesne üretilir
            }
            //_systemManager nesnesi zaten dolu ise direk bize onu teslim edecek 
            return systemManager; // nesne dönülür.
        }

        public void CreateLog() => Console.WriteLine("A log was created..!");
    }
}
