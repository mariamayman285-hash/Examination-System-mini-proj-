using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_mini_proj_
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Marks { get; set; }
        public AnswerList Answers { get; set; }

        public Question(string Header , string Body , double Marks)
        {
            this.Header = Header;
            this.Body = Body;
            this.Marks = Marks;
            Answers=new AnswerList();
        }

        public abstract void Represent();

    }
}
