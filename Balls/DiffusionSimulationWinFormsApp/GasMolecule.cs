using Balls.common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiffusionSimulationWinFormsApp
    {
    public class GasMolecule : Ball
        {
        public event EventHandler<TuchSideEventArgs> TuchSide;

        public GasMolecule(Form form, MoleculeLocation location, Color colorMolecule) : this(form, location, colorMolecule, 3, 15)
            {
            }

        public GasMolecule(Form form, MoleculeLocation location, Color colorMolecule, int speedMolecule, int sizeMolecule) : base(form)
            {
            color = colorMolecule;
            size = sizeMolecule;
            vx = GetRandomSign(random.Next(1, speedMolecule));
            vy = GetRandomSign(random.Next(1, speedMolecule));
            if (location == MoleculeLocation.Left)
                {
                x = random.Next(0 + size, form.ClientSize.Width / 2 - size);
                y = random.Next(0 + size, form.ClientSize.Height - size);
                }
            if (location == MoleculeLocation.Right)
                {
                x = random.Next(form.ClientSize.Width / 2 + size, form.ClientSize.Width - size);
                y = random.Next(0 + size, form.ClientSize.Height - size);
                }
            }

        public MoleculeLocation GetMoleculeLocation()
            {
            if (x < form.ClientSize.Width / 2 - size)
                {
                return MoleculeLocation.Left;
                }
            return MoleculeLocation.Right;
            }

        protected override void Go()
            {
            base.Go();
            if (x + size >= form.ClientSize.Width)
                {
                vx = -vx;
                TuchSide?.Invoke(this, new TuchSideEventArgs(Side.Right));
                }
            if (x <= 0)
                {
                vx = -vx;
                TuchSide?.Invoke(this, new TuchSideEventArgs(Side.Left));
                }
            if (y + size >= form.ClientSize.Height)
                {
                vy = -vy;
                TuchSide?.Invoke(this, new TuchSideEventArgs(Side.Down));
                }
            if (y <= 0)
                {
                vy = -vy;
                TuchSide?.Invoke(this, new TuchSideEventArgs(Side.Up));
                }
            }

        private int GetRandomSign(int number)
            {
            var massive = new int[2] { -number, number };
            return massive[random.Next(2)];
            }
        }
    }