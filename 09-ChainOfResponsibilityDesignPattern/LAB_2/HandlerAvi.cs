using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ChainOfResponsibilityDesignPattern.LAB_2
{
    public class HandlerAvi : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".avi"))
                Console.WriteLine($"{fileType} tipinde medya oynatılıyor..!");
            else
                Console.WriteLine("Geçersiz medya tipi..!");
        }
    }
}
