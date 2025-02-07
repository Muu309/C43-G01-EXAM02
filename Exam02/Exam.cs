using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Exam
    {
        private int time;
        private int numofquestion;
        private double examgrade;
        Questions[] questions;
        Answers[] answers;

        public abstract ExamType Type { get; set; }


        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public int NumOfQuestions
        {
            get { return numofquestion; }
            set { numofquestion = value; }
        }

        public double Examgrade
        {
            get { return examgrade; }
            set { examgrade = value; }
        }


        public Questions[] Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        public Answers[] Answers
        {
            get { return answers; }
            set { answers = value; }
        }


        protected Exam(int time, int numofquestion)
        {
            Time = time;
            NumOfQuestions = numofquestion;

            Examgrade = 0.0;
            questions = new Questions[numofquestion];
            answers = new Answers[numofquestion];

        }


        public virtual void ShowExam()
        {
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                Console.WriteLine("***************");

                int id;
                string answer = "";
                answers[i] = new Answers();

                if (questions[i].GetType().Name == "ChooseQ")
                {
                    do
                    {
                        answer = Console.ReadLine();

                    } while (!(answer is string));

                    answers[i].AnswerText = answer;
                }
                else
                {
                    do
                    {

                    } while (!int.TryParse(Console.ReadLine(), out id));
                    answers[i].Answerid = id;
                    for (int j = 0; j < questions[i].Answerlist.Length; j++)
                    {
                        if (questions[i].Answerlist[j].Answerid == id)
                        {
                            answers[i].AnswerText = questions[i].Answerlist[j].AnswerText;
                        }
                    }

                    Console.WriteLine("************");

                }
            }
        }




    }
}
