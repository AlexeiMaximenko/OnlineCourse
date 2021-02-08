using System.Windows.Forms;

namespace Balls.common
    {
    public class RandomPointBall : Ball
        {
        public RandomPointBall(Form form) : base(form)
            {
            x = random.Next(form.ClientSize.Width - size);
            y = random.Next(form.ClientSize.Height - size);
            }
        }
    }
