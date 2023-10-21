using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TaskManagment.classes;

namespace TaskManagment.design
{
    internal class myList : Panel
    {
        DB dbHandler;

        public myList(string query, string table, Action<string,string> buttonFunc)
        {
            dbHandler = DB.Instance;
            List<List<string>> dataFromDatabase = dbHandler.Query(query);

            int verticalPosition = 150; // Initial vertical position

            this.Dock = DockStyle.Right; // Fill the entire form
            this.Width = 600;
            this.Height = 600; // Limit the height of the main panel

            // Create an inner container for the scrollable content
            Panel innerPanel = new Panel();
            innerPanel.AutoScroll = true;
            innerPanel.Location = new Point(0, verticalPosition);
            innerPanel.Width = this.Width;
            innerPanel.Height = this.Height - verticalPosition;
            this.Controls.Add(innerPanel);

            verticalPosition = 0;

            // Create a panel for each line of data and add it to the inner container
            foreach (List<string> lineData in dataFromDatabase)
            {
                Panel linePanel = new RoundedPanel();
                linePanel.BackColor = Color.LightBlue;
                linePanel.Width = innerPanel.Width - 50;
                linePanel.Height = 70;
                linePanel.Location = new Point(10, verticalPosition);

                Button button = new Button();
                button.Text = string.Join(", ", lineData);
                button.ForeColor = Color.Black;
                button.Font = new Font(button.Font.FontFamily, 18, FontStyle.Regular);
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Dock = DockStyle.Fill;

                button.Click += (sender, e) =>
                {
                    buttonFunc.Invoke(button.Text, table);
                };

                button.Parent = linePanel;
                innerPanel.Controls.Add(linePanel);

                verticalPosition += linePanel.Height + 10;
            }
        }
    }
}
