using _08_Mediator_Design_Pattern.LAB_1;
using _08_Mediator_Design_Pattern.LAB_2;

#region LAB_1
IChatMediator mediator = new ChatMediatorImpl();
User user1 = new UserImpl(mediator, "Fatih");
User user2 = new UserImpl(mediator, "Beyazıt");
User user3 = new UserImpl(mediator, "Cem");
User user4 = new UserImpl(mediator, "Zeynep");

mediator.addUser(user1);
mediator.addUser(user2);
mediator.addUser(user3);
mediator.addUser(user4);

user1.send("Merhaba C#");

#endregion

#region LAB_2
CoreMediator coreMediator = new CoreMediator();

Teacher teacher = new Teacher(coreMediator);
teacher.Name = "Burak";

Student nur = new Student(coreMediator);
nur.Name = "Nur";

Student serhat = new Student(coreMediator);
serhat.Name = "Serhat";

coreMediator.Students = new List<Student> { nur, serhat };

nur.SendQuestion("3 tavşan 3 havucu 3 dakikada yerse, bir tavşan 1 havucu kaç dakikada yer?");

teacher.AnswerQuestion("Çok zor soru bilmiyorum..!", nur);

teacher.ReceiveQuestion("pişştt hoca..!", serhat);
teacher.AnswerQuestion("hoop..! Köylümmm..!", serhat);
#endregion