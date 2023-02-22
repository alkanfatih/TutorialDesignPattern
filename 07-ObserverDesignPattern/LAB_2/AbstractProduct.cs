using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverDesignPattern.LAB_2
{
    // Subject
    public abstract class AbstractProduct
    {
        public string ProductName { get; set; }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price > value) // Şu anki fiyat, güncellenen fiyattan yüksek ise
                {
                    _price = value;
                    NotifyProduct(); // Kullanıcıları bilgilendir.
                }
            }
        }

        public List<IUser> followList = new List<IUser>(); // Takipçi listesi

        private void NotifyProduct()
        {
            foreach (IUser user in followList)
            {
                user.Update(this); // Her bir takipçi kullanıcıya bu class'ı gönder.
            }
        }

        public AbstractProduct(string productName, decimal productPrice)
        {
            this.ProductName = productName;
            this._price = productPrice;
        }
    }
}
