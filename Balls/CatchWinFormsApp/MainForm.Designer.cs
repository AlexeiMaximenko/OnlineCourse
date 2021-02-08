namespace CatchMeWinFormsApp
    {
    partial class MainForm
        {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
            {
            this.startButton = new System.Windows.Forms.Button();
            this.moveBallsButton = new System.Windows.Forms.Button();
            this.calculateBallsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(624, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Нарисовать 10 шариков";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // moveBallsButton
            // 
            this.moveBallsButton.Enabled = false;
            this.moveBallsButton.Location = new System.Drawing.Point(624, 41);
            this.moveBallsButton.Name = "moveBallsButton";
            this.moveBallsButton.Size = new System.Drawing.Size(164, 23);
            this.moveBallsButton.TabIndex = 2;
            this.moveBallsButton.Text = "Двигать шарики";
            this.moveBallsButton.UseVisualStyleBackColor = true;
            this.moveBallsButton.Click += new System.EventHandler(this.moveBallsButton_Click);
            // 
            // calculateBallsButton
            // 
            this.calculateBallsButton.Enabled = false;
            this.calculateBallsButton.Location = new System.Drawing.Point(624, 70);
            this.calculateBallsButton.Name = "calculateBallsButton";
            this.calculateBallsButton.Size = new System.Drawing.Size(164, 23);
            this.calculateBallsButton.TabIndex = 3;
            this.calculateBallsButton.Text = "Посчитать шарики";
            this.calculateBallsButton.UseVisualStyleBackColor = true;
            this.calculateBallsButton.Click += new System.EventHandler(this.calculateBallsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateBallsButton);
            this.Controls.Add(this.moveBallsButton);
            this.Controls.Add(this.startButton);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button moveBallsButton;
        private System.Windows.Forms.Button calculateBallsButton;
        }
    }

