using _04_AdapterDesignPattern.LAB_1;
using _04_AdapterDesignPattern.LAB_2;

#region LAB_1
Adapter adapter = new Adapter();
adapter.MessageDialog("C#", "Merhaba Dünya", Buttons.OK);
#endregion

#region LAB_2
ITarget target = new CalisanAdapter();
FaturaSistemi kullanici = new FaturaSistemi(target);
kullanici.CalisanGoster();
#endregion