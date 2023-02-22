using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecoratorDesignPattern.LAB_2
{
    //HireOffer.cs sınıfı CarDecoratorBase.cs souyt sınıfından kalıtım aldı. Kalıtım vasıtasıyla implement edilmesi zorunlu olarak gelen HirePrice üyesini burada override ettik. Bunun yanında constrcor yapısında aşağıda dokümantre edildiği gibi aldığı parametreyi atasınada gönderdik.
    public class HireOffer : CarBaseDecorator //HireOffer arabirimdir
    {
        private CarBase _carBase;
        //HireOffer.cs sınıfını initialize ettiğimizde constructor methodu içerisine zorunlu olarak "CarBase" tipinde bir parametre verdik. Lakin kızgınlığı geçmedi, bunun sebebi atasınında bu parametreyi beklemesidir. Bu kapsamda constructor methodun yanına "base(carBase)" değerinide ekledik ki sınıflar initialize edilirken gelen parametre her iki taraftada kullanılabilinsin. Böylelikle gelen parametreyi hem HireOffer.cs sınıfı içerisnde kullanabileceğiz hemde atasına onu gönderebileceğiz. 
        public HireOffer(CarBase carBase) : base(carBase)
        {
            this._carBase = carBase;
        }

        //Sınıf içerisinde kullanılacak kendine ait üyesi.
        public int DiscountedPercantege { get; set; }
        
        public override decimal HirePrice
        {
            get => _carBase.HirePrice * DiscountedPercantege / 100;
            set { }
        }

    }
}
