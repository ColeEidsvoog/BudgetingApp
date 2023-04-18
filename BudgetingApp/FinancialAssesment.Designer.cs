namespace BudgetingApp
{
    partial class FinancialAssessment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.saveMoneyGeneralCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eraseDebtCheckBox = new System.Windows.Forms.CheckBox();
            this.saveRetirementCheckBox = new System.Windows.Forms.CheckBox();
            this.saveCollegeCheckBox = new System.Windows.Forms.CheckBox();
            this.personalLearningCheckBox = new System.Windows.Forms.CheckBox();
            this.otherCheckBox = new System.Windows.Forms.CheckBox();
            this.forPurchaseCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.savedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.financialAssesmentGroupBox = new System.Windows.Forms.GroupBox();
            this.financialAssesmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(395, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Assesment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly income after taxes";
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(325, 28);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(130, 20);
            this.incomeTextBox.TabIndex = 2;
            this.incomeTextBox.TextChanged += new System.EventHandler(this.incomeTextBox_TextChanged);
            // 
            // saveMoneyGeneralCheckBox
            // 
            this.saveMoneyGeneralCheckBox.AutoSize = true;
            this.saveMoneyGeneralCheckBox.Location = new System.Drawing.Point(247, 146);
            this.saveMoneyGeneralCheckBox.Name = "saveMoneyGeneralCheckBox";
            this.saveMoneyGeneralCheckBox.Size = new System.Drawing.Size(129, 17);
            this.saveMoneyGeneralCheckBox.TabIndex = 3;
            this.saveMoneyGeneralCheckBox.Text = "Save money (general)";
            this.saveMoneyGeneralCheckBox.UseVisualStyleBackColor = true;
            this.saveMoneyGeneralCheckBox.CheckedChanged += new System.EventHandler(this.saveMoneyGeneralCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(117, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Why do you want to start budgeting? (Please check all that apply)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eraseDebtCheckBox
            // 
            this.eraseDebtCheckBox.AutoSize = true;
            this.eraseDebtCheckBox.Location = new System.Drawing.Point(247, 169);
            this.eraseDebtCheckBox.Name = "eraseDebtCheckBox";
            this.eraseDebtCheckBox.Size = new System.Drawing.Size(80, 17);
            this.eraseDebtCheckBox.TabIndex = 5;
            this.eraseDebtCheckBox.Text = "Erase debt ";
            this.eraseDebtCheckBox.UseVisualStyleBackColor = true;
            this.eraseDebtCheckBox.CheckedChanged += new System.EventHandler(this.eraseDebtCheckBox_CheckedChanged);
            // 
            // saveRetirementCheckBox
            // 
            this.saveRetirementCheckBox.AutoSize = true;
            this.saveRetirementCheckBox.Location = new System.Drawing.Point(247, 192);
            this.saveRetirementCheckBox.Name = "saveRetirementCheckBox";
            this.saveRetirementCheckBox.Size = new System.Drawing.Size(118, 17);
            this.saveRetirementCheckBox.TabIndex = 6;
            this.saveRetirementCheckBox.Text = "Save for retirement ";
            this.saveRetirementCheckBox.UseVisualStyleBackColor = true;
            this.saveRetirementCheckBox.CheckedChanged += new System.EventHandler(this.saveRetirementCheckBox_CheckedChanged);
            // 
            // saveCollegeCheckBox
            // 
            this.saveCollegeCheckBox.AutoSize = true;
            this.saveCollegeCheckBox.Location = new System.Drawing.Point(247, 215);
            this.saveCollegeCheckBox.Name = "saveCollegeCheckBox";
            this.saveCollegeCheckBox.Size = new System.Drawing.Size(103, 17);
            this.saveCollegeCheckBox.TabIndex = 7;
            this.saveCollegeCheckBox.Text = "Save for college";
            this.saveCollegeCheckBox.UseVisualStyleBackColor = true;
            this.saveCollegeCheckBox.CheckedChanged += new System.EventHandler(this.saveCollegeCheckBox_CheckedChanged);
            // 
            // personalLearningCheckBox
            // 
            this.personalLearningCheckBox.AutoSize = true;
            this.personalLearningCheckBox.Location = new System.Drawing.Point(247, 238);
            this.personalLearningCheckBox.Name = "personalLearningCheckBox";
            this.personalLearningCheckBox.Size = new System.Drawing.Size(111, 17);
            this.personalLearningCheckBox.TabIndex = 8;
            this.personalLearningCheckBox.Text = "Personal Learning";
            this.personalLearningCheckBox.UseVisualStyleBackColor = true;
            this.personalLearningCheckBox.CheckedChanged += new System.EventHandler(this.personalLearningCheckBox_CheckedChanged);
            // 
            // otherCheckBox
            // 
            this.otherCheckBox.AutoSize = true;
            this.otherCheckBox.Location = new System.Drawing.Point(247, 284);
            this.otherCheckBox.Name = "otherCheckBox";
            this.otherCheckBox.Size = new System.Drawing.Size(52, 17);
            this.otherCheckBox.TabIndex = 9;
            this.otherCheckBox.Text = "Other";
            this.otherCheckBox.UseVisualStyleBackColor = true;
            this.otherCheckBox.CheckedChanged += new System.EventHandler(this.otherCheckBox_CheckedChanged);
            // 
            // forPurchaseCheckBox
            // 
            this.forPurchaseCheckBox.AutoSize = true;
            this.forPurchaseCheckBox.Location = new System.Drawing.Point(247, 261);
            this.forPurchaseCheckBox.Name = "forPurchaseCheckBox";
            this.forPurchaseCheckBox.Size = new System.Drawing.Size(113, 17);
            this.forPurchaseCheckBox.TabIndex = 10;
            this.forPurchaseCheckBox.Text = "Save for purchase";
            this.forPurchaseCheckBox.UseVisualStyleBackColor = true;
            this.forPurchaseCheckBox.CheckedChanged += new System.EventHandler(this.forPurchaseCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Money saved per month";
            // 
            // savedTextBox
            // 
            this.savedTextBox.Location = new System.Drawing.Point(325, 65);
            this.savedTextBox.Name = "savedTextBox";
            this.savedTextBox.Size = new System.Drawing.Size(130, 20);
            this.savedTextBox.TabIndex = 12;
            this.savedTextBox.TextChanged += new System.EventHandler(this.savedTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "User:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(53, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(16, 13);
            this.userNameLabel.TabIndex = 14;
            this.userNameLabel.Text = "...";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(247, 346);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(151, 35);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Next";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // financialAssesmentGroupBox
            // 
            this.financialAssesmentGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.financialAssesmentGroupBox.Controls.Add(this.label2);
            this.financialAssesmentGroupBox.Controls.Add(this.submitButton);
            this.financialAssesmentGroupBox.Controls.Add(this.incomeTextBox);
            this.financialAssesmentGroupBox.Controls.Add(this.label4);
            this.financialAssesmentGroupBox.Controls.Add(this.savedTextBox);
            this.financialAssesmentGroupBox.Controls.Add(this.otherCheckBox);
            this.financialAssesmentGroupBox.Controls.Add(this.forPurchaseCheckBox);
            this.financialAssesmentGroupBox.Controls.Add(this.label3);
            this.financialAssesmentGroupBox.Controls.Add(this.saveMoneyGeneralCheckBox);
            this.financialAssesmentGroupBox.Controls.Add(this.personalLearningCheckBox);
            this.financialAssesmentGroupBox.Controls.Add(this.eraseDebtCheckBox);
            this.financialAssesmentGroupBox.Controls.Add(this.saveCollegeCheckBox);
            this.financialAssesmentGroupBox.Controls.Add(this.saveRetirementCheckBox);
            this.financialAssesmentGroupBox.Location = new System.Drawing.Point(234, 118);
            this.financialAssesmentGroupBox.Name = "financialAssesmentGroupBox";
            this.financialAssesmentGroupBox.Size = new System.Drawing.Size(639, 427);
            this.financialAssesmentGroupBox.TabIndex = 16;
            this.financialAssesmentGroupBox.TabStop = false;
            // 
            // FinancialAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 646);
            this.Controls.Add(this.financialAssesmentGroupBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FinancialAssessment";
            this.Text = "Financial Assesment";
            this.Load += new System.EventHandler(this.FinancialAssessment_Load_1);
            this.financialAssesmentGroupBox.ResumeLayout(false);
            this.financialAssesmentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.CheckBox saveMoneyGeneralCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox eraseDebtCheckBox;
        private System.Windows.Forms.CheckBox saveRetirementCheckBox;
        private System.Windows.Forms.CheckBox saveCollegeCheckBox;
        private System.Windows.Forms.CheckBox personalLearningCheckBox;
        private System.Windows.Forms.CheckBox otherCheckBox;
        private System.Windows.Forms.CheckBox forPurchaseCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox savedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox financialAssesmentGroupBox;
    }
}