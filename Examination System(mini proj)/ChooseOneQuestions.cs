using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_mini_proj_
{
    internal class ChooseOneQuestions : Question
    {
        public ChooseOneQuestions(string Header , string Body , double Marks , AnswerList answers): base(Header , Body , Marks)
        {
            Answers.AddRange(answers);

            foreach (Answer answer in answers)
            {
                answer.Question = this;
            }
        }
        public override void Represent()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            foreach(Answer answer in Answers)
            {
                Console.WriteLine($"-{answer.Text}");
            }
        }
    }
}
