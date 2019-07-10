using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestQuestions;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQuestion testQuestion = new TestQuestion();
            
            var quesCollection = testQuestion.GetQuestions();

             
            Testlet testlet = new Testlet();
            testlet.SetQuestions = quesCollection;
            var   randomQuestions = testlet.Randomize();


            foreach (Question q in randomQuestions)
            {
                Console.WriteLine(q.QuestionId + " " + q.ItemType);
            }
            Console.ReadLine();
        }
    }
}
