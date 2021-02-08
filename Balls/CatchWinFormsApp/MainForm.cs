using Balls.common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatchMeWinFormsApp
    {
    public partial class MainForm : Form
        {
        private List<Ball> balls;
        public MainForm()
            {
            InitializeComponent();
            }

        private void mainForm_Load(object sender, EventArgs e)
            {
            }

        private void startButton_Click(object sender, EventArgs e)
            {
            balls = new List<Ball>();
            for (int i = 0; i < 10; i++)
                {
                var ball = new RandomBall(this);
                ball.Show();
                balls.Add(ball);
                }
            startButton.Enabled = false;
            moveBallsButton.Enabled = true;
            }

        private void moveBallsButton_Click(object sender, EventArgs e)
            {
            foreach (var ball in balls)
                {
                ball.Start();
                }
            moveBallsButton.Enabled = false;
            calculateBallsButton.Enabled = true;
            }

        private void calculateBallsButton_Click(object sender, EventArgs e)
            {
            var score = 0;
            foreach (var ball in balls)
                {
                ball.Stop();
                if(ball.OnForm())
                    {
                    score++;
                    }
                }
            MessageBox.Show($"Вы словили {score} шариков!");
            foreach (var ball in balls)
                {
                ball.Clear();
                }
            startButton.Enabled = true;
            calculateBallsButton.Enabled = false;
            }
        }
    }
