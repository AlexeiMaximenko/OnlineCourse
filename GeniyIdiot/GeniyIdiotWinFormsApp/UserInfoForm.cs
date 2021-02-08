using GeniyIdiot;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
    {
    public partial class UserInfoForm : Form
        {
        private User user;
        public UserInfoForm(User user)
            {
            this.user = user;
            InitializeComponent();
            }

        private void ConfirmButton_Click(object sender, EventArgs e)
            {
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && thirdNameTextBox.Text != "")
                {
                user.FirstName = firstNameTextBox.Text;
                user.LastName = lastNameTextBox.Text;
                user.ThirdName = thirdNameTextBox.Text;
                DialogResult = DialogResult.OK;
                }
            else
                {
                MessageBox.Show("Ни одно из полей не может быть пустым!");
                }
            }

        private void CancelButton_Click(object sender, EventArgs e)
            {
            Close();
            }
        }
    }
