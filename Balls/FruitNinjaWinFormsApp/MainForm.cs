using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
    {
    public partial class MainForm : Form
        {
        private int score;
        private Random random = new Random();
        private List<FruitBall> fruits;
        public MainForm()
            {
            InitializeComponent();
            if (FileProvader.CheckHaveFile())
                {
                scoreLabel.Text = FileProvader.GetScore();
                }
            }
        private void StartButton_Click(object sender, EventArgs e)
            {
            score = 0;
            fruits = new List<FruitBall>();
            startButton.Visible = false;
            createBallTimer.Start();
            }
        private void CreateBallTimer_Tick(object sender, EventArgs e)
            {
            if (startButton.Visible == true)
                {
                return;
                }
            scoreLabel.Text = score.ToString();
            if (random.Next(10) == 0)
                {
                var fruit = new FruitBall(this);
                fruits.Add(fruit);
                fruit.Start();
                }
            var deletableFruits = new List<FruitBall>();
            foreach (var fruit in fruits)
                {
                if (!fruit.OnForm())
                    {
                    deletableFruits.Add(fruit);
                    fruit.Stop();
                    fruit.Clear();
                    if (fruit is BombBall)
                        {
                        continue;
                        }
                    score -= 100;
                    }
                }
            foreach (var fruit in deletableFruits)
                {
                fruits.Remove(fruit);
                }
            if (random.Next(20) == 0)
                {
                var bomb = new BombBall(this);
                fruits.Add(bomb);
                bomb.Start();
                }
            }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
            {
            if (startButton.Visible == true)
                {
                return;
                }
            var deletableFruits = new List<FruitBall>();
            foreach (var fruit in fruits)
                {
                if (fruit.CheckClickOnBall(e.X, e.Y))
                    {
                    if (fruit is BombBall)
                        {
                        createBallTimer.Stop();
                        startButton.Visible = true;
                        if (FileProvader.GetScore() == null || Convert.ToInt32(FileProvader.GetScore()) < score)
                            {
                            FileProvader.SetScore(score);
                            }
                        if (FileProvader.CheckHaveFile())
                            {
                            scoreLabel.Text = FileProvader.GetScore();
                            }
                        MessageBox.Show($"Ваш результат: {score} очков!");
                        return;
                        }
                    deletableFruits.Add(fruit);
                    var choppingFruit = new ChoppingBall(this, e.X - 10, e.Y, fruit.GetVy());
                    choppingFruit.Start();
                    choppingFruit = new ChoppingBall(this, e.X + 10, e.Y, fruit.GetVy());
                    choppingFruit.Start();
                    fruit.Stop();
                    fruit.Clear();
                    score += 200;
                    }
                }
            foreach (var fruit in deletableFruits)
                {
                fruits.Remove(fruit);
                }
            }
        }
    }
