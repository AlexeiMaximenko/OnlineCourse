namespace ClickCatchWinFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.showBallsButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.countCatchBallsLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // showBallsButton
            // 
            this.showBallsButton.Location = new System.Drawing.Point(630, 12);
            this.showBallsButton.Name = "showBallsButton";
            this.showBallsButton.Size = new System.Drawing.Size(158, 23);
            this.showBallsButton.TabIndex = 0;
            this.showBallsButton.Text = "Создать 10 шариков!";
            this.showBallsButton.UseVisualStyleBackColor = true;
            this.showBallsButton.Click += new System.EventHandler(this.showBallsButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Enabled = false;
            this.startGameButton.Location = new System.Drawing.Point(630, 41);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(158, 23);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Начать игру!";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // countCatchBallsLabel
            // 
            this.countCatchBallsLabel.AutoSize = true;
            this.countCatchBallsLabel.Location = new System.Drawing.Point(12, 17);
            this.countCatchBallsLabel.Name = "countCatchBallsLabel";
            this.countCatchBallsLabel.Size = new System.Drawing.Size(185, 13);
            this.countCatchBallsLabel.TabIndex = 2;
            this.countCatchBallsLabel.Text = "Количество пойманных шариков: 0";
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countCatchBallsLabel);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.showBallsButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button showBallsButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label countCatchBallsLabel;
        private System.Windows.Forms.Timer mainTimer;
        }
    }

