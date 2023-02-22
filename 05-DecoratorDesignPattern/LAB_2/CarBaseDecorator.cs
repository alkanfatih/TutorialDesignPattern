using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecoratorDesignPattern.LAB_2
{
    //CarDecoratorBase soyut sınıfının CarBase.cs soyut sınıfından kalıtım almasını temin ettik. Burada dikkat edilmesi gereken husus CarBase.cs sınıfının abstract olarak işartelmiş "HirePrice" üyesinin burada override edilmeye zorunlu tutulmamasıdır. Bunun nedeni kalıtım alan ve veren sınıfların soyut olarak işaretlenmiş olmasıdır. Yani CarDecoratorBase.cs sınıfıda soyut olduğundan atadan gelen kuralları uygulamak zorunda kalmadık.
    public abstract class CarBaseDecorator : CarBase
    {
        private CarBase _carbase;
        public CarBaseDecorator(CarBase carBase) => this._carbase = carBase;
    }
}
