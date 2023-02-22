using _07_ObserverDesignPattern.LAB_1;
using _07_ObserverDesignPattern.LAB_2;

#region LAB_1
//Konu oluştur
Subject topic = new Subject();

//Takipçi oluştur.
IObserver obj1 = new SubjectSubscriber("Obj1");
IObserver obj2 = new SubjectSubscriber("Obj2");
IObserver obj3 = new SubjectSubscriber("Obj3");

//Takipçileri konuya kaydeedin.
topic.register(obj1);
topic.register(obj2);
topic.register(obj3);

//Takipçileri konuya bağla
obj1.setSubject(topic);
obj2.setSubject(topic);
obj3.setSubject(topic);

//Herhangi bir güncelleme olup olmadığını kontrol edin
obj1.update();

//Konuya bir mesaj gönderin.
topic.postMessage("New Message");
#endregion

#region LAB_2
AbstractProduct book = new Product("Suç ve Ceza", 42.50M);

book.followList.Add(new User { Email = "kartal.akdogan@bilgeadam.com" });
book.followList.Add(new User { Email = "kartal.akdogan@bilgeadamboost.com" });
book.followList.Add(new User { Email = "kartalkaanakdogan@gmail.com" });

book.Price = 35.00M;
#endregion