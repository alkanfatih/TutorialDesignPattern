using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverDesignPattern.LAB_1
{
    public interface ISubject
    {
        //Takipçileri kaydetme ve kayıtlarını silme metotları
        public void register(IObserver obj);
        public void unregister(IObserver obj);

        //Değişikliği takipçiye bildirmek için metot
        public void notifyObservers();

        //konudan güncellemeleri alma metodu
        public Object getUpdate(IObserver obj);
    }
}
