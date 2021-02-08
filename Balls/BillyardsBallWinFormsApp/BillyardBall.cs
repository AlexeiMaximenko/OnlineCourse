using Balls.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillyardsBallWinFormsApp
    {
    public class BillyardBall : RandomMoveAndPointBall
        {
        private int upCount;
        private int downCount;
        private int leftCount;
        private int rightCount;
        public BillyardBall(Form form) : base(form)
            {
            upCount = 0;
            downCount = 0;
            leftCount = 0;
            rightCount = 0;
            }
        protected override void Go()
            {
            base.Go();
            if (x + size >= form.ClientSize.Width)
                {
                vx = -vx;
                rightCount++;
                }
            if (x <= 0)
                {
                vx = -vx;
                leftCount++;
                }
            if (y + size >= form.ClientSize.Height)
                {
                vy = -vy;
                downCount++;
                }
            if(y <= 0)
                {
                vy = -vy;
                upCount++;
                }
            
            }
        public int GetUpCount()
            {
            return upCount;
            }
        public int GetDownCount()
            {
            return downCount;
            }
        public int GetRightCount()
            {
            return rightCount;
            }
        public int GetLeftCount()
                {
                return leftCount;
                }
        }
    }
