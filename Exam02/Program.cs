using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject(1, "BackEnd");
            sub1.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start The Exam Y Or N : ");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                sub1.SubjectExam.ShowExam();
                sw.Stop();
                Console.WriteLine($"The Elapsed Time is {sw.Elapsed}");
            }
        }
    }
}
