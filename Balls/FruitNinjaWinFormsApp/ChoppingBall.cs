using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
    {
    class ChoppingBall : FruitBall
        {
        public ChoppingBall(Form form, int x, int y, float vy) : base(form)
            {
            size /= 2;
            this.x = x;
            this.y = y;
            this.vy = vy;
            }
        }
    }
