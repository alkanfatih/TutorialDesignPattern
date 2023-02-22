using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mediator_Design_Pattern.LAB_2
{
    public class Teacher : AssignedCourseMember
    {
        public Teacher(CoreMediator coreMediator) : base(coreMediator) { }

        public string Name { get; set; }

        public void ReceiveQuestion(string question, Student student) => Console.WriteLine($"Teacher receive question from {student.Name}, {question}");

        public void AnswerQuestion(string answer, Student student) => Console.WriteLine($"Teacher answer question {student.Name}, {answer}");
    }
}
