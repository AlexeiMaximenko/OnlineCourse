namespace GeniyIdiotWinFormsApp
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.playStartButton = new System.Windows.Forms.Button();
            this.dataStartButton = new System.Windows.Forms.Button();
            this.questionsStartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLabel.Location = new System.Drawing.Point(-1, 9);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(522, 31);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "Добро пожаловать в игру \"Гений-Идиот\"";
            this.helloLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // playStartButton
            // 
            this.playStartButton.Location = new System.Drawing.Point(140, 59);
            this.playStartButton.Name = "playStartButton";
            this.playStartButton.Size = new System.Drawing.Size(243, 66);
            this.playStartButton.TabIndex = 2;
            this.playStartButton.Text = "Начать игру";
            this.playStartButton.UseVisualStyleBackColor = true;
            this.playStartButton.Click += new System.EventHandler(this.PlayStartButton_Click);
            // 
            // dataStartButton
            // 
            this.dataStartButton.Location = new System.Drawing.Point(163, 131);
            this.dataStartButton.Name = "dataStartButton";
            this.dataStartButton.Size = new System.Drawing.Size(195, 53);
            this.dataStartButton.TabIndex = 3;
            this.dataStartButton.Text = "Прошлые результаты игры";
            this.dataStartButton.UseVisualStyleBackColor = true;
            this.dataStartButton.Click += new System.EventHandler(this.DataStartButton_Click);
            // 
            // questionsStartButton
            // 
            this.questionsStartButton.Location = new System.Drawing.Point(163, 190);
            this.questionsStartButton.Name = "questionsStartButton";
            this.questionsStartButton.Size = new System.Drawing.Size(195, 53);
            this.questionsStartButton.TabIndex = 4;
            this.questionsStartButton.Text = "Вопросы";
            this.questionsStartButton.UseVisualStyleBackColor = true;
            this.questionsStartButton.Click += new System.EventHandler(this.QuestionsStartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(223, 311);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = " Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 377);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.questionsStartButton);
            this.Controls.Add(this.dataStartButton);
            this.Controls.Add(this.playStartButton);
            this.Controls.Add(this.helloLabel);
            this.Name = "mainForm";
            this.Text = "Гений-Идиот";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button playStartButton;
        private System.Windows.Forms.Button dataStartButton;
        private System.Windows.Forms.Button questionsStartButton;
        private System.Windows.Forms.Button exitButton;
        }
    }

