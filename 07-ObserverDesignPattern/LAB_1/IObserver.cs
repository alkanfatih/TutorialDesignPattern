using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07_ObserverDesignPattern.LAB_1
{
    public interface IObserver
    {
        //Konu tarafından kullanılan takipçinin güncelleme metodu
        public void update();

        //Takipçiyi konu ile bağlamak için.
        public void setSubject(ISubject sub);
    }
}
