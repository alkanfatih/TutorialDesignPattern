using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecoratorDesignPattern.LAB_1
{
    //ConcreteDecorator
    public class ThemeDecorator : WindowDecorator
    {
        public ThemeDecorator(Window targetWindow, string title) : base(targetWindow, title)
        {
        }
        //Override base window class (WindowDecorator, Window class'ından türediği için burada window class'ın metodu override edilebilir.)
        public override void Render()
        {
            TargetWindow.Render();
        }
        public void SetTheme(string name)
        {
            Console.WriteLine("{0} başlıklı pencere {1} teması uygulandı", TargetWindow.Title, name);
            Render();
        }
    }
}
