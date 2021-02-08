using Balls.common;
using System.Windows.Forms;

namespace SaluteWinFormsApp
    {
    class RocketBall : RandomBall
        {
        private float vyChange = 0.1f;
        public RocketBall(Form form) : base(form)
            {
            x = random.Next(50, form.ClientSize.Width - 50);
            vy = random.Next(-4, 0) - 4;
            vx = random.Next(-2, 3);
            size = 20;
            y = form.ClientSize.Height - size;
            }
        public bool CheckExplosionTime()
            {
            return vy >= 0;
            }
        public float GetX()
            {
            return x;
            }
        public float GetY()
            {
            return y;
            }
        protected override void Go()
            {
            base.Go();
            vy += vyChange;
            }
        }
    }
