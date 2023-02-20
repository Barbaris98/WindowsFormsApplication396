using System;
using System.Diagnostics;
using WindowsFormsApplication396.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //создаем опросник
            var questionnaire = new Questionnaire();
            //создаем вопрос
            var quest = new Quest { Title = "Заголовок вопроса" };
            //создаем альтренативу
            var alt = new Alternative {Code = 1, Title = "Вариант1"};
            //добавляем альтернативу в вопрос
            quest.Add(alt);
            //добавляем вопрос в опросник
            questionnaire.Add(quest);

            //сохраняем опросник в файл
            SaverLoader.Save(questionnaire, "F:\\temp.q");

            //читаем опросник из файла
            var loadedQuestionnaire = SaverLoader.Load<Questionnaire>("F:\\temp.q");

            //проверяем число вопросов и альтернатив в загруженном опроснике
            Assert.AreEqual(loadedQuestionnaire.Count, questionnaire.Count);
            Assert.AreEqual(loadedQuestionnaire[0].Count, questionnaire[0].Count);
        }
    }
}
