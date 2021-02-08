using System.Windows.Forms;

namespace Balls.common
    {
    public class RandomMoveAndPointBall : RandomPointBall
        {
        public RandomMoveAndPointBall(Form form) : base(form)
            {
            vx = random.Next(-5, 6);
            vy = random.Next(-5, 6);
            }
        }
    }
