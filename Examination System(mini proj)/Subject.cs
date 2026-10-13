using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_mini_proj_
{
    internal class Subject
    {
        public string Name { get; set; }
        public List<Exam> Exams { get; set; }
        public Subject(string Name)
        {
            this.Name = Name;
            Exams = new List<Exam>();
        }

    }
}
