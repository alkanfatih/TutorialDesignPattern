using _03_PrototypeDesignPattern.LAB_1;
using _03_PrototypeDesignPattern.LAB_2;

#region LAB_1
Employees employees = new Employees();
employees.loadData();

//Çalışan nesnesini almak için clone metodunu kullanın
Employees employeesClone1 = (Employees)employees.Clone();

Employees employeesClone2 = (Employees)employees.Clone();
List<String> list2 = employeesClone2.getEmpList();
list2.Add("Betül");

Console.WriteLine("Employees: " + employees.getEmpList());
foreach (string item in employees.getEmpList())
{
    Console.WriteLine(item);
}

Console.WriteLine("\nEmployees Clone 1: " + employeesClone1.getEmpList());
foreach (string item in employeesClone1.getEmpList())
{
    Console.WriteLine(item);
}

Console.WriteLine("\nEmployees Clone 2: " + employeesClone2.getEmpList());
foreach (string item in list2)
{
    Console.WriteLine(item);
}
#endregion

#region LAB_2
Game g1 = new Game(1, "TempleRun", "Single", true);
Game g2 = (Game)g1.Clone();
Game g3 = g1;

Console.WriteLine($"g1: {g1.GameName} - {g1.GameType}\ng2: {g2.GameName} - {g2.GameType}\ng3: {g3.GameName} - {g3.GameType}");

g1.GameName = "2048";

Console.WriteLine("-----------------------------");

Console.WriteLine($"g1: {g1.GameName} - {g1.GameType}\ng2: {g2.GameName} - {g2.GameType}\ng3: {g3.GameName} - {g3.GameType}");

if (g1.Equals(g2))
    Console.WriteLine("Tipler aynı!");
else
    Console.WriteLine("Tipler farklı!");
#endregion
