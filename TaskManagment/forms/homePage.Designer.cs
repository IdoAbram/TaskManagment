namespace TaskManagment.forms
{
    partial class homePage
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
            this.roundedButton3 = new TaskManagment.design.RoundedButton();
            this.roundedButton2 = new TaskManagment.design.RoundedButton();
            this.roundedButton1 = new TaskManagment.design.RoundedButton();
            this.loginButton = new TaskManagment.design.RoundedButton();
            this.SuspendLayout();
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.roundedButton3.CornerRadius = 30;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(170)))));
            this.roundedButton3.Location = new System.Drawing.Point(458, 376);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Padding = new System.Windows.Forms.Padding(5);
            this.roundedButton3.Size = new System.Drawing.Size(966, 115);
            this.roundedButton3.TabIndex = 9;
            this.roundedButton3.Text = "All Tasks";
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(199)))), ((int)(((byte)(215)))));
            this.roundedButton2.CornerRadius = 30;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(170)))));
            this.roundedButton2.Location = new System.Drawing.Point(458, 525);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(5);
            this.roundedButton2.Size = new System.Drawing.Size(966, 115);
            this.roundedButton2.TabIndex = 8;
            this.roundedButton2.Text = "Last Tasks";
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(202)))), ((int)(((byte)(222)))));
            this.roundedButton1.CornerRadius = 30;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(170)))));
            this.roundedButton1.Location = new System.Drawing.Point(458, 220);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(5);
            this.roundedButton1.Size = new System.Drawing.Size(966, 115);
            this.roundedButton1.TabIndex = 7;
            this.roundedButton1.Text = "Important";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
            this.loginButton.CornerRadius = 30;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(170)))));
            this.loginButton.Location = new System.Drawing.Point(458, 76);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(5);
            this.loginButton.Size = new System.Drawing.Size(966, 115);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Recently Added";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1375, 883);
            this.ControlBox = false;
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.loginButton);
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.ResumeLayout(false);

        }

        #endregion

        private design.RoundedButton loginButton;
        private design.RoundedButton roundedButton1;
        private design.RoundedButton roundedButton2;
        private design.RoundedButton roundedButton3;
    }
}