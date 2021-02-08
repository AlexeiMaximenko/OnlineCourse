namespace GeniyIdiotWinFormsApp
    {
    partial class DataForm
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
            this.userResultDataGridView = new System.Windows.Forms.DataGridView();
            this.userFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCountRightAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dontHaveDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultDataGridView
            // 
            this.userResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userFullName,
            this.userCountRightAnswers,
            this.userDiagnosis});
            this.userResultDataGridView.Location = new System.Drawing.Point(13, 12);
            this.userResultDataGridView.Name = "userResultDataGridView";
            this.userResultDataGridView.Size = new System.Drawing.Size(344, 407);
            this.userResultDataGridView.TabIndex = 0;
            this.userResultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // userFullName
            // 
            this.userFullName.HeaderText = "Имя пользователя";
            this.userFullName.Name = "userFullName";
            // 
            // userCountRightAnswers
            // 
            this.userCountRightAnswers.HeaderText = "Колличество правильных ответов";
            this.userCountRightAnswers.Name = "userCountRightAnswers";
            // 
            // userDiagnosis
            // 
            this.userDiagnosis.HeaderText = "Диагноз";
            this.userDiagnosis.Name = "userDiagnosis";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(157, 438);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // dontHaveDataLabel
            // 
            this.dontHaveDataLabel.AutoSize = true;
            this.dontHaveDataLabel.Location = new System.Drawing.Point(90, 216);
            this.dontHaveDataLabel.Name = "dontHaveDataLabel";
            this.dontHaveDataLabel.Size = new System.Drawing.Size(0, 13);
            this.dontHaveDataLabel.TabIndex = 2;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 489);
            this.Controls.Add(this.dontHaveDataLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.userResultDataGridView);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.DataGridView userResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCountRightAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDiagnosis;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label dontHaveDataLabel;
        }
    }