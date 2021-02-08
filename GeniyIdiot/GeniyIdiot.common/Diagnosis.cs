namespace GeniyIdiot
    {
    public class Diagnosis
        {
        public static string Calculate(int countRightAnswers, int countQuestions)
            {
            double rightAnswersPercent = 0;
            if (countRightAnswers != 0)
                {
                rightAnswersPercent = (double)countRightAnswers / (double)countQuestions * 100;
                }
            if (rightAnswersPercent < 10)
                {
                return "Идиот";
                }
            if (rightAnswersPercent < 30)
                {
                return "Кретин";
                }
            if (rightAnswersPercent < 50)
                {
                return "Дурак";
                }
            if (rightAnswersPercent < 70)
                {
                return "Нормальный";
                }
            if (rightAnswersPercent < 90)
                {
                return "Талант";
                }
            else
                {
                return "Гений";
                }
            }
        }
    }
