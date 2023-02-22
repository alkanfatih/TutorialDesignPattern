using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonDesignPattern._1_BasicSingleton
{
    public class BasicSingleton
    {
        /*
         Eager Initialization diye adlandırılan bu yapıda sınıfın örneği (instance) sınıf yüklemesi (class loading) sırasında oluşur. Bu yöntemin dezavantajı istemci (client) uygulaması onu kullanmıyor olsa bile oluşturulmuş olmasıdır.

         Singleton sınıfınız çok fazla kaynak kullanmıyorsa, kullanılacak yaklaşım bu olmalıdır. Çoğunlukla, Dosya Sistemi (File System), Veritabanı bağlantıları (Database Connection) vb. senaryolarda singleton sınıflar oluşturulur.
         */
        public static BasicSingleton instance;
        private BasicSingleton()
        {

        }
        public static BasicSingleton GetInstance()
        {
            return instance;
        }
    }
}
