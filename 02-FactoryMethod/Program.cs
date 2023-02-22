#region LAB_1
using _02_FactoryMethod.LAB_1;
using _02_FactoryMethod.LAB_2;

CreatorComputer gamePC = FactoryComputer.FactoryMethod("gamePC", "16 GB", "500 GB", "2.4 GHz");
CreatorComputer developerPC = FactoryComputer.FactoryMethod("developerPC", "32 GB", "1000 TB", "2.4 GHz");

Console.WriteLine("Game PC:\n" + gamePC.ToString());
Console.WriteLine("Developer PC:\n" + developerPC.ToString());
#endregion

#region LAB_2
ICreatorMobilApp AppWindows = FactoryMobilApp.FactoryMethod("windows");
ICreatorMobilApp AppIos = FactoryMobilApp.FactoryMethod("ios");
ICreatorMobilApp AppAndroid = FactoryMobilApp.FactoryMethod("android");

AppWindows.Platform();
AppIos.Platform();
AppAndroid.Platform();
#endregion