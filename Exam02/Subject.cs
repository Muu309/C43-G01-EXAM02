using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class Subject
	{
		private string name;
		private int id;
		private Exam subExam;


		public Exam SubjectExam
		{
			get { return subExam; }
			set { subExam = value; }
		}


		public int ID
		{
			get { return id; }
			set { id = value; }
		}


		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Subject(string name, int id, Exam subExam)
		{
			Name = name;
			ID = id;
            SubjectExam = subExam;
		}

        public Subject( int id, string name):this(name,id, new PracticalExam(60, 3))
        {
            
        }


        public override string ToString()
		{
			return $"Subject Name {Name} \n Subject id {ID} \n Exam Type {SubjectExam}";
		}

        public Exam GetSubExam()
        {
            return SubjectExam;
        }

        public void CreateExam()
		{
			int time;
			int type;

			do
			{
				Console.Write("Choose The Type Of The Exam : [1 For Practical , 2 For Final ] : ");

			} while (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 2);
            SubjectExam.Type = (ExamType)type;

			do
			{
				Console.Write("Please Enter The Time Of The Exam In Minutes : ");

			} while (!int.TryParse(Console.ReadLine(), out time) || time < 60 || time > 180);
			SubjectExam.Time = time;

			Console.Write(" Enter Number Of Questions : ");
			int NumOfQ = int.Parse(Console.ReadLine());
			if (SubjectExam.Type == ExamType.practicalExam)
			{
                SubjectExam = new PracticalExam(time, NumOfQ);
                SubjectExam.Questions = Questions.CreateQuestions(NumOfQ);
			}
			else
			{
                SubjectExam = new FinalExam(time, NumOfQ);
                SubjectExam.Questions = Questions.CreateQuestions(NumOfQ);
			}

			for (int i = 0; i < SubjectExam.Questions.Length; i++)
			{
                SubjectExam.Examgrade += SubjectExam.Questions[i].Marks;
			}
		}

	}
}
