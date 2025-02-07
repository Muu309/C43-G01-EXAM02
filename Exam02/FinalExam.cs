using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numofquestion) : base(time, numofquestion)
        {
            Answers = new Answers[numofquestion];

        }

        public override ExamType Type { get; set; } = ExamType.Final;


        public override void ShowExam()
        {
            base.ShowExam();
            ShowExamRes();
        }

        public void ShowExamRes()
        {
            Console.WriteLine("The Right Answers :");
            double grade = 0;
            for (int i = 0; i < Questions.Length; i++)
            {
                if (Questions[i].GetType().Name == "ChooseQ")
                {
                    string answer = "";
                    string[] arr = Questions[i].RightAnswer.AnswerText.Split(" - ");

                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] == Questions[i].Answerlist[j].AnswerText)
                        {
                            answer += Questions[i].Answerlist[j].AnswerText + "";

                        }
                    }
                    Console.WriteLine($"Questions {i + 1} {Questions[i].Body} : {answer}");

                }
                else
                {
                    Console.WriteLine($"Question {i + 1} {Questions[i].Body} : {Questions[i].RightAnswer.AnswerText}");
                }

                if (Answers[i].AnswerText == Questions[i].RightAnswer.AnswerText)
                {
                    grade += Questions[i].Marks;
                }
            }
            Console.WriteLine($"Your Grade is : {grade} From {Examgrade}");
        }



    }
}
