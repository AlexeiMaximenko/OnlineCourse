using Balls.common;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
    {
    class FruitBall : Ball
        {
        private float vyChange = 0.12f;
        public FruitBall(Form form) : base(form)
            {
            x = random.Next(50, form.ClientSize.Width - 50);
            vy = (float)((random.NextDouble() * -4) - 5);
            vx = random.Next(-2000, 2001) / 1000;
            size = 40;
            y = form.ClientSize.Height - size;
            }
        protected override void Go()
            {
            base.Go();
            vy += vyChange;
            }
        public float GetVy()
            {
            return vy;
            }
        }
    }
