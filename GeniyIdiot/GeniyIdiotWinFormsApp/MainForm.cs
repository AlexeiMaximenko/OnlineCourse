using GeniyIdiot;
using GeniyIdiot.common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
    {
    public partial class MainForm : Form
        {
        private static User user = new User();
        private Form questionsForm;
        private Form playForm;
        private Game game = new Game(user);
        public MainForm()
            {
            InitializeComponent();
            }

        private void Label1_Click(object sender, EventArgs e)
            {
            }

        private void Label4_Click(object sender, EventArgs e)
            {
            }
        private void PlayStartButton_Click(object sender, EventArgs e)
            {
            Hide();
            var userInfoForm = new UserInfoForm(user);
            var userInfoCheck = userInfoForm.ShowDialog();
            if (userInfoCheck == DialogResult.OK)
                {
                while (true)
                    {
                    game = new Game(user);
                    playForm = new PlayForm(game);
                    var restart = playForm.ShowDialog();
                    if (restart == DialogResult.Yes)
                        {
                        continue;
                        }
                    if (restart == DialogResult.No || restart == DialogResult.Cancel)
                        {
                        break;
                        }
                    }
                }
            Show();
            }

        private void ExitButton_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void QuestionsStartButton_Click(object sender, EventArgs e)
            {
            Hide();
            questionsForm = new QuestionsForm(game);
            questionsForm.ShowDialog();
            Show();
            }

        private void MainForm_Load(object sender, EventArgs e)
            {

            }

        private void DataStartButton_Click(object sender, EventArgs e)
            {
            Hide();
            var dataForm = new DataForm(game);
            dataForm.ShowDialog();
            Show();
            }
        }
    }