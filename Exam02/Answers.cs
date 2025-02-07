using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Answers 
    {
        private string answertext;
        private int answerid;

        public string AnswerText
        {
            get { return answertext; }
            set { answertext = value; }
        }

        public int Answerid
        {
            get { return answerid; }
            set { answerid = value; }
        }

        public Answers(string answertext, int answerid)
        {
            AnswerText = answertext;
            Answerid = answerid;
        }
        public Answers()
        {

        }
    }
}
