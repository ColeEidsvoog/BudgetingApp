namespace BudgetingApp
{
    partial class SignUp
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpGroupBox = new System.Windows.Forms.GroupBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signUpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Budget Booster!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIGN UP";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(24, 76);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(204, 20);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(24, 143);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(204, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // signUpGroupBox
            // 
            this.signUpGroupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.signUpGroupBox.Controls.Add(this.signUpButton);
            this.signUpGroupBox.Controls.Add(this.label4);
            this.signUpGroupBox.Controls.Add(this.label3);
            this.signUpGroupBox.Controls.Add(this.passwordTextBox);
            this.signUpGroupBox.Controls.Add(this.emailTextBox);
            this.signUpGroupBox.Controls.Add(this.label2);
            this.signUpGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signUpGroupBox.Location = new System.Drawing.Point(110, 83);
            this.signUpGroupBox.Name = "signUpGroupBox";
            this.signUpGroupBox.Size = new System.Drawing.Size(246, 239);
            this.signUpGroupBox.TabIndex = 6;
            this.signUpGroupBox.TabStop = false;
            this.signUpGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(24, 198);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(204, 23);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.signUpGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.signUpGroupBox.ResumeLayout(false);
            this.signUpGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox signUpGroupBox;
        private System.Windows.Forms.Button signUpButton;
    }
}

