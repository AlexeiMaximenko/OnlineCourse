﻿namespace DiffusionSimulationWinFormsApp
    {
    partial class MainForm
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            this.leftRedLabel = new System.Windows.Forms.Label();
            this.leftBlueLabel = new System.Windows.Forms.Label();
            this.upRedLabel = new System.Windows.Forms.Label();
            this.upBlueLabel = new System.Windows.Forms.Label();
            this.rightRedLabel = new System.Windows.Forms.Label();
            this.rightBlueLabel = new System.Windows.Forms.Label();
            this.downRedLabel = new System.Windows.Forms.Label();
            this.downBlueLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // leftRedLabel
            // 
            this.leftRedLabel.AutoSize = true;
            this.leftRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftRedLabel.ForeColor = System.Drawing.Color.Red;
            this.leftRedLabel.Location = new System.Drawing.Point(12, 169);
            this.leftRedLabel.Name = "leftRedLabel";
            this.leftRedLabel.Size = new System.Drawing.Size(16, 16);
            this.leftRedLabel.TabIndex = 0;
            this.leftRedLabel.Text = "0";
            // 
            // leftBlueLabel
            // 
            this.leftBlueLabel.AutoSize = true;
            this.leftBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.leftBlueLabel.Location = new System.Drawing.Point(12, 195);
            this.leftBlueLabel.Name = "leftBlueLabel";
            this.leftBlueLabel.Size = new System.Drawing.Size(16, 16);
            this.leftBlueLabel.TabIndex = 1;
            this.leftBlueLabel.Text = "0";
            // 
            // upRedLabel
            // 
            this.upRedLabel.AutoSize = true;
            this.upRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upRedLabel.ForeColor = System.Drawing.Color.Red;
            this.upRedLabel.Location = new System.Drawing.Point(384, 13);
            this.upRedLabel.Name = "upRedLabel";
            this.upRedLabel.Size = new System.Drawing.Size(16, 16);
            this.upRedLabel.TabIndex = 2;
            this.upRedLabel.Text = "0";
            // 
            // upBlueLabel
            // 
            this.upBlueLabel.AutoSize = true;
            this.upBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upBlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.upBlueLabel.Location = new System.Drawing.Point(406, 13);
            this.upBlueLabel.Name = "upBlueLabel";
            this.upBlueLabel.Size = new System.Drawing.Size(16, 16);
            this.upBlueLabel.TabIndex = 3;
            this.upBlueLabel.Text = "0";
            // 
            // rightRedLabel
            // 
            this.rightRedLabel.AutoSize = true;
            this.rightRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightRedLabel.ForeColor = System.Drawing.Color.Red;
            this.rightRedLabel.Location = new System.Drawing.Point(753, 169);
            this.rightRedLabel.Name = "rightRedLabel";
            this.rightRedLabel.Size = new System.Drawing.Size(16, 16);
            this.rightRedLabel.TabIndex = 4;
            this.rightRedLabel.Text = "0";
            // 
            // rightBlueLabel
            // 
            this.rightBlueLabel.AutoSize = true;
            this.rightBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.rightBlueLabel.Location = new System.Drawing.Point(753, 195);
            this.rightBlueLabel.Name = "rightBlueLabel";
            this.rightBlueLabel.Size = new System.Drawing.Size(16, 16);
            this.rightBlueLabel.TabIndex = 5;
            this.rightBlueLabel.Text = "0";
            // 
            // downRedLabel
            // 
            this.downRedLabel.AutoSize = true;
            this.downRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downRedLabel.ForeColor = System.Drawing.Color.Red;
            this.downRedLabel.Location = new System.Drawing.Point(384, 425);
            this.downRedLabel.Name = "downRedLabel";
            this.downRedLabel.Size = new System.Drawing.Size(16, 16);
            this.downRedLabel.TabIndex = 6;
            this.downRedLabel.Text = "0";
            // 
            // downBlueLabel
            // 
            this.downBlueLabel.AutoSize = true;
            this.downBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downBlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.downBlueLabel.Location = new System.Drawing.Point(409, 424);
            this.downBlueLabel.Name = "downBlueLabel";
            this.downBlueLabel.Size = new System.Drawing.Size(16, 16);
            this.downBlueLabel.TabIndex = 7;
            this.downBlueLabel.Text = "0";
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downBlueLabel);
            this.Controls.Add(this.downRedLabel);
            this.Controls.Add(this.rightBlueLabel);
            this.Controls.Add(this.rightRedLabel);
            this.Controls.Add(this.upBlueLabel);
            this.Controls.Add(this.upRedLabel);
            this.Controls.Add(this.leftBlueLabel);
            this.Controls.Add(this.leftRedLabel);
            this.Name = "MainForm";
            this.Text = "Diffusion";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label leftRedLabel;
        private System.Windows.Forms.Label leftBlueLabel;
        private System.Windows.Forms.Label upRedLabel;
        private System.Windows.Forms.Label upBlueLabel;
        private System.Windows.Forms.Label rightRedLabel;
        private System.Windows.Forms.Label rightBlueLabel;
        private System.Windows.Forms.Label downRedLabel;
        private System.Windows.Forms.Label downBlueLabel;
        private System.Windows.Forms.Timer mainTimer;
        }
    }

