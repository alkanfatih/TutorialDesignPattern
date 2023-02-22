using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecoratorDesignPattern.LAB_1
{
    //ConcreteComponent
    public class ReportWindow : Window
    {
        public ReportWindow()
        {

        }
        public ReportWindow(string title) : base(title)
        {

        }
        //Override base window class
        public override void Render()
        {
            Console.WriteLine("{0} Başlıklı Rapor ekranı render edildi", title);
        }
    }
}
