namespace TaskManagment.forms
{
    partial class template
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileButton = new TaskManagment.design.RoundedButton();
            this.report = new System.Windows.Forms.Button();
            this.signoutButton = new TaskManagment.design.RoundedButton();
            this.team = new System.Windows.Forms.Button();
            this.task = new System.Windows.Forms.Button();
            this.project = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Controls.Add(this.report);
            this.panel1.Controls.Add(this.signoutButton);
            this.panel1.Controls.Add(this.team);
            this.panel1.Controls.Add(this.task);
            this.panel1.Controls.Add(this.project);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 1000);
            this.panel1.TabIndex = 0;
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.LightBlue;
            this.profileButton.CornerRadius = 30;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("ADAM.CG PRO", 13.8F, System.Drawing.FontStyle.Italic);
            this.profileButton.Location = new System.Drawing.Point(62, 452);
            this.profileButton.Name = "profileButton";
            this.profileButton.Padding = new System.Windows.Forms.Padding(5);
            this.profileButton.Size = new System.Drawing.Size(225, 70);
            this.profileButton.TabIndex = 12;
            this.profileButton.Text = "my profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.LightBlue;
            this.report.Font = new System.Drawing.Font("ADAM.CG PRO", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.Location = new System.Drawing.Point(0, 371);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(372, 63);
            this.report.TabIndex = 11;
            this.report.Text = "Reports";
            this.report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.BackColor = System.Drawing.Color.LightBlue;
            this.signoutButton.CornerRadius = 30;
            this.signoutButton.FlatAppearance.BorderSize = 0;
            this.signoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutButton.Font = new System.Drawing.Font("Arial Narrow", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutButton.Location = new System.Drawing.Point(38, 755);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Padding = new System.Windows.Forms.Padding(5);
            this.signoutButton.Size = new System.Drawing.Size(281, 71);
            this.signoutButton.TabIndex = 6;
            this.signoutButton.Text = "signout";
            this.signoutButton.UseVisualStyleBackColor = false;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // team
            // 
            this.team.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.team.BackColor = System.Drawing.Color.LightBlue;
            this.team.Font = new System.Drawing.Font("ADAM.CG PRO", 13.8F, System.Drawing.FontStyle.Italic);
            this.team.Location = new System.Drawing.Point(0, 302);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(372, 63);
            this.team.TabIndex = 8;
            this.team.Text = "Team";
            this.team.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.team.UseVisualStyleBackColor = false;
            this.team.Click += new System.EventHandler(this.team_Click);
            // 
            // task
            // 
            this.task.BackColor = System.Drawing.Color.LightBlue;
            this.task.Font = new System.Drawing.Font("ADAM.CG PRO", 13.8F, System.Drawing.FontStyle.Italic);
            this.task.Location = new System.Drawing.Point(0, 233);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(372, 63);
            this.task.TabIndex = 8;
            this.task.Text = "Tasks";
            this.task.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.task.UseVisualStyleBackColor = false;
            this.task.Click += new System.EventHandler(this.task_Click);
            // 
            // project
            // 
            this.project.BackColor = System.Drawing.Color.LightBlue;
            this.project.Font = new System.Drawing.Font("ADAM.CG PRO", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project.Location = new System.Drawing.Point(0, 164);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(372, 63);
            this.project.TabIndex = 7;
            this.project.Text = "Projects";
            this.project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.project.UseVisualStyleBackColor = false;
            this.project.Click += new System.EventHandler(this.project_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.usernameLabel.Location = new System.Drawing.Point(13, 34);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(85, 40);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Hello";
            // 
            // template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1375, 883);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "template";
            this.Text = "template";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLabel;
        private design.RoundedButton signoutButton;
        private System.Windows.Forms.Button team;
        private System.Windows.Forms.Button task;
        private System.Windows.Forms.Button project;
        private System.Windows.Forms.Button report;
        private design.RoundedButton profileButton;
    }
}