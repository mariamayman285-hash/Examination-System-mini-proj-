using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_mini_proj_
{
    internal class TrueOrFalseQuestions : Question
    {
        public TrueOrFalseQuestions(string Header , string Body , double Marks , bool CorrectAnswer) : base(Header , Body , Marks)
        {
            Answer trueAnswer = new Answer
            {
                Text = "True",
                IsCorrect = CorrectAnswer,
                Question = this
            };

            Answer falseAnswer = new Answer
            {
                Text = "False",
                IsCorrect = !CorrectAnswer,
                Question = this
            };

            Answers.Add(trueAnswer);   //
            Answers.Add(falseAnswer);  // adding the two answers in the answers list that was made in class question ctor
        }

        public override void Represent()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine("1-True");
            Console.WriteLine("2-False-> 2");
        }
    }
}
