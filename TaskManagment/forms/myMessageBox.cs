using System;
using System.Windows.Forms;

namespace TaskManagment.forms
{
    public partial class myMessageBox : Form
    {
        public myMessageBox(string text, Action onYesAction, Action onNoAction)
        {
            InitializeComponent();

            // Set the title text and font
            titleLabel.Text = text;

            // Customize the appearance
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Fixed size
            this.MaximizeBox = false; // Disable maximize button
            this.MinimizeBox = false; // Disable minimize button
            this.StartPosition = FormStartPosition.CenterScreen; // Center on the screen

            // Create "Yes" button with custom color
            yesButton.Click += (sender, e) =>
            {
                onYesAction?.Invoke(); // Execute the provided action for "Yes" if it's not null
                DialogResult = DialogResult.Yes;
                Close();
            };

            // Create "No" button with custom color
            noButton.Click += (sender, e) =>
            {
                onNoAction?.Invoke(); // Execute the provided action for "No" if it's not null
                DialogResult = DialogResult.No;
                Close();
            };

            // Add the controls to the form
            Controls.Add(titleLabel);
            Controls.Add(yesButton);
            Controls.Add(noButton);
        }
    }
}
