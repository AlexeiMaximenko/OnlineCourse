using Balls.common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClickCatchWinFormsApp
    {
    public partial class MainForm : Form
        {
        private int score = 0;
        private List<Ball> balls;
        private int countBallsOnForm = 10;
        public MainForm()
            {
            InitializeComponent();
            }

        private void MainForm_Load(object sender, EventArgs e)
            {
            countCatchBallsLabel.Text = "Количество пойманных шариков: " + score;
            }

        private void showBallsButton_Click(object sender, EventArgs e)
            {
            balls = new List<Ball>();
            for (int i = 0; i < countBallsOnForm; i++)
                {
                var ball = new RandomBall(this);
                ball.Show();
                balls.Add(ball);
                }
            showBallsButton.Enabled = false;
            startGameButton.Enabled = true;
            }

        private void startGameButton_Click(object sender, EventArgs e)
            {
            mainTimer.Start();
                {
                foreach (var ball in balls)
                    {
                    ball.Start();
                    }
                startGameButton.Enabled = false;
                }

            }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
            {
            if (!mainTimer.Enabled)
                {
                return;
                }
            var notDeletableBalls = new List<Ball>();
            foreach (var ball in balls)
                {
                ball.Stop();
                if (ball.CheckClickOnBall(e.X, e.Y))
                    {
                    score++;
                    countCatchBallsLabel.Text = "Количество пойманных шариков: " + score;
                    ball.Stop();
                    ball.Clear();
                    continue;
                    }
                notDeletableBalls.Add(ball);
                }
            balls = notDeletableBalls;
            foreach (var ball in balls)
                {
                ball.Start();
                }
            }

        private void mainTimer_Tick(object sender, EventArgs e)
            {
            var notDeletableBalls = new List<Ball>();
            foreach (var ball in balls)
                {
                if (!ball.OnForm())
                    {
                    ball.Stop();
                    ball.Clear();
                    continue;
                    }
                notDeletableBalls.Add(ball);
                }
            balls = notDeletableBalls;
            if (balls.Count == 0)
                {
                mainTimer.Stop();
                MessageBox.Show($"Количество пойманных шариков: {score}");
                showBallsButton.Enabled = true;
                }
            }
        }
    }
