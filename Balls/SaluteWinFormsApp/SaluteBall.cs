using Balls.common;
using System.Windows.Forms;

namespace SaluteWinFormsApp
    {
    class SaluteBall : RandomBall
        {
        private float vyChange = 0.1f;
        public SaluteBall(Form form, float x, float y) : base(form)
            {
            size = random.Next(10, 20);
            this.x = x;
            this.y = y;
            vx = random.Next(-4, 5);
            vy = random.Next(-4, 0) - 2;
            }
        protected override void Go()
            {
            base.Go();
            vy += vyChange;
            }
        }
    }
