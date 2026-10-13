using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_mini_proj_
{
    internal class FinalExam : Exam
    {
        public FinalExam(Subject Subject , int Time): base(Subject , Time)
        {
            this.Subject = Subject;
            this.Time = Time;
        }
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            foreach(Question question in Questions)
            {
                question.Represent(); 
            }
        }
    }
}
