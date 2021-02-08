using GeniyIdiot;
using GeniyIdiot.common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
    {
    public partial class DataForm : Form
        {
        private Game game;
        public DataForm(Game game)
            {
            this.game = game;
            InitializeComponent();
            }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void CancelButton_Click(object sender, EventArgs e)
            {
            Close();
            }

        private void DataForm_Load(object sender, EventArgs e)
            {
            if (!FileSystem.CheckHaveFile("result.json"))
                {
                userResultDataGridView.Hide();
                dontHaveDataLabel.Text = "Игра еще не была пройдена!";
                }
            else
                {
                var usersList = game.GetUserData();
                foreach (var user in usersList)
                    {
                    userResultDataGridView.Rows.Add($"{user.FirstName} {user.LastName} {user.ThirdName}", user.CountRightAnswers, user.Diagnosis);
                    }
                }
            }
        }
    }
