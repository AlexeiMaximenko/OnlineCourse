namespace GeniyIdiotWinFormsApp
    {
    partial class PlayForm
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
            this.confirmAnswerButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.qiestionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirmAnswerButton
            // 
            this.confirmAnswerButton.Location = new System.Drawing.Point(164, 206);
            this.confirmAnswerButton.Name = "confirmAnswerButton";
            this.confirmAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.confirmAnswerButton.TabIndex = 0;
            this.confirmAnswerButton.Text = "ОК";
            this.confirmAnswerButton.UseVisualStyleBackColor = true;
            this.confirmAnswerButton.Click += new System.EventHandler(this.ConfirmAnswerButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(59, 73);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(61, 13);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос № ";
            // 
            // qiestionTextLabel
            // 
            this.qiestionTextLabel.AutoSize = true;
            this.qiestionTextLabel.Location = new System.Drawing.Point(23, 143);
            this.qiestionTextLabel.Name = "qiestionTextLabel";
            this.qiestionTextLabel.Size = new System.Drawing.Size(68, 13);
            this.qiestionTextLabel.TabIndex = 2;
            this.qiestionTextLabel.Text = "Неизвестно";
            // 
            // userAnswerBox
            // 
            this.userAnswerBox.Location = new System.Drawing.Point(148, 180);
            this.userAnswerBox.Name = "userAnswerBox";
            this.userAnswerBox.Size = new System.Drawing.Size(100, 20);
            this.userAnswerBox.TabIndex = 3;
            this.userAnswerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserAnswerBox_KeyDown);
            // 
            // playForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 321);
            this.Controls.Add(this.userAnswerBox);
            this.Controls.Add(this.qiestionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.confirmAnswerButton);
            this.Name = "playForm";
            this.Text = "Гений-Идиот";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button confirmAnswerButton;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label qiestionTextLabel;
        private System.Windows.Forms.TextBox userAnswerBox;
        }
    }