using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverDesignPattern.LAB_2
{
    //Concrete Observer
    public class User : IUser
    {
        public string Email { get; set; }
        public void Update(AbstractProduct product)
        {
            Console.WriteLine("{0} ürünün fiyatı {1} olarak güncellendi. {2} e-posta adresine gönderildi.", product.ProductName, product.Price.ToString("C2"), Email);
        }
    }
}
