using _05_DecoratorDesignPattern.LAB_1;
using _05_DecoratorDesignPattern.LAB_2;

#region LAB_1
//Pencere sayfaları oluşturuluyor.
Window w1 = new LoginWindow("Sisteme giriş");
Window w2 = new ReportWindow("Stok Raporu Ekranı");
Window w3 = new ReportWindow("Satış Raporu Ekranı");

//Oluşturulan pencerelere decorator ile theme yüklemesi yapılıyor.
ThemeDecorator decorator1 = new ThemeDecorator(w1, "Sisteme Giriş");
ThemeDecorator decorator2 = new ThemeDecorator(w2, "Stok Raporu Ekranı");
ThemeDecorator decorator3 = new ThemeDecorator(w3, "Satış Raporu Ekranı");

decorator1.SetTheme("Ayder Teması");
decorator2.SetTheme("Ürgüp Teması");
decorator3.SetTheme("Pamukkale Teması");

#endregion

#region LAB_2
CarBase myCar = new CarSUV
{
    Brand = "Dodge",
    Model = "Ram 2500 Power Wagon",
    HirePrice = 35000
};

HireOffer hireOffer = new HireOffer(myCar);
hireOffer.DiscountedPercantege = 20;

Console.WriteLine($"Not applied Discount: {myCar.HirePrice}");
Console.WriteLine($"Applied Discount: {hireOffer.HirePrice}");
#endregion