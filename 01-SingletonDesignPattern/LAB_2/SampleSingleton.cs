using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingletonDesignPattern.LAB_2
{
    public class SampleSingleton
    {
        /*
         Singleton design pattern'ın gereksinimlerini uyguluyoruz artı olarak bir data adında değişken tanımı yapıyoruz. Program.cs tarafında ürettiğimiz ilk nesnede data ya değer ataması yapıp sonradan üreteceğimiz tüm nesnelerin üzerindende data'yı okumaya çalışacağız. Böylece tek bir nesne üzerinden devam edildiğini kullanıcıya gösterebiliriz.
         */
        private static SampleSingleton sampleSingleton;
        private string data;
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        //protected erişim beliryicisi tanımlanarak da Yapıcı metot üzerinde kısıtlama uygulayabiliriz.
        protected SampleSingleton()
        {

        }
        public static SampleSingleton CreateSampleSingleton() 
        {
            if (sampleSingleton == null)
            {
                sampleSingleton= new SampleSingleton();
            }
            return sampleSingleton;
        }
    }
}
