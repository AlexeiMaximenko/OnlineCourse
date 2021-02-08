namespace GeniyIdiot
    {
    public class User
        {
        public string FirstName;
        public string LastName;
        public string ThirdName;
        public int CountRightAnswers;
        public string Diagnosis;

        public User()
            {
            CountRightAnswers = 0;
            }
        public void AcceptRightAnswer()
            {
            CountRightAnswers++;
            }
        public void ResetUserResult()
            {
            CountRightAnswers = 0;
            Diagnosis = "";
            }
        }
    }
