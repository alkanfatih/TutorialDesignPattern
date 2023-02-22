using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mediator_Design_Pattern.LAB_2
{
    public class CoreMediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public void MediatorSendQuestion(string question, Student student) => Teacher.ReceiveQuestion(question, student);
        public void MediatorSendAnswer(string answer, Student student) => student.ReceiveAnswer(answer);
    }
}
