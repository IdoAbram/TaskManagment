namespace TaskManagment.forms
{
    partial class projectReview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.title = new System.Windows.Forms.Label();
            this.roundedPanel1 = new TaskManagment.design.RoundedPanel();
            this.statuslabel3 = new System.Windows.Forms.Label();
            this.statuslabel1 = new System.Windows.Forms.Label();
            this.statusLabel2 = new System.Windows.Forms.Label();
            this.projectTeam = new System.Windows.Forms.Button();
            this.descriptionStatusLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.taskChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.budgetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.idLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.sDateBox = new System.Windows.Forms.TextBox();
            this.sDate = new System.Windows.Forms.Label();
            this.eDateBox = new System.Windows.Forms.TextBox();
            this.eDate = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.Label();
            this.budgetBox = new System.Windows.Forms.TextBox();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetChart)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.title.Location = new System.Drawing.Point(145, 45);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(353, 46);
            this.title.TabIndex = 9;
            this.title.Text = "Project Dashboard";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.statuslabel3);
            this.roundedPanel1.Controls.Add(this.statuslabel1);
            this.roundedPanel1.Controls.Add(this.statusLabel2);
            this.roundedPanel1.Controls.Add(this.projectTeam);
            this.roundedPanel1.Controls.Add(this.descriptionStatusLabel);
            this.roundedPanel1.Controls.Add(this.saveButton);
            this.roundedPanel1.Controls.Add(this.statusLabel);
            this.roundedPanel1.Controls.Add(this.editButton);
            this.roundedPanel1.Controls.Add(this.taskChart);
            this.roundedPanel1.Controls.Add(this.budgetChart);
            this.roundedPanel1.Controls.Add(this.idLabel);
            this.roundedPanel1.Controls.Add(this.idBox);
            this.roundedPanel1.Controls.Add(this.sDateBox);
            this.roundedPanel1.Controls.Add(this.sDate);
            this.roundedPanel1.Controls.Add(this.eDateBox);
            this.roundedPanel1.Controls.Add(this.eDate);
            this.roundedPanel1.Controls.Add(this.budget);
            this.roundedPanel1.Controls.Add(this.budgetBox);
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.Location = new System.Drawing.Point(153, 126);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1136, 703);
            this.roundedPanel1.TabIndex = 18;
            // 
            // statuslabel3
            // 
            this.statuslabel3.AutoSize = true;
            this.statuslabel3.Font = new System.Drawing.Font("Arial", 12F);
            this.statuslabel3.Location = new System.Drawing.Point(661, 178);
            this.statuslabel3.Name = "statuslabel3";
            this.statuslabel3.Size = new System.Drawing.Size(115, 23);
            this.statuslabel3.TabIndex = 25;
            this.statuslabel3.Text = "statuslabel2";
            // 
            // statuslabel1
            // 
            this.statuslabel1.AutoSize = true;
            this.statuslabel1.Font = new System.Drawing.Font("Arial", 12F);
            this.statuslabel1.Location = new System.Drawing.Point(661, 143);
            this.statuslabel1.Name = "statuslabel1";
            this.statuslabel1.Size = new System.Drawing.Size(118, 23);
            this.statuslabel1.TabIndex = 24;
            this.statuslabel1.Text = "labelStatus2";
            // 
            // statusLabel2
            // 
            this.statusLabel2.AutoSize = true;
            this.statusLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.statusLabel2.Location = new System.Drawing.Point(662, 107);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(118, 23);
            this.statusLabel2.TabIndex = 23;
            this.statusLabel2.Text = "labelStatus2";
            // 
            // projectTeam
            // 
            this.projectTeam.BackColor = System.Drawing.Color.LightBlue;
            this.projectTeam.Location = new System.Drawing.Point(557, 626);
            this.projectTeam.Name = "projectTeam";
            this.projectTeam.Size = new System.Drawing.Size(122, 44);
            this.projectTeam.TabIndex = 22;
            this.projectTeam.Text = "Project team";
            this.projectTeam.UseVisualStyleBackColor = false;
            this.projectTeam.Click += new System.EventHandler(this.projectTeam_Click);
            // 
            // descriptionStatusLabel
            // 
            this.descriptionStatusLabel.AutoSize = true;
            this.descriptionStatusLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.descriptionStatusLabel.Location = new System.Drawing.Point(661, 70);
            this.descriptionStatusLabel.Name = "descriptionStatusLabel";
            this.descriptionStatusLabel.Size = new System.Drawing.Size(62, 23);
            this.descriptionStatusLabel.TabIndex = 21;
            this.descriptionStatusLabel.Text = "label1";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightBlue;
            this.saveButton.Location = new System.Drawing.Point(813, 626);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 44);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statusLabel.Location = new System.Drawing.Point(659, 27);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(96, 33);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.Text = "status";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.LightBlue;
            this.editButton.Location = new System.Drawing.Point(685, 626);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(122, 44);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // taskChart
            // 
            chartArea1.Name = "ChartArea1";
            this.taskChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.taskChart.Legends.Add(legend1);
            this.taskChart.Location = new System.Drawing.Point(591, 260);
            this.taskChart.Name = "taskChart";
            this.taskChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.taskChart.Series.Add(series1);
            this.taskChart.Size = new System.Drawing.Size(519, 276);
            this.taskChart.TabIndex = 19;
            this.taskChart.Text = "chart2";
            // 
            // budgetChart
            // 
            chartArea2.Name = "ChartArea1";
            this.budgetChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.budgetChart.Legends.Add(legend2);
            this.budgetChart.Location = new System.Drawing.Point(48, 260);
            this.budgetChart.Name = "budgetChart";
            this.budgetChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.budgetChart.Size = new System.Drawing.Size(488, 268);
            this.budgetChart.TabIndex = 18;
            this.budgetChart.Text = "chart1";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(44, 36);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(23, 24);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "id";
            // 
            // idBox
            // 
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(47, 63);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(218, 30);
            this.idBox.TabIndex = 17;
            // 
            // sDateBox
            // 
            this.sDateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDateBox.Location = new System.Drawing.Point(317, 63);
            this.sDateBox.Name = "sDateBox";
            this.sDateBox.Size = new System.Drawing.Size(133, 30);
            this.sDateBox.TabIndex = 6;
            // 
            // sDate
            // 
            this.sDate.AutoSize = true;
            this.sDate.BackColor = System.Drawing.Color.Transparent;
            this.sDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDate.Location = new System.Drawing.Point(313, 36);
            this.sDate.Name = "sDate";
            this.sDate.Size = new System.Drawing.Size(79, 24);
            this.sDate.TabIndex = 8;
            this.sDate.Text = "start date";
            // 
            // eDateBox
            // 
            this.eDateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDateBox.Location = new System.Drawing.Point(472, 63);
            this.eDateBox.Name = "eDateBox";
            this.eDateBox.Size = new System.Drawing.Size(122, 30);
            this.eDateBox.TabIndex = 10;
            // 
            // eDate
            // 
            this.eDate.AutoSize = true;
            this.eDate.BackColor = System.Drawing.Color.Transparent;
            this.eDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDate.Location = new System.Drawing.Point(468, 36);
            this.eDate.Name = "eDate";
            this.eDate.Size = new System.Drawing.Size(74, 24);
            this.eDate.TabIndex = 11;
            this.eDate.Text = "end date";
            // 
            // budget
            // 
            this.budget.AutoSize = true;
            this.budget.BackColor = System.Drawing.Color.Transparent;
            this.budget.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic);
            this.budget.Location = new System.Drawing.Point(45, 99);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(92, 24);
            this.budget.TabIndex = 13;
            this.budget.Text = "budget in $";
            // 
            // budgetBox
            // 
            this.budgetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.budgetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetBox.Location = new System.Drawing.Point(48, 127);
            this.budgetBox.Name = "budgetBox";
            this.budgetBox.Size = new System.Drawing.Size(94, 30);
            this.budgetBox.TabIndex = 12;
            // 
            // projectReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 883);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.title);
            this.Name = "projectReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "projectReview";
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sDate;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox sDateBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label eDate;
        private System.Windows.Forms.TextBox eDateBox;
        private System.Windows.Forms.Label budget;
        private System.Windows.Forms.TextBox budgetBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox idBox;
        private design.RoundedPanel roundedPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart taskChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart budgetChart;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label descriptionStatusLabel;
        private System.Windows.Forms.Button projectTeam;
        private System.Windows.Forms.Label statusLabel2;
        private System.Windows.Forms.Label statuslabel1;
        private System.Windows.Forms.Label statuslabel3;
    }
}