namespace TaskManagment.forms
{
    partial class teamReview
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
            this.title = new System.Windows.Forms.Label();
            this.Panel1 = new TaskManagment.design.RoundedPanel();
            this.removebutton = new System.Windows.Forms.Button();
            this.removeUsertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeMemberbutton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addUserTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveMemberButton = new System.Windows.Forms.Button();
            this.leaveTeambutton = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.title.Location = new System.Drawing.Point(419, 135);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(294, 45);
            this.title.TabIndex = 10;
            this.title.Text = "Team Members";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel1.Controls.Add(this.leaveTeambutton);
            this.Panel1.Controls.Add(this.removebutton);
            this.Panel1.Controls.Add(this.removeUsertextBox);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.removeMemberbutton);
            this.Panel1.Controls.Add(this.deleteButton);
            this.Panel1.Controls.Add(this.button1);
            this.Panel1.Controls.Add(this.addUserTextBox);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.saveMemberButton);
            this.Panel1.CornerRadius = 30;
            this.Panel1.Location = new System.Drawing.Point(138, 201);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1108, 558);
            this.Panel1.TabIndex = 11;
            // 
            // removebutton
            // 
            this.removebutton.BackColor = System.Drawing.Color.LightBlue;
            this.removebutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.removebutton.Location = new System.Drawing.Point(22, 439);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(182, 44);
            this.removebutton.TabIndex = 31;
            this.removebutton.Text = "Remove member";
            this.removebutton.UseVisualStyleBackColor = false;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // removeUsertextBox
            // 
            this.removeUsertextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.removeUsertextBox.Location = new System.Drawing.Point(225, 447);
            this.removeUsertextBox.Name = "removeUsertextBox";
            this.removeUsertextBox.Size = new System.Drawing.Size(148, 30);
            this.removeUsertextBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(221, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Remove user by ID";
            // 
            // removeMemberbutton
            // 
            this.removeMemberbutton.BackColor = System.Drawing.Color.LightBlue;
            this.removeMemberbutton.Font = new System.Drawing.Font("Arial", 12F);
            this.removeMemberbutton.Location = new System.Drawing.Point(408, 439);
            this.removeMemberbutton.Name = "removeMemberbutton";
            this.removeMemberbutton.Size = new System.Drawing.Size(154, 44);
            this.removeMemberbutton.TabIndex = 28;
            this.removeMemberbutton.Text = "Remove";
            this.removeMemberbutton.UseVisualStyleBackColor = false;
            this.removeMemberbutton.Click += new System.EventHandler(this.removeMemberbutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightBlue;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteButton.Location = new System.Drawing.Point(22, 370);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(182, 44);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete team";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(22, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add member";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addUserTextBox
            // 
            this.addUserTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addUserTextBox.Location = new System.Drawing.Point(225, 513);
            this.addUserTextBox.Name = "addUserTextBox";
            this.addUserTextBox.Size = new System.Drawing.Size(148, 30);
            this.addUserTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(221, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Add user by ID";
            // 
            // saveMemberButton
            // 
            this.saveMemberButton.BackColor = System.Drawing.Color.LightBlue;
            this.saveMemberButton.Font = new System.Drawing.Font("Arial", 12F);
            this.saveMemberButton.Location = new System.Drawing.Point(408, 505);
            this.saveMemberButton.Name = "saveMemberButton";
            this.saveMemberButton.Size = new System.Drawing.Size(154, 44);
            this.saveMemberButton.TabIndex = 23;
            this.saveMemberButton.Text = "Save";
            this.saveMemberButton.UseVisualStyleBackColor = false;
            this.saveMemberButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // leaveTeambutton
            // 
            this.leaveTeambutton.BackColor = System.Drawing.Color.LightBlue;
            this.leaveTeambutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.leaveTeambutton.Location = new System.Drawing.Point(22, 505);
            this.leaveTeambutton.Name = "leaveTeambutton";
            this.leaveTeambutton.Size = new System.Drawing.Size(182, 44);
            this.leaveTeambutton.TabIndex = 32;
            this.leaveTeambutton.Text = "Leave team";
            this.leaveTeambutton.UseVisualStyleBackColor = false;
            this.leaveTeambutton.Click += new System.EventHandler(this.leaveTeambutton_Click);
            // 
            // teamReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 883);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.title);
            this.Name = "teamReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teamReview";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private design.RoundedPanel Panel1;
        private System.Windows.Forms.Button saveMemberButton;
        private System.Windows.Forms.TextBox addUserTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.TextBox removeUsertextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeMemberbutton;
        private System.Windows.Forms.Button leaveTeambutton;
    }
}