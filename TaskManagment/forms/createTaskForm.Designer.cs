namespace TaskManagment.forms
{
    partial class createTaskForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tasktextBox = new System.Windows.Forms.TextBox();
            this.createButton = new TaskManagment.design.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(92, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 38);
            this.label6.TabIndex = 45;
            this.label6.Text = "New Task";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(67, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "Project";
            // 
            // projectComboBox
            // 
            this.projectComboBox.Font = new System.Drawing.Font("Arial", 16.2F);
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(72, 352);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(243, 40);
            this.projectComboBox.TabIndex = 41;
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DescriptiontextBox.Location = new System.Drawing.Point(72, 213);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(243, 85);
            this.DescriptiontextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(67, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Description";
            // 
            // tasktextBox
            // 
            this.tasktextBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tasktextBox.Location = new System.Drawing.Point(72, 124);
            this.tasktextBox.Name = "tasktextBox";
            this.tasktextBox.Size = new System.Drawing.Size(243, 39);
            this.tasktextBox.TabIndex = 38;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.LightBlue;
            this.createButton.CornerRadius = 30;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(99, 432);
            this.createButton.Name = "createButton";
            this.createButton.Padding = new System.Windows.Forms.Padding(5);
            this.createButton.Size = new System.Drawing.Size(163, 73);
            this.createButton.TabIndex = 37;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(67, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Give Your Task a Name";
            // 
            // createTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.DescriptiontextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tasktextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "createTaskForm";
            this.Text = "createTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tasktextBox;
        private design.RoundedButton createButton;
        private System.Windows.Forms.Label label1;
    }
}