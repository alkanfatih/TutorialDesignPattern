using _06_ProxyDesignPattern.LAB_1;
using _06_ProxyDesignPattern.LAB_2;

#region LAB_1
//şifreyi bilinçli olarak yanlış giriyoruz.
ICommandExecutor executor = new CommandExecutorProxy("admin", "321");
try
{
	executor.runCommand("ls -ltr");
}
catch (Exception e)
{
	Console.WriteLine("Exception Message: " + e.Message);
}
#endregion

#region LAB_2
string kullaniciAdi = "", sifre = "";
double tutar = 0;

while (true)
{
    Console.Write("Lütfen Kullanıcı Adı Giriniz: ");
    kullaniciAdi = Console.ReadLine();

    Console.Write("Lütfen Şifre Giriniz: ");
    sifre = Console.ReadLine();

    Console.Write("Lütfen Ödenecek Miktarı Giriniz: ");
    tutar = Convert.ToDouble(Console.ReadLine());

    IBanka banka = new ProxyBanka(kullaniciAdi, sifre);
    banka.OdemeYap(tutar);

    Console.WriteLine("************************");
    Console.ReadLine();
}
#endregion