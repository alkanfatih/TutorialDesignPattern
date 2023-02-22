using _01_SingletonDesignPattern._2_LazySingleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonDesignPattern._3_ThreadSafeSingleton
{
    public class MultiThreadSafeSingleton
    {
        /*
         İş parçacığı açısından güvenli bir tekil sınıf oluşturmanın basit bir yolu, küresel erişim yöntemini eşitleyerek, bu yöntemi aynı anda yalnızca bir iş parçacığının yürütebilmesini sağlamaktır.
         */
        private static MultiThreadSafeSingleton instance;
        private MultiThreadSafeSingleton()
        {

        }
        private static readonly object lock_obj = new object();
        /*
         Çift kontrollü kilitleme prensibi. Bu yaklaşımda, bir singleton sınıfının yalnızca bir örneğinin oluşturulmasını sağlamak için ek bir denetimle if koşulunun içinde senkronize edilmiş blok kullanılır.
         */
        public static MultiThreadSafeSingleton GetInstance()
        {
            {
                lock (lock_obj)
                {
                    if (instance == null)
                    {
                        instance = new MultiThreadSafeSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
