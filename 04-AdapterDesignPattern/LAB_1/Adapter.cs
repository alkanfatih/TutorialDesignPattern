using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AdapterDesignPattern.LAB_1
{
    public class Adapter
    {
        //adaptee class'ını Adapter nesnesi üzerinden ayağa kaldırıyoruz.
        private Adaptee adaptee;
        public Adapter()
        {
            adaptee = new Adaptee();
        }
        public void MessageDialog(string title, string text, Buttons buttons)
        { 
            adaptee.alert(title, text, buttons);
        }
    }
}
