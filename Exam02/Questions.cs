using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Questions
    {
        protected string body;
        protected double marks;
        Answers[] answerlist;
        private Answers rightanswer;


        public abstract string Header { get; }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public Answers RightAnswer
        {
            get { return rightanswer; }
            set { rightanswer = value; }
        }

        public Answers this[int id]
        {
            get
            {
                for (int i = 0; i < answerlist.Length; i++)
                {
                    if (answerlist[i].Answerid == id)
                    {
                        return answerlist[i];
                    }
                }
                return new Answers();
            }
        }

        public Answers this[string text]
        {
            get
            {
                for (int i = 0; i < answerlist.Length; i++)
                {
                    if (answerlist[i].AnswerText == text)
                    {
                        return answerlist[i];
                    }
                }
                return new Answers();
            }
        }

        public Answers[] Answerlist
        {
            get { return answerlist; }
            set { answerlist = value; }
        }


        protected Questions(string body, double marks)
        {
            Body = body;
            Marks = marks;
        }

        public static Questions[] CreateQuestions(int size)
        {
            Questions[] questions = new Questions[size];
            for (int i = 0; i < questions?.Length; i++)
            {
                int qtype;
                do
                {
                    Console.WriteLine($"Please Choose The type of the question no.{i + 1} : [1 For T Or F] , [2 For MCQ]  ");

                } while (!int.TryParse(Console.ReadLine(), out qtype) || qtype < 1 || qtype > 2);

                if (qtype == 1)
                {
                    Console.WriteLine($"The Data Of T Or F Question No.{i + 1}");
                    questions[i] = TrueFalseQ.AddTrueFalseQ();
                }
                else if (qtype == 2)
                {
                    Console.WriteLine($"The Data Of MCQ Question No.{i + 1}");
                    questions[i] = ChooseQ.AddChooseOneQ();
                }
                else
                {
                    Console.WriteLine("Choose 1 Or 2");
                }

            }
            return questions; 

        }
    }
}
