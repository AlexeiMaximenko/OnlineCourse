using System;

namespace DiffusionSimulationWinFormsApp
    {
    public class TuchSideEventArgs : EventArgs
        {
        public Side Side;

        public TuchSideEventArgs(Side side)
            {
            this.Side = side;
            }
        }
    }