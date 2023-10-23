using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Classes;
using TaskManagment.classes;

namespace TaskManagment.forms
{
    public partial class teamReview : Form
    {
        string teamId, query, id;
        taskGrid grid;
        public teamReview(Team team, string id)
        {
            this.id = id;
            teamId = team.teamId;
            InitializeComponent();
            setup();
            query = "SELECT  u.id AS [Id], u.company AS Company, u.name AS [Name], u.fName AS Surename, u.jobDescription AS [Job description] " +
            "FROM [user] u, [team] t " +
            "WHERE u.id = t.uId AND t.id = '" + teamId + "'";
            setGrid();
            grid.Width = 543;
            grid.Location = new System.Drawing.Point(165, 0);
        }
        public teamReview(Team team, string projectId, string id)
        {
            this.id = id;
            teamId = team.teamId;
            InitializeComponent();
            setup();
            query = "SELECT u.id AS [ID], u.company AS Company, u.name AS [Name], u.fName AS Surname, u.jobDescription AS [Job description], " +
                "(SELECT SUM(hours) FROM [report] " +
                "WHERE pId = '" + projectId.ToString() + "' AND uId = u.id) AS [Hours on project] " +
                "FROM [user] u, [team] t " +
                "WHERE u.id = t.uId AND t.id = '" + teamId + "'";
            setGrid();
            grid.Width = 644;
            grid.Location = new System.Drawing.Point(85, 0);
        }
        public void setup()
        {
            title.Text = "Team: " + teamId + " members";
            saveButton.Visible = false;
            addUserTextBox.Visible = false;
            label1.Visible = false;
        }

        public void setGrid()
        {
            grid = new taskGrid(query);
            grid.Height = 376;
            grid.BorderStyle = BorderStyle.None;
            Panel1.Controls.Add(grid);
        }
        public void updateGrid()
        {
            Panel1.Controls.Remove(this.grid);
            taskGrid grid = new taskGrid(query);
            grid.Location = new Point(165, 30);
            grid.Height = 376;
            grid.BorderStyle = BorderStyle.None;
            this.grid = grid;
            Panel1.Controls.Add(this.grid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveButton.Visible = true;
            addUserTextBox.Visible = true;
            label1.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DB dbHandler = DB.Instance;
            dbHandler.UpdateDB("DELETE FROM [team] WHERE id = '" + teamId + "'");
            this.Hide();
            string query = @"
                SELECT t.id
                FROM [user] u, [team] t
                WHERE u.id = t.uid AND u.id = '" + id + "'";
            homePage.GetInstance(id).updatehomePage(id, "My teams", query, "team");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB dbHandler = DB.Instance;
            List<string> user = dbHandler.Query("SELECT id FROM [user] WHERE id = '" + addUserTextBox.Text.ToString() + "'").ToArray()[0];
            dbHandler.UpdateDB("INSERT INTO [team] ([id],[uid]) VALUES ('" + teamId + "','" + user.ToArray()[0] + "')");
            updateGrid();
        }
    }
}
