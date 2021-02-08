using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.common
    {
    public class Ball
        {
        private Timer moveTimer = new Timer();
        private SolidBrush solidBrush;
        protected Form form;
        protected Color color = Color.Red;
        protected float vx = 3;
        protected float vy = 3;
        protected int size = 50;
        protected float x = 100;
        protected float y = 100;
        protected static Random random = new Random();


        public Ball(Form form)
            {
            this.form = form;
            moveTimer.Interval = 10;
            moveTimer.Tick += moveTimer_Tick;
            }
        public void Start()
            {
            moveTimer.Start();
            }
        public void Stop()
            {
            moveTimer.Stop();
            }

        public void Show()
            {
            Draw(color);
            }
        public bool OnForm()
            {
            return x >= 0 && x + size <= form.ClientSize.Width && y + size <= form.ClientSize.Height && y >= 0;
            }
        public bool CheckClickOnBall(int x, int y)
            {
            return this.x <= x && this.x + size >= x && this.y <= y && this.y + size >= y;
            }
        public void Clear()
            {
            Draw(form.BackColor);
            }
        private void Draw(Color color)
            {
            var graphics = form.CreateGraphics();
            solidBrush = new SolidBrush(color);
            var rectangle = new RectangleF(x, y, size, size);
            graphics.FillEllipse(solidBrush, rectangle);
            }
        protected virtual void Go()
            {
            x += vx;
            y += vy;
            }
        private void moveTimer_Tick(object sender, EventArgs e)
            {
            Move();
            }
        private void Move()
            {
            Clear();
            Go();
            Show();
            }
        }
    }
