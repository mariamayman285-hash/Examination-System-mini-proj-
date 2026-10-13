using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_mini_proj_
{
    internal abstract class Exam : ICloneable , IComparable<Exam>
    {
        public int Time { get; set; }
        public Subject Subject { get; set; }
        public int NumOfQuestions => Questions.Count;
        public Dictionary<Question,AnswerList> QuestionAnswers { get; set; }
        public QuestionList Questions { get; set; }

        public ExamModeEnum Mode { get; set; }

        protected Exam(Subject Subject , int Time)
        {
            this.Subject = Subject;
            this.Time = Time;
            Questions = new QuestionList("Questions.txt");
            QuestionAnswers = new Dictionary<Question,AnswerList>();
        }

        public abstract void ShowExam();

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            return Time.CompareTo(other.Time);
        }


        public override string ToString()
        {
            return $"Time of exam: {Time} minutes , Number of questions: {NumOfQuestions}";
        }

        public override bool Equals(object obj)
        {
            return obj is Exam exam && Time == exam.Time;
        }

        public override int GetHashCode()
        {
            return Time.GetHashCode();
        }
    }
}
