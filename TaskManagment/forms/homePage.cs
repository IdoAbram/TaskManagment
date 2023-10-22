using System;
using System.Windows.Forms;
using System.Collections.Generic; // Import this namespace for List<>
using TaskManagement.Classes;
using TaskManagment.classes;
using TaskManagment.design;
using System.Drawing;

namespace TaskManagment.forms
{
    public partial class homePage : Form
    {
        private static homePage instance = null;
        private string table;
        private DB dbHandler = DB.Instance;

        private homePage(string id)
        {
            InitializeComponent();
            Controls.Add(new templatePanel(id));

            // Put the default screen as My project screen
            putTitle("My Projects");
            string query = @"
                SELECT p.id
                FROM [user] u, [team] t, [project] p
                WHERE u.id = t.uid AND t.id = p.tid AND u.id = '" + id + "'";
            Controls.Add(new myList(query, "project", (myId, currentTable) =>
            {
                // Placeholder for handling project list
                List<string> list = dbHandler.Query("SELECT * FROM " + currentTable + " WHERE id = '" + myId + "'").ToArray()[0];
                new projectReview(new Project(list.ToArray()[0], list.ToArray()[1], list.ToArray()[2], double.Parse(list.ToArray()[3]), list.ToArray()[4])).Show();
            }));
        }

        public static homePage GetInstance(string id)
        {
            if (instance == null)
            {
                instance = new homePage(id);
            }
            return instance;
        }

        public void updatehomePage(string id, string title, string query, string table)
        {
            Controls.Clear(); // Clear existing controls

            // Initialize the components here
            InitializeComponent();

            Controls.Add(new templatePanel(id));
            putTitle(title);

            if (table == "task")
            {
                // Placeholder for handling tasks
                string taskQuery = "SELECT t1.id AS [Task ID], t1.description AS Description, t1.pid AS [Project ID], t1.tid AS [Team ID], t1.status AS [Status] " +
                    "FROM [task] t1, [team] t2, [user] u " +
                    "WHERE u.id = '" + id + "' AND u.id = t2.uid AND t2.id = t1.tid";
                taskGrid grid = new taskGrid(taskQuery);
                grid.Width = 543;
                grid.Location = new System.Drawing.Point(375, 150);
                Controls.Add(grid);
            }
            else if (table == "report")
            {
                // Placeholder for handling reports
                string reportQuery = "SELECT id AS [Report ID], pId AS [Project ID], taskId AS [Task ID], hours AS [Hours], date AS [Date] FROM [report] WHERE uId = '" + id + "'";
                taskGrid grid = new taskGrid(reportQuery);
                grid.Width = 543;
                grid.Location = new System.Drawing.Point(375, 150);
                Controls.Add(grid);
            }
            else if (table == "project")
            {
                RoundedPanel roundedPanel = new RoundedPanel();
                roundedPanel.Location = new System.Drawing.Point(610, 610);
                roundedPanel.Size = new System.Drawing.Size(200, 60);
                RoundedButton addTeamButton = new RoundedButton();
                addTeamButton.BackColor = Color.LightBlue;
                addTeamButton.Size = new System.Drawing.Size(200, 60);
                addTeamButton.Location = new System.Drawing.Point(0, 0);
                addTeamButton.Font = new Font("Arial Narrow", 16.2f, FontStyle.Regular | FontStyle.Regular);
                addTeamButton.Text = "Create new Project";
                addTeamButton.FlatStyle = FlatStyle.Flat;
                addTeamButton.FlatAppearance.BorderColor = addTeamButton.BackColor;
                addTeamButton.Click += (sender, e) =>
                {
                    new createProjectForm(id).Show();
                };
                roundedPanel.Controls.Add(addTeamButton);
                this.Controls.Add(roundedPanel);
                // Placeholder for handling projects
                Controls.Add(new myList(query, table, (myId, currentTable) =>
                {
                    List<string> list = dbHandler.Query("SELECT * FROM " + currentTable + " WHERE id = '" + myId + "'").ToArray()[0];
                    new projectReview(new Project(list.ToArray()[0], list.ToArray()[1], list.ToArray()[2], double.Parse(list.ToArray()[3]), list.ToArray()[4])).Show();
                    // You can display or handle the project in your UI here
                }));
            }
            else if (table == "team")
            {
                RoundedPanel roundedPanel = new RoundedPanel();
                roundedPanel.Location = new System.Drawing.Point(610, 610);
                roundedPanel.Size = new System.Drawing.Size(200, 60);
                RoundedButton addTeamButton = new RoundedButton();
                addTeamButton.BackColor = Color.LightBlue;
                addTeamButton.Size = new System.Drawing.Size(200, 60);
                addTeamButton.Location = new System.Drawing.Point(0, 0);
                addTeamButton.Font = new Font("Arial Narrow", 16.2f, FontStyle.Regular | FontStyle.Regular);
                addTeamButton.Text = "Create new Team";
                addTeamButton.FlatStyle = FlatStyle.Flat;
                addTeamButton.FlatAppearance.BorderColor = addTeamButton.BackColor;
                addTeamButton.Click += (sender, e) =>
                {
                    new createTeamForm(id).Show();
                };
                roundedPanel.Controls.Add(addTeamButton);
                this.Controls.Add(roundedPanel);
                // Placeholder for handling teams
                this.Controls.Add(new myList(query, table, (myId, currentTable) =>
                {
                    List<string> list = dbHandler.Query("SELECT id FROM " + currentTable + " WHERE id = '" + myId + "'").ToArray()[0];
                    new teamReview(new Team(list.ToArray()[0])).Show();
                }));
                
            }
        }
        public void reset() => instance = null;
        private void putTitle(string title)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Text = title;
            label.Font = new System.Drawing.Font(label.Font.FontFamily, 36, System.Drawing.FontStyle.Regular);
            label.ForeColor = System.Drawing.Color.Black;
            label.Location = new System.Drawing.Point(this.Width - label.PreferredWidth - 100, 40);

            Controls.Add(label);
        }
    }
}
