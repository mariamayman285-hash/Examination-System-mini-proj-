using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_mini_proj_
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(Subject Subject , int Time): base(Subject , Time)
        {
            
        }
        public override void ShowExam()
        {
            Console.WriteLine("Practice Exam");

            foreach(Question question in Questions)
            {
                question.Represent();
                Console.WriteLine("Correct answer: ");
                //Console.WriteLine(question);
                foreach(Answer answer in question.Answers)
                {
                    if(answer.IsCorrect)
                    {
                        Console.WriteLine(answer.Text);
                    }
                }
            }
        }
    }
}
