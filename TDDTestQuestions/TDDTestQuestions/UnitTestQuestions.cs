using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestQuestions;
namespace TDDTestQuestions
{
    [TestClass]
    public class UnitTestQuestions
    {
        [TestMethod]
        public void TestTotalCount()
        {
            TestQuestion testQuestion = new TestQuestion();

            Testlet testlet = new Testlet();
          //  testlet.TestletId = "1";
            testlet.SetQuestions = testQuestion.GetQuestions();
            List<Question> testletCollection = testlet.Randomize();

            Int32 questionsCount = testletCollection.Count;
            Assert.AreEqual(questionsCount, 10);
        }
        [TestMethod]
        public void TestPreTestQuestionsCount()
        {
            //Testlet -- Collection
            TestQuestion testQuestion = new TestQuestion();

            Testlet testlet = new Testlet();
          //  testlet.TestletId = "1";
            testlet.SetQuestions = testQuestion.GetQuestions();
            List<Question> testletCollection = testlet.Randomize();

            Int32 preTestTypeCount = testletCollection.FindAll(x => x.ItemType == QuestionTypeEnum.Pretest  ).Count;
            Assert.AreEqual(preTestTypeCount, 4);
        }

        [TestMethod]
        public void TestOperationalQuestionsCount()
        {
            TestQuestion testQuestion = new TestQuestion();

            Testlet testlet = new Testlet();
           
         //   testlet.TestletId = "1";
           
            testlet.SetQuestions = testQuestion.GetQuestions();
            List<Question> testletCollection = testlet.Randomize();

            Int32 operationalTypeCount = testletCollection.Where(x => x.ItemType == QuestionTypeEnum.Operational).ToList().Count();
            Assert.AreEqual(operationalTypeCount, 6);
        }
        [TestMethod]
        public void TestQuestionsDuplicateCount()
        {
            TestQuestion testQuestion = new TestQuestion();
           
            Testlet testlet = new Testlet();
         //   testlet.TestletId = "1";
            testlet.SetQuestions = testQuestion.GetQuestions();
            List<Question> testletCollection = testlet.Randomize();

            Int32 duplicates = testletCollection.GroupBy(x => x.QuestionId).Where(g => g.Count() > 1).Count();
            Assert.AreEqual(duplicates, 0);
        }

    }
}
