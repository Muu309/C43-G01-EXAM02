using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class ChooseQ : Questions
    {
        public override string Header { get; } = " MCQ Question";


        public ChooseQ(string body="", double marks=0) : base(body, marks)
        {
            int size;
            do
            {
                Console.Write("Enter Number Of Choices : ");
            } while (!int.TryParse(Console.ReadLine(), out size));
            Answerlist = new Answers[size];

        }

        public override string ToString()
        {
            Console.WriteLine($"{Header}     Marks:{Marks} \n {Body}");
            for (int i = 0; i < Answerlist.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{Answerlist[i].AnswerText}");
            }
            return "";

        }

        public static ChooseQ AddChooseOneQ()
        {
            ChooseQ question = new ChooseQ();

            Console.WriteLine(question.Header);
            Console.Write("Enter The Body Of The Question :  ");
            question.body = Console.ReadLine();
            Console.Write("Enter The Marks Of The Question :  ");
            question.marks = double.Parse(Console.ReadLine());

            for (int i = 0; i < question.Answerlist.Length; i++)
            {
                question.Answerlist[i] = new Answers();
                Console.WriteLine($"Enter The Choice No.{i + 1}");
                question.Answerlist[i].AnswerText = Console.ReadLine();
                question.Answerlist[i].Answerid = i + 1;
            }
            question.RightAnswer = new Answers();

            int id;
            do
            {
                Console.WriteLine("Enter The Right Answer For The Question :  ");

            } while (!int.TryParse(Console.ReadLine(), out id));
            question.RightAnswer.Answerid = id;
            question.RightAnswer.AnswerText = question.Answerlist [id-1].AnswerText;
            return question;

        }

    }
}

