using System.Windows.Forms;

namespace Balls.common
    {
    class PointBall : Ball
        {
        public PointBall(Form form, int x, int y) : base(form)
            {
            base.x = x - size / 2;
            base.y = y - size / 2;
            }
        }
    }
