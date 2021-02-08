using GeniyIdiot;
using GeniyIdiot.common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
    {
    public partial class QuestionsForm : Form
        {
        private Game game;
        public QuestionsForm(Game game)
            {
            InitializeComponent();
            this.game = game;
            }

        private void QuestionsForm_Load(object sender, EventArgs e)
            {
            ShowQuestionsList();
            }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

        private void ShowQuestionsList()
            {
            var numberQuestions = 1;
            var items = QuestionsStorage.GetQuestions();
            foreach (var item in items)
                {
                questionsDataGridView.Rows.Add(numberQuestions, item.Text);
                numberQuestions++;
                }
            }

        private void ConfirmButton_Click(object sender, EventArgs e)
            {
            if (userAddQuestionBox.Text != "" && userAddAnswerBox.Text != "")
                {
                if (int.TryParse(userAddAnswerBox.Text, out var userAnswer) == true)
                    {
                    var question = new Question(userAddQuestionBox.Text, userAnswer);
                    QuestionsStorage.Add(question);
                    }
                else
                    {
                    MessageBox.Show("Ответ должен состоять только из цифр!");
                    }
                }
            else
                {
                MessageBox.Show("Ни одно из полей не может быть пустым!");
                }
            questionsDataGridView.Rows.Clear();
            ShowQuestionsList();
            }

        private void ExitButton_Click(object sender, EventArgs e)
            {
            Close();
            }

        private void Label1_Click(object sender, EventArgs e)
            {
            }

        private void DeleteQuestionsButton_Click(object sender, EventArgs e)
            {
            if (int.TryParse(userDeleteQuestionsBox.Text, out var questionNumber) == true)
                {
                if (questionNumber > 0 && questionNumber <= game.GetCountQuestions())
                    {
                    QuestionsStorage.Remove(questionNumber);
                    questionsDataGridView.Rows.Clear();
                    ShowQuestionsList();
                    }
                else
                    {
                    MessageBox.Show("Такого номера вопроса не существует!");
                    }
                }
            else
                {
                MessageBox.Show("Необходимо написать номер вопроса цифрами!");
                }
            }
        }
    }