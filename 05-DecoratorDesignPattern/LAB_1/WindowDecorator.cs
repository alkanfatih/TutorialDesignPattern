using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecoratorDesignPattern.LAB_1
{
    //Decarator
    public abstract class WindowDecorator : Window
    {
        private Window targetWindow;
        public Window TargetWindow
        {
            get { return targetWindow; }
            set { targetWindow = value; }
        }
        public WindowDecorator(Window targetWindow, string title)
        {
            this.targetWindow = targetWindow;
            this.targetWindow.Title = title;
        }
    }
}
