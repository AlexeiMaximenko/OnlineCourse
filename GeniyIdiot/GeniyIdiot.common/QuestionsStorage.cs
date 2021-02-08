using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeniyIdiot
    {
    public class QuestionsStorage
        {
        private static string questionsPath = "questions.json";
        public static List<Question> GetQuestions()
            {
            Init();

            var serializedQuestions = FileSystem.Get(questionsPath);
            var questionsList = JsonConvert.DeserializeObject<List<Question>>(serializedQuestions);

            return questionsList;
            }
        private static void Init()
            {
            if (!FileSystem.CheckHaveFile(questionsPath))
                {
                var questionsList = GetDefaultQuestions();
                var serialized = JsonConvert.SerializeObject(questionsList, Formatting.Indented);
                FileSystem.Save(questionsPath, serialized);
                }
            }
        private static List<Question> GetDefaultQuestions()
            {
            var questionsList = new List<Question>();
            questionsList.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questionsList.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9));
            questionsList.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questionsList.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
            questionsList.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

            return questionsList;
            }


        public static void Add(Question newQuestion)
            {
            var questionsList = GetQuestions();
            questionsList.Add(newQuestion);
            var serializedQuestion = JsonConvert.SerializeObject(questionsList, Formatting.Indented);
            FileSystem.Replace(questionsPath, serializedQuestion);
            }

        public static void Remove(int userInput)
            {
            var questionsList = GetQuestions();
            questionsList.RemoveAt(userInput - 1);
            var serializedQuestion = JsonConvert.SerializeObject(questionsList, Formatting.Indented);
            FileSystem.Replace(questionsPath, serializedQuestion);
            }
        }
    }