namespace BudgetingApp
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.financialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.reportListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mostMoneyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.overUnderBudgetLabel = new System.Windows.Forms.Label();
            this.savingReasonLabel = new System.Windows.Forms.Label();
            this.savingLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.savingLinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.savingLinkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart)).BeginInit();
            this.SuspendLayout();
            // 
            // financialChart
            // 
            chartArea1.Name = "ChartArea1";
            this.financialChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.financialChart.Legends.Add(legend1);
            this.financialChart.Location = new System.Drawing.Point(670, 12);
            this.financialChart.Name = "financialChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.financialChart.Series.Add(series1);
            this.financialChart.Size = new System.Drawing.Size(478, 622);
            this.financialChart.TabIndex = 0;
            this.financialChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(221, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Financial Report";
            // 
            // reportListBox
            // 
            this.reportListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportListBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.reportListBox.FormattingEnabled = true;
            this.reportListBox.ItemHeight = 16;
            this.reportListBox.Location = new System.Drawing.Point(60, 78);
            this.reportListBox.Name = "reportListBox";
            this.reportListBox.Size = new System.Drawing.Size(593, 164);
            this.reportListBox.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(60, 599);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User: ";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(47, 12);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(16, 13);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "You spent the most money on:";
            // 
            // mostMoneyLabel
            // 
            this.mostMoneyLabel.AutoSize = true;
            this.mostMoneyLabel.Location = new System.Drawing.Point(215, 291);
            this.mostMoneyLabel.Name = "mostMoneyLabel";
            this.mostMoneyLabel.Size = new System.Drawing.Size(16, 13);
            this.mostMoneyLabel.TabIndex = 7;
            this.mostMoneyLabel.Text = "...";
            this.mostMoneyLabel.Click += new System.EventHandler(this.mostMoneyLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "You are:";
            // 
            // overUnderBudgetLabel
            // 
            this.overUnderBudgetLabel.AutoSize = true;
            this.overUnderBudgetLabel.Location = new System.Drawing.Point(102, 319);
            this.overUnderBudgetLabel.Name = "overUnderBudgetLabel";
            this.overUnderBudgetLabel.Size = new System.Drawing.Size(16, 13);
            this.overUnderBudgetLabel.TabIndex = 9;
            this.overUnderBudgetLabel.Text = "...";
            // 
            // savingReasonLabel
            // 
            this.savingReasonLabel.AutoSize = true;
            this.savingReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingReasonLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.savingReasonLabel.Location = new System.Drawing.Point(59, 393);
            this.savingReasonLabel.Name = "savingReasonLabel";
            this.savingReasonLabel.Size = new System.Drawing.Size(572, 20);
            this.savingReasonLabel.TabIndex = 10;
            this.savingReasonLabel.Text = "Based on your saving reason selections here are some links you may find helpful";
            // 
            // savingLinkLabel1
            // 
            this.savingLinkLabel1.AutoSize = true;
            this.savingLinkLabel1.Location = new System.Drawing.Point(63, 424);
            this.savingLinkLabel1.Name = "savingLinkLabel1";
            this.savingLinkLabel1.Size = new System.Drawing.Size(72, 13);
            this.savingLinkLabel1.TabIndex = 11;
            this.savingLinkLabel1.TabStop = true;
            this.savingLinkLabel1.Text = "Saving Link 1";
            // 
            // savingLinkLabel2
            // 
            this.savingLinkLabel2.AutoSize = true;
            this.savingLinkLabel2.Location = new System.Drawing.Point(63, 452);
            this.savingLinkLabel2.Name = "savingLinkLabel2";
            this.savingLinkLabel2.Size = new System.Drawing.Size(72, 13);
            this.savingLinkLabel2.TabIndex = 12;
            this.savingLinkLabel2.TabStop = true;
            this.savingLinkLabel2.Text = "Saving Link 2";
            // 
            // savingLinkLabel3
            // 
            this.savingLinkLabel3.AutoSize = true;
            this.savingLinkLabel3.Location = new System.Drawing.Point(63, 480);
            this.savingLinkLabel3.Name = "savingLinkLabel3";
            this.savingLinkLabel3.Size = new System.Drawing.Size(72, 13);
            this.savingLinkLabel3.TabIndex = 13;
            this.savingLinkLabel3.TabStop = true;
            this.savingLinkLabel3.Text = "Saving Link 3";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 646);
            this.Controls.Add(this.savingLinkLabel3);
            this.Controls.Add(this.savingLinkLabel2);
            this.Controls.Add(this.savingLinkLabel1);
            this.Controls.Add(this.savingReasonLabel);
            this.Controls.Add(this.overUnderBudgetLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mostMoneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reportListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.financialChart);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart financialChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox reportListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mostMoneyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label overUnderBudgetLabel;
        private System.Windows.Forms.Label savingReasonLabel;
        private System.Windows.Forms.LinkLabel savingLinkLabel1;
        private System.Windows.Forms.LinkLabel savingLinkLabel2;
        private System.Windows.Forms.LinkLabel savingLinkLabel3;
    }
}