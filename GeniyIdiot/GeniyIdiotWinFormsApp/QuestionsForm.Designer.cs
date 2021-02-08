namespace GeniyIdiotWinFormsApp
    {
    partial class QuestionsForm
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
            this.userAddQuestionBox = new System.Windows.Forms.TextBox();
            this.userAddAnswerBox = new System.Windows.Forms.TextBox();
            this.userQuestionLabel = new System.Windows.Forms.Label();
            this.userAnswerLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addQuestionsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userDeleteQuestionsBox = new System.Windows.Forms.TextBox();
            this.numberDeleteQuestionLabel = new System.Windows.Forms.Label();
            this.deleteQuestionsButton = new System.Windows.Forms.Button();
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.numberQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userAddQuestionBox
            // 
            this.userAddQuestionBox.Location = new System.Drawing.Point(581, 264);
            this.userAddQuestionBox.Name = "userAddQuestionBox";
            this.userAddQuestionBox.Size = new System.Drawing.Size(188, 20);
            this.userAddQuestionBox.TabIndex = 2;
            this.userAddQuestionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userAddAnswerBox
            // 
            this.userAddAnswerBox.Location = new System.Drawing.Point(581, 290);
            this.userAddAnswerBox.Name = "userAddAnswerBox";
            this.userAddAnswerBox.Size = new System.Drawing.Size(188, 20);
            this.userAddAnswerBox.TabIndex = 3;
            this.userAddAnswerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userQuestionLabel
            // 
            this.userQuestionLabel.AutoSize = true;
            this.userQuestionLabel.Location = new System.Drawing.Point(513, 267);
            this.userQuestionLabel.Name = "userQuestionLabel";
            this.userQuestionLabel.Size = new System.Drawing.Size(47, 13);
            this.userQuestionLabel.TabIndex = 4;
            this.userQuestionLabel.Text = "Вопрос:";
            // 
            // userAnswerLabel
            // 
            this.userAnswerLabel.AutoSize = true;
            this.userAnswerLabel.Location = new System.Drawing.Point(513, 293);
            this.userAnswerLabel.Name = "userAnswerLabel";
            this.userAnswerLabel.Size = new System.Drawing.Size(40, 13);
            this.userAnswerLabel.TabIndex = 5;
            this.userAnswerLabel.Text = "Ответ:";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(618, 326);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Добавить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(372, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Назад";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // addQuestionsLabel
            // 
            this.addQuestionsLabel.AutoSize = true;
            this.addQuestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuestionsLabel.Location = new System.Drawing.Point(546, 217);
            this.addQuestionsLabel.Name = "addQuestionsLabel";
            this.addQuestionsLabel.Size = new System.Drawing.Size(207, 20);
            this.addQuestionsLabel.TabIndex = 8;
            this.addQuestionsLabel.Text = " Добавление вопросов:";
            this.addQuestionsLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(546, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Удаление вопросов:";
            // 
            // userDeleteQuestionsBox
            // 
            this.userDeleteQuestionsBox.Location = new System.Drawing.Point(581, 70);
            this.userDeleteQuestionsBox.Name = "userDeleteQuestionsBox";
            this.userDeleteQuestionsBox.Size = new System.Drawing.Size(188, 20);
            this.userDeleteQuestionsBox.TabIndex = 10;
            this.userDeleteQuestionsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberDeleteQuestionLabel
            // 
            this.numberDeleteQuestionLabel.AutoSize = true;
            this.numberDeleteQuestionLabel.Location = new System.Drawing.Point(513, 73);
            this.numberDeleteQuestionLabel.Name = "numberDeleteQuestionLabel";
            this.numberDeleteQuestionLabel.Size = new System.Drawing.Size(61, 13);
            this.numberDeleteQuestionLabel.TabIndex = 11;
            this.numberDeleteQuestionLabel.Text = "Вопрос № ";
            // 
            // deleteQuestionsButton
            // 
            this.deleteQuestionsButton.Location = new System.Drawing.Point(618, 108);
            this.deleteQuestionsButton.Name = "deleteQuestionsButton";
            this.deleteQuestionsButton.Size = new System.Drawing.Size(75, 23);
            this.deleteQuestionsButton.TabIndex = 12;
            this.deleteQuestionsButton.Text = "Удалить";
            this.deleteQuestionsButton.UseVisualStyleBackColor = true;
            this.deleteQuestionsButton.Click += new System.EventHandler(this.DeleteQuestionsButton_Click);
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberQuestions,
            this.questionsText});
            this.questionsDataGridView.Location = new System.Drawing.Point(13, 13);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.Size = new System.Drawing.Size(434, 348);
            this.questionsDataGridView.TabIndex = 13;
            // 
            // numberQuestions
            // 
            this.numberQuestions.HeaderText = "Номер вопроса";
            this.numberQuestions.Name = "numberQuestions";
            // 
            // questionsText
            // 
            this.questionsText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questionsText.HeaderText = "Текст вопроса";
            this.questionsText.Name = "questionsText";
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionsDataGridView);
            this.Controls.Add(this.deleteQuestionsButton);
            this.Controls.Add(this.numberDeleteQuestionLabel);
            this.Controls.Add(this.userDeleteQuestionsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addQuestionsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.userAnswerLabel);
            this.Controls.Add(this.userQuestionLabel);
            this.Controls.Add(this.userAddAnswerBox);
            this.Controls.Add(this.userAddQuestionBox);
            this.Name = "QuestionsForm";
            this.Text = "Гений-Идиот";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.TextBox userAddQuestionBox;
        private System.Windows.Forms.TextBox userAddAnswerBox;
        private System.Windows.Forms.Label userQuestionLabel;
        private System.Windows.Forms.Label userAnswerLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label addQuestionsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userDeleteQuestionsBox;
        private System.Windows.Forms.Label numberDeleteQuestionLabel;
        private System.Windows.Forms.Button deleteQuestionsButton;
        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionsText;
        }
    }