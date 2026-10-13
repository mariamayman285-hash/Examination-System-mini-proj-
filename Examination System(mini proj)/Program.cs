using System;

namespace Examination_System_mini_proj_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnswerList answersQ1 = new AnswerList();
            answersQ1.Add(new Answer { Text = "c#", IsCorrect = true });
            answersQ1.Add(new Answer { Text="java" , IsCorrect = false });

            ChooseOneQuestions question1 = new ChooseOneQuestions("Q1", "which language is this code written with?", 3, answersQ1);


            Subject sub1 = new Subject("c#");
            PracticeExam practiceExam = new PracticeExam(sub1 , 30);
            FinalExam finalExam = new FinalExam(sub1, 60);

            practiceExam.Questions.Add(question1);
            finalExam.Questions.Add(question1 );

            Console.WriteLine("Choose exam type: ");
            Console.WriteLine("Practice -> enter 1");
            Console.WriteLine("Final -> enter 2");

            bool key = int.TryParse(Console.ReadLine(), out int x);

            if (x == 1)
                practiceExam.ShowExam();
            else if (x == 2)
                finalExam.ShowExam(); 



        }
    }
}
