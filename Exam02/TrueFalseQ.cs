using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class TrueFalseQ : Questions
    {
        public TrueFalseQ(string body = "", double marks = 0) : base(body, marks)
        {
            Answerlist = new Answers[2];
            Answerlist[0] = new Answers("True", 1);
            Answerlist[1] = new Answers("False", 2);

        }

        public override string ToString()
        {
            return $"{Header}     Marks:{Marks} \n {Body} \n 1.{Answerlist[0].AnswerText}    2.{Answerlist[1].AnswerText}";
        }

        public override string Header { get; } = "True Or False Questions";

        public static TrueFalseQ AddTrueFalseQ()
        {
            TrueFalseQ question = new TrueFalseQ();
            Console.WriteLine(question.Header);
            Console.Write("Enter The Body Of The Question :  ");
            question.body = Console.ReadLine();
            Console.Write("Enter The Marks Of The Question :  ");
            question.marks = double.Parse(Console.ReadLine());

            question.RightAnswer = new Answers();

            int id;
            do
            {
                Console.WriteLine("Enter The Right Answer For The Question : [1 For T , 2 For F]");

            } while (!int.TryParse(Console.ReadLine(), out id) || id<1 || id > 2);
            question.RightAnswer.Answerid = id;
            question.RightAnswer.AnswerText = question[id].AnswerText;
            return question ;
        }
    }
}
