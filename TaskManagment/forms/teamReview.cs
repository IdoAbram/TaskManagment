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
            this.teamId = team.teamId;
            InitializeComponent();
            setup();
            query = "SELECT  u.id AS [Id], u.company AS Company, u.name AS [Name], u.fName AS Surename, u.jobDescription AS [Job description] " +
            "FROM [user] u, [userToTeam] t " +
            "WHERE u.id = t.uId AND t.id = '" + teamId + "'";
            grid = new taskGrid(query);
            grid.Width = 543;
            grid.Location = new System.Drawing.Point(165, 0);
            setGrid();
        }
        public teamReview(Team team, string projectId, string id)
        {
            this.id = id;
            this.teamId = team.teamId;
            InitializeComponent();
            setup();
            query = "SELECT u.id AS [ID], u.company AS Company, u.name AS [Name], u.fName AS Surname, u.jobDescription AS [Job description], " +
                "(SELECT SUM(hours) FROM [report] " +
                "WHERE pId = '" + projectId.ToString() + "' AND uId = u.id) AS [Hours on project] " +
                "FROM [user] u, [userToTeam] t " +
                "WHERE u.id = t.uId AND t.id = '" + teamId + "'";
            grid = new taskGrid(query);
            grid.Width = 644;
            grid.Location = new System.Drawing.Point(85, 0);
            setGrid();
        }
        public void setup()
        {
            title.Text = "Team: " + teamId + " members";
            saveMemberButton.Visible = false;
            addUserTextBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            removeMemberbutton.Visible = false;
            removeUsertextBox.Visible = false;
            DB dbHandler = DB.Instance;
            string teamLeader = dbHandler.Query("SELECT teamLeader FROM [team] WHERE id = '" + teamId + "'").ToArray()[0].ToArray()[0];
            if (teamLeader == id)
            {
                leaveTeambutton.Visible = false;
            }
            else
            {
                deleteButton.Visible = false;
                saveMemberButton.Visible = false;
                removebutton.Visible = false;
            }
        }

        public void setGrid()
        {
            taskGrid grid = new taskGrid(query);
            grid.Height = 376;
            grid.Location = this.grid.Location;
            grid.BorderStyle = BorderStyle.None;
            grid.Width = this.grid.Width;
            grid.ReadOnly = true;
            this.grid = grid;
            Panel1.Controls.Add(this.grid);
        }
        public void updateGrid()
        {
            Panel1.Controls.Remove(this.grid);
            setGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveMemberButton.Visible = true;
            addUserTextBox.Visible = true;
            label1.Visible = true;
        }

        private void removeMemberbutton_Click(object sender, EventArgs e)
        {

            DB dbHandler = DB.Instance;
            string teamLeader = dbHandler.Query("SELECT teamLeader FROM [team] WHERE id = '" + teamId + "'").ToArray()[0].ToArray()[0];
            if (removeUsertextBox.Text == teamLeader)
            {
                MessageBox.Show("Can not remove the leader");
                return;
            }
            if (!dbHandler.IsExist("SELECT id FROM [user] WHERE id = '" + removeUsertextBox.Text.ToString() + "'"))
            {
                MessageBox.Show("User ha been not found");
                return;
            }
            List<string> user = dbHandler.Query("SELECT id FROM [user] WHERE id = '" + removeUsertextBox.Text.ToString() + "'").ToArray()[0];
            dbHandler.UpdateDB("DELETE FROM [userToTeam] WHERE uId = '" + user.ToArray()[0].ToString() + "'");
            updateGrid();
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            removeMemberbutton.Visible = true;
            removeUsertextBox.Visible = true;
        }

        private void leaveTeambutton_Click(object sender, EventArgs e)
        {
            DB dbHandler = DB.Instance;
            dbHandler.UpdateDB("DELETE FROM [userToTeam] WHERE id = '" + teamId + "' AND uId = '" + id + "'");
            this.Hide();
            string query = @"
                SELECT t.id
                FROM [user] u, [userToTeam] t
                WHERE u.id = t.uid AND u.id = '" + id + "'";
            homePage.GetInstance(id).updatehomePage(id, "My teams", query, "team");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            new myMessageBox("Are you sure you want to delete this team?\ndeliting this team you will delete all the tasks\n projects and reports that related to it", () =>
            {
                DB dbHandler = DB.Instance;
                dbHandler.UpdateDB("DELETE FROM [team] WHERE id = '" + teamId + "'");
                dbHandler.UpdateDB("DELETE FROM [userToTeam] WHERE id = '" + teamId + "'");
                teamReview.ActiveForm.Hide();
                myMessageBox.ActiveForm.Hide();
                string query = @"
                SELECT t.id
                FROM [user] u, [userToTeam] t
                WHERE u.id = t.uid AND u.id = '" + id + "'";
                homePage.GetInstance(id).updatehomePage(id, "My teams", query, "userToTeam");
            }, () => myMessageBox.ActiveForm.Hide()).Show();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB dbHandler = DB.Instance;
            if (!dbHandler.IsExist("SELECT id FROM [user] WHERE id = '" + addUserTextBox.Text.ToString() + "'"))
            {
                MessageBox.Show("User has been not found");
                return;
            }
            if (!dbHandler.IsExist("SELECT id FROM [user] WHERE id = '" + addUserTextBox.Text.ToString() + "'"))
            {
                MessageBox.Show("User has been not found");
                return;
            }
            List<string> user = dbHandler.Query("SELECT id FROM [user] WHERE id = '" + addUserTextBox.Text.ToString() + "'").ToArray()[0];
            dbHandler.UpdateDB("INSERT INTO [userToTeam] ([id],[uid]) VALUES ('" + teamId + "','" + user.ToArray()[0] + "')");
            updateGrid();
        }
    }
}
