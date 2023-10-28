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
        private string id, taskQuery = "";
        private ComboBox filterTypeComboBox = new ComboBox();
        private ComboBox filterComboBox = new ComboBox();

        private homePage(string id)
        {
            this.id = id;
            InitializeComponent();
            Controls.Add(new templatePanel(id));

            // Put the default screen as My project screen
            addProjectButton();
            putTitle("My Projects");
            string query = @"
                SELECT p.id
                FROM [user] u, [userToTeam] t, [project] p
                WHERE u.id = t.uid AND t.id = p.tid AND u.id = '" + id + "'";
            Controls.Add(new myList(query, "project", (myId, currentTable) =>
            {
                // Placeholder for handling project list
                List<string> list = dbHandler.Query("SELECT * FROM " + currentTable + " WHERE id = '" + myId + "'").ToArray()[0];
                new projectReview(new Project(list.ToArray()[0], list.ToArray()[1], list.ToArray()[2], double.Parse(list.ToArray()[3]), list.ToArray()[4], list.ToArray()[5]),id).Show();
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
                addTaskButton();
                addTaskFilterBar();
                // Placeholder for handling tasks
                if(taskQuery == "")
                {
                    taskQuery = query;
                }
                taskGrid grid = new taskGrid(taskQuery);
                grid.Width = 543;
                grid.Location = new System.Drawing.Point(430, 150);
                Controls.Add(grid);
            }
            else if (table == "report")
            {
                // Placeholder for handling reports
                addReportButton();
                string reportQuery = "SELECT id AS [Report ID], pId AS [Project ID], taskId AS [Task ID],  hours AS [Hours], reportDate AS [Date] FROM [report] WHERE uId = '" + id + "'";
                taskGrid grid = new taskGrid(reportQuery);
                grid.Width = 543;
                grid.Location = new System.Drawing.Point(430, 150);
                Controls.Add(grid);
            }
            else if (table == "project")
            {
                addProjectButton();
                // Placeholder for handling projects
                Controls.Add(new myList(query, table, (myId, currentTable) =>
                {
                    List<string> list = dbHandler.Query("SELECT * FROM " + currentTable + " WHERE id = '" + myId + "'").ToArray()[0];
                    new projectReview(new Project(list.ToArray()[0], list.ToArray()[1], list.ToArray()[2], double.Parse(list.ToArray()[3]), list.ToArray()[4], list.ToArray()[5]),id).Show();
                    // You can display or handle the project in your UI here
                }));
            }
            else if (table == "userToTeam")
            {
                addTeamButton();
                // Placeholder for handling teams
                this.Controls.Add(new myList(query, table, (myId, currentTable) =>
                {
                    List<string> list = dbHandler.Query("SELECT id FROM " + currentTable + " WHERE id = '" + myId + "'").ToArray()[0];
                    new teamReview(new Team(list.ToArray()[0]), id).Show();
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
            label.Location = new System.Drawing.Point(430, 40);

            Controls.Add(label);
        }
        private void addProjectButton()
        {
            RoundedPanel roundedPanel = new RoundedPanel();
            roundedPanel.Location = new System.Drawing.Point(610, 610);
            roundedPanel.Size = new System.Drawing.Size(200, 60);
            RoundedButton addTeamButton = new RoundedButton();
            addTeamButton.BackColor = Color.LightBlue;
            addTeamButton.Size = new System.Drawing.Size(200, 60);
            addTeamButton.Location = new System.Drawing.Point(0, 0);
            addTeamButton.Font = new Font("Arial Narrow", 16.2f, FontStyle.Regular | FontStyle.Regular);
            addTeamButton.Text = "New Project";
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.FlatAppearance.BorderColor = addTeamButton.BackColor;
            addTeamButton.Click += (sender, e) =>
            {
                new createProjectForm(id).Show();
            };
            roundedPanel.Controls.Add(addTeamButton);
            this.Controls.Add(roundedPanel);
        }
        private void addTeamButton()
        {
            RoundedPanel roundedPanel = new RoundedPanel();
            roundedPanel.Location = new System.Drawing.Point(610, 610);
            roundedPanel.Size = new System.Drawing.Size(200, 60);
            RoundedButton addTeamButton = new RoundedButton();
            addTeamButton.BackColor = Color.LightBlue;
            addTeamButton.Size = new System.Drawing.Size(200, 60);
            addTeamButton.Location = new System.Drawing.Point(0, 0);
            addTeamButton.Font = new Font("Arial Narrow", 16.2f, FontStyle.Regular | FontStyle.Regular);
            addTeamButton.Text = "New Team";
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.FlatAppearance.BorderColor = addTeamButton.BackColor;
            addTeamButton.Click += (sender, e) =>
            {
                new createTeamForm(id).Show();
            };
            roundedPanel.Controls.Add(addTeamButton);
            this.Controls.Add(roundedPanel);
        }
        private void addTaskButton()
        {
            RoundedPanel roundedPanel = new RoundedPanel();
            roundedPanel.Location = new System.Drawing.Point(610, 610);
            roundedPanel.Size = new System.Drawing.Size(200, 60);
            RoundedButton addTeamButton = new RoundedButton();
            addTeamButton.BackColor = Color.LightBlue;
            addTeamButton.Size = new System.Drawing.Size(200, 60);
            addTeamButton.Location = new System.Drawing.Point(0, 0);
            addTeamButton.Font = new Font("Arial Narrow", 16.2f, FontStyle.Regular | FontStyle.Regular);
            addTeamButton.Text = "New Task";
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.FlatAppearance.BorderColor = addTeamButton.BackColor;
            addTeamButton.Click += (sender, e) =>
            {
                new createTaskForm(id).Show();
            };
            roundedPanel.Controls.Add(addTeamButton);
            this.Controls.Add(roundedPanel);
        }
        private void addReportButton()
        {
            RoundedPanel roundedPanel = new RoundedPanel();
            roundedPanel.Location = new System.Drawing.Point(610, 610);
            roundedPanel.Size = new System.Drawing.Size(200, 60);
            RoundedButton addTeamButton = new RoundedButton();
            addTeamButton.BackColor = Color.LightBlue;
            addTeamButton.Size = new System.Drawing.Size(200, 60);
            addTeamButton.Location = new System.Drawing.Point(0, 0);
            addTeamButton.Font = new Font("Arial Narrow", 16.2f, FontStyle.Regular | FontStyle.Regular);
            addTeamButton.Text = "New Report";
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.FlatAppearance.BorderColor = addTeamButton.BackColor;
            addTeamButton.Click += (sender, e) =>
            {
                new createReportForm(id).Show();
            };
            roundedPanel.Controls.Add(addTeamButton);
            this.Controls.Add(roundedPanel);
        }
        private void addTaskFilterBar()
        {
            filterComboBox.Location = new System.Drawing.Point(430, 120);
            if (filterComboBox.Items.Count < 1)
            {
                filterComboBox.Items.Add("Project ID");
                filterComboBox.Items.Add("Team ID");
                filterComboBox.Items.Add("No filter");
                filterComboBox.Text = "no filter";
            }

            filterTypeComboBox.Location = new System.Drawing.Point(570, 120); // Move location and common properties here
            this.Controls.Add(filterTypeComboBox);
            filterComboBox.SelectedIndexChanged += (sender, e) =>
            {
                filterTypeComboBox.Items.Clear(); // Clear existing items

                filterTypeComboBox.Text = "Choose: " + filterComboBox.SelectedItem.ToString();

                if (filterComboBox.SelectedItem.ToString() == "Project ID")
                {
                    foreach (List<string> item in dbHandler.Query("SELECT * " +
                        "FROM [project] p, [userToTeam] t " +
                        "WHERE p.tid = t.id AND t.uId = '" + id + "'"))
                    {
                        filterTypeComboBox.Items.Add(item[0]);
                    }
                }
                else if (filterComboBox.SelectedItem.ToString() == "Team ID")
                {
                    foreach (List<string> item in dbHandler.Query("SELECT * FROM [userToTeam] WHERE uId = '" + id + "'"))
                    {
                        filterTypeComboBox.Items.Add(item[0]);
                    }
                }
                else if(filterComboBox.SelectedItem.ToString() == "No filter")
                {
                    fillterring();
                }
                filterTypeComboBox.Items.Add("All");
            };       
            
            filterTypeComboBox.SelectedIndexChanged += (sender, e) =>
            {
                fillterring();
            };
            this.Controls.Add(filterComboBox);
        }
        private void fillterring()
        {
            if (filterComboBox.SelectedItem == null || filterComboBox.SelectedItem.ToString() == "No filter" || filterTypeComboBox.SelectedItem.ToString() == "All")
            {
                taskQuery = @"SELECT t1.id AS [Task ID], t1.description AS Description, t1.pid AS [Project ID], t1.tid AS [Team ID], t1.status AS [Status] " +
                    "FROM [task] t1, [userToTeam] t2 " +
                    "WHERE t2.uid = '" + id + "' AND t2.id = t1.tid";
                homePage.GetInstance(id).updatehomePage(id, "My tasks", taskQuery, "task");
            }
            else if (filterComboBox.SelectedItem.ToString() == "Team ID")
            {
                taskQuery = @"SELECT t1.id AS [Task ID], t1.description AS Description, t1.pid AS [Project ID], t1.tid AS [Team ID], t1.status AS [Status] " +
                   "FROM [task] t1, [userToTeam] t2 " +
                   "WHERE t2.uid = '" + id + "' AND t2.id = t1.tid AND t1.tid = '" + filterTypeComboBox.SelectedItem.ToString() + "'";
                homePage.GetInstance(id).updatehomePage(id, "My tasks", taskQuery, "task");
            }
            else if (filterComboBox.SelectedItem.ToString() == "Project ID")
            {
                taskQuery = @"SELECT t1.id AS [Task ID], t1.description AS Description, t1.pid AS [Project ID], t1.tid AS [Team ID], t1.status AS [Status] " +
                    "FROM [task] t1, [userToTeam] t2 " +
                    "WHERE t2.uid = '" + id + "' AND t2.id = t1.tid AND t1.pid = '" + filterTypeComboBox.SelectedItem.ToString() + "'";
                homePage.GetInstance(id).updatehomePage(id, "My tasks", taskQuery, "task");
            }
        }
    }
}
