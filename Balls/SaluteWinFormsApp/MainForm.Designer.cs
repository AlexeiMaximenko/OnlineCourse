namespace SaluteWinFormsApp
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
            this.createSaluteButton = new System.Windows.Forms.Button();
            this.explosionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // createSaluteButton
            // 
            this.createSaluteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createSaluteButton.Location = new System.Drawing.Point(644, 13);
            this.createSaluteButton.Name = "createSaluteButton";
            this.createSaluteButton.Size = new System.Drawing.Size(145, 57);
            this.createSaluteButton.TabIndex = 0;
            this.createSaluteButton.Text = "Создать салют!";
            this.createSaluteButton.UseVisualStyleBackColor = true;
            this.createSaluteButton.Click += new System.EventHandler(this.CreateSaluteButton_Click);
            // 
            // explosionTimer
            // 
            this.explosionTimer.Interval = 10;
            this.explosionTimer.Tick += new System.EventHandler(this.ExplosionTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createSaluteButton);
            this.Name = "MainForm";
            this.Text = "Salute";
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Button createSaluteButton;
        private System.Windows.Forms.Timer explosionTimer;
        }
    }

