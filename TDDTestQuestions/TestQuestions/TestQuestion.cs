using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestions
{
    public class TestQuestion
    {
        public TestQuestion()
        {

        }
        public List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();
            Question question1 = new Question();
            question1.QuestionId = "1";
            question1.ItemType = QuestionTypeEnum.Pretest;
            Question question2 = new Question();
            question2.QuestionId = "2";
            question2.ItemType = QuestionTypeEnum.Pretest;
            Question question3 = new Question();
            question3.QuestionId = "3";
            question3.ItemType = QuestionTypeEnum.Pretest;
            Question question4 = new Question();
            question4.QuestionId = "4";
            question4.ItemType = QuestionTypeEnum.Pretest;


            Question question5 = new Question();
            question5.QuestionId = "5";
            question5.ItemType = QuestionTypeEnum.Operational;

            Question question6 = new Question();
            question6.QuestionId = "6";
            question6.ItemType = QuestionTypeEnum.Operational;

            Question question7 = new Question();
            question7.QuestionId = "7";
            question7.ItemType = QuestionTypeEnum.Operational;

            Question question8 = new Question();
            question8.QuestionId = "8";
            question8.ItemType = QuestionTypeEnum.Operational;

            Question question9 = new Question();
            question9.QuestionId = "9";
            question9.ItemType = QuestionTypeEnum.Operational;

            Question question10 = new Question();
            question10.QuestionId = "10";
            question10.ItemType = QuestionTypeEnum.Operational;
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);
            questions.Add(question6);
            questions.Add(question7);
            questions.Add(question8);
            questions.Add(question9);
            questions.Add(question10);
          
 
             return questions;
        }
    }

    public class Testlet

    {

        public string TestletId;

        private List<Question> Questions;



        public List<Question> Randomize()
        {
            //  private Random random = new Random();
            //Questions private collection has 6 Operational and 4 Pretest Questions. 
            //Randomize the order of these questions requirement (with TDD)
            //  int index = random.Next(Questions.Count);
            Random random = new Random();
            int index = 0;
            List<Question> tQuestions = new List<Question>();
            for (int count = 0; count < 100; count++)
            {
                index = random.Next(0, Questions.Count);
                // Console.WriteLine(index);
                if (!tQuestions.Exists(a => a.QuestionId
               == Questions[index].QuestionId))
                {
                    tQuestions.Add(Questions[index]);
                    if (tQuestions.Count == 10)
                    {
                        break;
                    }
                }

            }


            return tQuestions;


        }


        public List<Question> SetQuestions
        {
            get
            {
                return this.Questions;
            }
            set
            {
                this.Questions = value;
            }
        }
    }



    public class Question

    {

        public string QuestionId;

        public QuestionTypeEnum ItemType;


        public Question()
        {

        }
        public Question(string _QuestionId, QuestionTypeEnum _ItemType)
        {
            QuestionId = _QuestionId;
            ItemType = _ItemType;
        }

    }



    public enum QuestionTypeEnum

    {

        Pretest = 0,

        Operational = 1

    }

}
