
using _09_ChainOfResponsibilityDesignPattern.LAB_1;
using _09_ChainOfResponsibilityDesignPattern.LAB_2;

#region LAB_1
ATMDispenseChain atmeDispenser = new ATMDispenseChain();
while (true)
{
    int amount = 0;
    Console.WriteLine("Çekmek istediğiniz miktar: ");
    amount = Convert.ToInt32(Console.ReadLine());
    if (amount % 10 != 0)
    {
        Console.WriteLine("Tutar 10'unun katı olmalıdır.");
        return;
    }
    atmeDispenser.c1.dispense(new Currency(amount));
}
#endregion

#region LAB_2
//Zincirin halkalarını tanımladık
PlayerHandler aviPlayer = new HandlerAvi();
PlayerHandler mp3Player = new HandlerMP3();
PlayerHandler mp4Player = new HandlerMP4();

//Zinciri oluşturuyoruz
mp3Player.NextHandler = mp4Player;
mp4Player.NextHandler = aviPlayer;

//İstekleri zincirin ilk halkasını gönderiyoruz.
mp3Player.Player("video.mpg");
mp3Player.Player("video.avi");
mp3Player.Player("video.mp3");
mp3Player.Player("video.mp4");
mp3Player.Player("video.zzz");
#endregion