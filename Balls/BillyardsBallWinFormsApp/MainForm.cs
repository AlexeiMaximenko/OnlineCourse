using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BillyardsBallWinFormsApp
    {
    public partial class MainForm : Form
        {

        private List<BillyardBall> balls;
        public MainForm()
            {
            InitializeComponent();
            }

        private void MainForm_Load(object sender, EventArgs e)
            {
            stopButton.Enabled = false;

            }

        private void startButton_Click(object sender, EventArgs e)
            {
            mainTimer.Enabled = true;
            balls = new List<BillyardBall>();
            for (int i = 0; i < 5; i++)
                {
                var newBall = new BillyardBall(this);
                balls.Add(newBall);
                newBall.Start();
                }
            startButton.Enabled = false;
            stopButton.Enabled = true;
            }

        private void stopButton_Click(object sender, EventArgs e)
            {
            foreach (var ball in balls)
                {
                ball.Stop();
                ball.Clear();
                }
            stopButton.Enabled = false;
            startButton.Enabled = true;
            }

        private void mainTimer_Tick(object sender, EventArgs e)
            {
            int upCount = 0;
            int downCount = 0;
            int leftCount = 0;
            int rightCount = 0;
            foreach (var ball in balls)
                {
                upCount += ball.GetUpCount();
                downCount += ball.GetDownCount();
                leftCount += ball.GetLeftCount();
                rightCount += ball.GetRightCount();
                }
            rightLabel.Text = rightCount.ToString();
            leftLabel.Text = leftCount.ToString();
            downLabel.Text = downCount.ToString();
            upLabel.Text = upCount.ToString();
            }
        }
    }
