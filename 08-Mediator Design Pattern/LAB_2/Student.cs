using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mediator_Design_Pattern.LAB_2
{
    public class Student : AssignedCourseMember
    {
        //Student sınıfını initialize ederken içerisinse CoreMediator tipinde bir parametre alacak. Aldığı bu prametreyi sınıf içerisinde kullanmadığımızdan private bir üyeye atamadık. Sadece gelen parametreyi ata sınıfına göndermek için consttructor kullandık.
        public Student(CoreMediator coreMediator) : base(coreMediator) { }

        public string Name { get; set; }

        public void SendQuestion(string message) => Console.WriteLine($"{this.Name}: {message}");

        public void ReceiveAnswer(string message) => Console.WriteLine($"Student received answer {message}");
    }
}
