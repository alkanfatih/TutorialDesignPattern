using _01_SingletonDesignPattern.LAB_1;
using _01_SingletonDesignPattern.LAB_2;

#region LAB_1

//Aşağıdaki kodu aktifleştirdiğimzide Constructor bize kızdı, çünkü erişilebilir durumda değil. Teorik olarakta tatışmıştık singleton ile üretilne nesneleri uygulamanın herhangi bir yeirnde çağırabilriz yeniden üretemeyiz

//SystemManager systemManager = new SystemManager();

var systemManager = SystemManager.CreateSingletonObject(); 
//bu custom method vasıtasıyla bir SystemManager.cs sınıfından bir nesne sınıfın içerisinde kontorllü bir şekilde üretilecek ve bize burada geri döndürülecek

systemManager.CreateLog();
// systemManager değişkeni üzerinden SystemManager.cs sınıfı içerisinde oluan CreateLog() methoduna eriştim. Normalde bu method instance method olduğundan ona nesnenin örneklemi üzerinden erişebilirdim.

#endregion

#region LAB_2
//Kontrollü bir şekilde nesne oluşturup içerisine data ataması gerçekleştiriyoruz.
SampleSingleton sample1 = SampleSingleton.CreateSampleSingleton();
sample1.Data = "First Instance";

//Nesne üretmeye devam ediyoruz.
SampleSingleton sample2 = SampleSingleton.CreateSampleSingleton();
SampleSingleton sample3 = SampleSingleton.CreateSampleSingleton();

//Ürettiğimiz nesnelerden data değişkenimizi çağırdığımız zaman hep aynı değerin geri döndüğünü fark edeceksiniz. Bu bize aynı nesne üzerinde olduğumuzu gösterir.
Console.WriteLine("Object-sample1: " + sample1.Data);
Console.WriteLine("Object-sample2: " + sample2.Data);
Console.WriteLine("Object-sample3: " + sample3.Data);

Console.WriteLine("-------------------------------");

//Bir kontrol'de if ile yapalım.
if (sample1 == sample2 && sample1 == sample2 && sample2==sample3)
{
    Console.WriteLine("Objects are the same instance");
}

#endregion
