using System.Collections.Generic;
using System.Windows.Forms;

namespace SaluteWinFormsApp
    {
    public partial class MainForm : Form
        {
        List<SaluteBall> saluteBalls;
        List<RocketBall> rocketBalls;
        RocketBall rocketBall;
        public MainForm()
            {
            InitializeComponent();
            rocketBalls = new List<RocketBall>();
            }

        private void CreateSaluteButton_Click(object sender, System.EventArgs e)
            {
            rocketBall = new RocketBall(this);
            rocketBalls.Add(rocketBall);
            rocketBall.Start();
            explosionTimer.Start();
            }

        private void ExplosionTimer_Tick(object sender, System.EventArgs e)
            {
            if (rocketBalls.Count == 0)
                {
                return;
                }
            var deletableBalls = new List<RocketBall>();
            foreach (var rocketBall in rocketBalls)
                {
                if (rocketBall.CheckExplosionTime())
                    {
                    deletableBalls.Add(rocketBall);
                    rocketBall.Stop();
                    rocketBall.Clear();
                    CreateSalute(rocketBall);
                    }
                }
            foreach (var ball in deletableBalls)
                {
                rocketBalls.Remove(ball);
                }
            }
        private void CreateSalute(RocketBall rocketBall)
            {
            saluteBalls = new List<SaluteBall>();
            for (int i = 0; i < 10; i++)
                {
                var ball = new SaluteBall(this, rocketBall.GetX(), rocketBall.GetY());
                ;
                saluteBalls.Add(ball);
                ball.Start();
                }
            }
        }
    }

