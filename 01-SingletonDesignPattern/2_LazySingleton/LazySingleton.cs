using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonDesignPattern._2_LazySingleton
{
    public class LazySingleton
    {
        /*
         Lazy Loading (Geç Yüklemeli), İlk senaryoda singleton olan nesnenin sınıf yüklenirken direk oluşturuluyordu. Ancak herzaman bunu istemeyiz özellikle bu pahalı bir nesne ise biz bunu kullanma zamanına kadar oluşturmak istemeyiz. Böyle bir durumda Lazy Loading ile yaratılmasına ihtiyaç olana kadar geciktirebiliriz.
         */
        private static LazySingleton instance;
        private LazySingleton()
        {

        }
        /*
         Singleton modelini uygulamak için Lazy Initialization örneği global erişim metodunda oluşturlur.
         */
        public static LazySingleton GetInstance()
        {
            if (instance == null)
            {
                instance= new LazySingleton();
            }
            return instance;
        }
    }
}
