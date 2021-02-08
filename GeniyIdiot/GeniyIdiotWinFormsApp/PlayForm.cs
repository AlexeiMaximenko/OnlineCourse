using GeniyIdiot;
using GeniyIdiot.common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
    {
    public partial class PlayForm : Form
        {
        private Question currentQuestion;
        private Game game;

        public PlayForm(Game game)
            {
            InitializeComponent();
            this.game = game;
            }

        private void PlayForm_Load(object sender, EventArgs e)
            {
            ShowNextQuestion();
            }
        private void ShowNextQuestion()
            {
            if (!game.IsEnd())
                {
                currentQuestion = game.PopRandomQuestion();
                userAnswerBox.Text = "";
                ActiveControl = userAnswerBox;
                questionNumberLabel.Text = game.GetNumberQuestionInfo();
                qiestionTextLabel.Text = currentQuestion.Text;
                }
            else
                {
                EndGame();
                }
            }

        private void ConfirmAnswerButton_Click(object sender, EventArgs e)
            {
            if (int.TryParse(userAnswerBox.Text, out var number))
                {
                game.SetUserAnswer(number);
                ShowNextQuestion();
                }
            else
                {
                MessageBox.Show("Ответ должен состоять из цифр!");
                }
            }

        private void EndGame()
            {
            game.SaveGameResult();
            DialogResult = MessageBox.Show($"{game.GetEndGameInfo()}\n Хотите повторить игру?", "Итог", MessageBoxButtons.YesNo);
            }

        private void UserAnswerBox_KeyDown(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                if (int.TryParse(userAnswerBox.Text, out var number))
                    {
                    game.SetUserAnswer(number);
                    ShowNextQuestion();
                    }
                else
                    {
                    MessageBox.Show("Ответ должен состоять из цифр!");
                    }
                }
            }
        }
    }