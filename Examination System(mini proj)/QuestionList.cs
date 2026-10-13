using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_mini_proj_
{
    internal class QuestionList: List<Question>
    {
        public string FileName { get; set; }
        public QuestionList(string FileName)
        {
            this.FileName = FileName;
        }

        public new void Add(Question question)
        {
            base.Add(question);

            using (TextWriter writer = File.AppendText(FileName))
            {
                writer.WriteLine(question.Body);
            }
        }
    }
}
