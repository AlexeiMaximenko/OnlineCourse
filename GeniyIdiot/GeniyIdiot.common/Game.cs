using System;
using System.Collections.Generic;

namespace GeniyIdiot.common
    {
    public class Game
        {
        private User user;
        private List<Question> questionsList;
        private Question currentQuestion;
        private Random random = new Random();
        private int currentQuestionNumber = 0;
        private int countQuestions;
        public Game(User user)
            {
            questionsList = QuestionsStorage.GetQuestions();
            this.user = user;
            user.ResetUserResult();
            countQuestions = questionsList.Count;
            }
        public int GetCountQuestions()
            {
            questionsList = QuestionsStorage.GetQuestions();
            return questionsList.Count;
            }
        public Question PopRandomQuestion()
            {
            var randomQuestionNumber = random.Next(0, questionsList.Count);
            currentQuestion = questionsList[randomQuestionNumber];
            questionsList.RemoveAt(randomQuestionNumber);
            return currentQuestion;
            }
        public void SetUserAnswer(int input)
            {
            if (input == currentQuestion.RightAnswer)
                {
                user.AcceptRightAnswer();
                }
            }
        public string GetNumberQuestionInfo()
            {
            currentQuestionNumber++;
            return "Вопрос №" + currentQuestionNumber;
            }
        public bool IsEnd()
            {
            return questionsList.Count == 0;
            }
        public void CalculateUserDiagnosis()
            {
            user.Diagnosis = Diagnosis.Calculate(user.CountRightAnswers, countQuestions);
            }
        public void SaveGameResult()
            {
            CalculateUserDiagnosis();
            UserStorage.SaveUser(user);
            }
        public string GetEndGameInfo()
            {
            return $"{user.LastName} {user.FirstName.Substring(0, 1)}.{user.ThirdName.Substring(0, 1)}. ваш диагноз: {user.Diagnosis}.";
            }
        public string GetUserCountRightAnswersInfo()
            {
            return $"Правильных ответов: {user.CountRightAnswers}.";
            }
        public List<User> GetUserData()
            {
            return UserStorage.GetAllUserData();
            }
        }
    }
