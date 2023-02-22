using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ChainOfResponsibilityDesignPattern.LAB_2
{
    public class HandlerMP4 : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".mp4"))
            {
                Console.WriteLine($"{fileType} tipinde medya oynatılıyor..!");
            }
            else
            {
                if (_nextHandler != null)
                {
                    _nextHandler.Player(fileType);
                }
            }
        }
    }
}
