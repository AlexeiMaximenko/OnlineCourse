using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DiffusionSimulationWinFormsApp
    {
    public partial class MainForm : Form
        {
        private List<GasMolecule> firstGasMolecules;
        private List<GasMolecule> secondGasMolecules;
        private int countMolecules = 10;
        private int firstMoleculeUpCount;
        private int firstMoleculeDownCount;
        private int firstMoleculeLeftCount;
        private int firstMoleculeRightCount;
        private int secondMoleculeUpCount;
        private int secondMoleculeDownCount;
        private int secondMoleculeLeftCount;
        private int secondMoleculeRightCount;
        private int countFirstMoleculeOnLeftSide;
        private int countSecondMoleculeOnLeftSide;
        private int countFirstMoleculeOnRightSide;
        private int countSecondMoleculeOnRightSide;

        public MainForm()
            {
            InitializeComponent();
            firstGasMolecules = new List<GasMolecule>();
            secondGasMolecules = new List<GasMolecule>();
            }

        private void CreateAndShowMolecules()
            {
            for (int i = 0; i < countMolecules; i++)
                {
                firstMoleculeUpCount = 0;
                firstMoleculeDownCount = 0;
                firstMoleculeLeftCount = 0;
                firstMoleculeRightCount = 0;
                secondMoleculeUpCount = 0;
                secondMoleculeDownCount = 0;
                secondMoleculeLeftCount = 0;
                secondMoleculeRightCount = 0;
                UpdateMoleculeHitSideCountLabel();
                var redGasMolecule = new GasMolecule(this, MoleculeLocation.Left, Color.Red);
                firstGasMolecules.Add(redGasMolecule);
                redGasMolecule.Show();
                redGasMolecule.TuchSide += FirstGasMolecule_TuchSide;
                var blueGasMolecule = new GasMolecule(this, MoleculeLocation.Right, Color.Blue, 2, 20);
                secondGasMolecules.Add(blueGasMolecule);
                blueGasMolecule.Show();
                blueGasMolecule.TuchSide += SecondGasMolecule_TuchSide;
                }
            }

        private void FirstGasMolecule_TuchSide(object sender, TuchSideEventArgs e)
            {
            if (e.Side == Side.Up)
                {
                firstMoleculeUpCount++;
                }
            if (e.Side == Side.Down)
                {
                firstMoleculeDownCount++;
                }
            if (e.Side == Side.Left)
                {
                firstMoleculeLeftCount++;
                }
            if (e.Side == Side.Right)
                {
                firstMoleculeRightCount++;
                }
            }

        private void SecondGasMolecule_TuchSide(object sender, TuchSideEventArgs e)
            {
            if (e.Side == Side.Up)
                {
                secondMoleculeUpCount++;
                }
            if (e.Side == Side.Down)
                {
                secondMoleculeDownCount++;
                }
            if (e.Side == Side.Left)
                {
                secondMoleculeLeftCount++;
                }
            if (e.Side == Side.Right)
                {
                secondMoleculeRightCount++;
                }
            }

        private void MainForm_Click(object sender, EventArgs e)
            {
            if (firstGasMolecules.Count == 0 && secondGasMolecules.Count == 0)
                {
                CreateAndShowMolecules();
                return;
                }
            if (mainTimer.Enabled == false)
                {
                foreach (var molecule in firstGasMolecules)
                    {
                    molecule.Start();
                    }

                foreach (var molecule in secondGasMolecules)
                    {
                    molecule.Start();
                    }
                mainTimer.Start();
                return;
                }
            EndSimulation();
            }

        private void UpdateMoleculeHitSideCountLabel()
            {
            upRedLabel.Text = firstMoleculeUpCount.ToString();
            upBlueLabel.Text = secondMoleculeUpCount.ToString();
            leftRedLabel.Text = firstMoleculeLeftCount.ToString();
            leftBlueLabel.Text = secondMoleculeLeftCount.ToString();
            rightRedLabel.Text = firstMoleculeRightCount.ToString();
            rightBlueLabel.Text = secondMoleculeRightCount.ToString();
            downRedLabel.Text = firstMoleculeDownCount.ToString();
            downBlueLabel.Text = secondMoleculeDownCount.ToString();
            }

        private void MainTimer_Tick(object sender, EventArgs e)
            {
            UpdateMoleculeHitSideCountLabel();
            countFirstMoleculeOnLeftSide = 0;
            countSecondMoleculeOnLeftSide = 0;
            countFirstMoleculeOnRightSide = 0;
            countSecondMoleculeOnRightSide = 0;
            foreach (var molecule in firstGasMolecules)
                {
                if (molecule.GetMoleculeLocation() == MoleculeLocation.Left)
                    {
                    countFirstMoleculeOnLeftSide++;
                    continue;
                    }
                countFirstMoleculeOnRightSide++;
                }
            foreach (var molecule in secondGasMolecules)
                {
                if (molecule.GetMoleculeLocation() == MoleculeLocation.Left)
                    {
                    countSecondMoleculeOnLeftSide++;
                    continue;
                    }
                countSecondMoleculeOnRightSide++;
                }
            if (countFirstMoleculeOnLeftSide == countSecondMoleculeOnLeftSide || countFirstMoleculeOnRightSide == countSecondMoleculeOnRightSide)
                {
                EndSimulation();
                }
            }

        private void EndSimulation()
            {
            foreach (var molecule in firstGasMolecules)
                {
                molecule.Clear();
                molecule.Stop();
                }
            firstGasMolecules.Clear();
            foreach (var molecule in secondGasMolecules)
                {
                molecule.Clear();
                molecule.Stop();
                }
            secondGasMolecules.Clear();
            mainTimer.Stop();
            MessageBox.Show($"Давление на стенки 1 малекулы: {firstMoleculeUpCount + firstMoleculeDownCount + firstMoleculeLeftCount + firstMoleculeRightCount} балла\nДавление на стенки 2 малекулы: {secondMoleculeUpCount + secondMoleculeDownCount + secondMoleculeLeftCount + secondMoleculeRightCount} балла");
            }
        }
    }