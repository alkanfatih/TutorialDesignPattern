using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecoratorDesignPattern.LAB_1
{
    //Component - Sayfa özelliklerini taşıyan soyut bir sınıf inşa ediyoruz. 
    public abstract class Window
    {
        protected string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public Window()
        {
            title = "";
        }
        public Window(string title)
        {
            this.title = title;
        }
        //Türetilen sınıflarda uygulamak üzere render metodu tanımlıyoruz.
        public abstract void Render();
    }
}
