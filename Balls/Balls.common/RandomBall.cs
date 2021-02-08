
using System.Drawing;
using System.Windows.Forms;

namespace Balls.common
    {
    public class RandomBall : RandomMoveAndPointBall
        {
        public RandomBall(Form form) : base(form)
            {
            size = random.Next(20, 60);
            color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }
        }
    }
