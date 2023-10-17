using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagment.classes;
using TaskManagment.design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaskManagment.forms
{
    public partial class listsForm : Form
    {
        DB dbHandler;
        public listsForm(string username)
        {
            dbHandler = DB.Instance;
            InitializeComponent();
            this.Controls.Add(new templatePanel(username));
            List<List<string>> dataFromDatabase = dbHandler.Query("select name from taskList where user = '" + username + "'");

            // Create a Panel to contain the data panels
            Panel dataPanel = new Panel();
            dataPanel.Dock = DockStyle.Right; // Fill the entire form
            dataPanel.Width = 600;
            dataPanel.Height = 1000;
            this.Controls.Add(dataPanel);

            int verticalPosition = 10; // Initial vertical position

            // Create a panel for each line of data
            foreach (List<string> lineData in dataFromDatabase)
            {
                // Create a panel for the current line of data
                Panel linePanel = new RoundedPanel();
                linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
                linePanel.Width = dataPanel.Width - 20; // Adjust the width as needed
                linePanel.Height = 70; // Set the height of the panel
                linePanel.Location = new System.Drawing.Point(10, verticalPosition);

                // Create a button to display the line data
                Button button = new Button();
                button.Text = string.Join(", ", lineData);
                button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(170)))));
                button.Font = new System.Drawing.Font(button.Font.FontFamily, 32, System.Drawing.FontStyle.Regular);
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Dock = DockStyle.Fill;

                button.Click += (sender, e) =>
                {
                    MessageBox.Show(string.Join(", ", lineData));
                    string query = "SELECT name FROM task WHERE user = '" + username + "' AND taskListName = '" + string.Join(", ", lineData) + "'";
                    listPage listPage = new listPage(username,query);
                    this.Parent.Hide();
                    listPage.ShowDialog();
                };
                // Set the label's Parent to the line panel
                button.Parent = linePanel;

                // Add the line panel to the data panel
                dataPanel.Controls.Add(linePanel);

                // Adjust the vertical position for the next panel
                verticalPosition += linePanel.Height + 10; // Add 10 pixels of spacing between panels
            }
        }
    }
}
