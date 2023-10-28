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
using TaskManagment.validation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManagment.forms
{
    public partial class createProjectForm : Form
    {
        string id;
        public createProjectForm(string id)
        {
            this.id = id;
            InitializeComponent();
            List<List<string>> myTeams = DB.Instance.Query("SELECT id From [userToTeam] WHERE uId = '" + id + "'");
            myTeams.ForEach(team => { comboBox1.Items.Add(team.ToArray()[0]); });
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (projecttextBox.Text.Length < 1 || budgettextBox.Text.Length < 1)
            {
                MessageBox.Show("Make sure that you filled all the categories");
                return;
            }
            Validation val = new Validation();
            if (!val.isNumber(budgettextBox.Text))
            {
                MessageBox.Show("Make sure that your budget contains only digits");
                return;
            }
            if(DateTime.Parse(StartingDate.Text.ToString()) >= DateTime.Parse(Deadline.Text.ToString()))
            {
                MessageBox.Show("Make sure that your dates are logical");
                return;
            }
            DB dbHandler = DB.Instance;
            if(dbHandler.IsExist("SELECT * FROM [project] WHERE id = '" + projecttextBox.Text + "'"))
            {
                MessageBox.Show("Project allready exist");
                return;
            }
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                new myMessageBox("The team that you choosed has not been found. \n Do you want to create a new team?", () => { new createTeamForm(id).Show(); }, () => { myMessageBox.ActiveForm.Hide(); }).Show();
            }
            else
            {
                dbHandler.UpdateDB("INSERT INTO [project] ([id],[sDate],[eDate],[budget],[tId],[projectLeader]) VALUES ('" + projecttextBox.Text.ToString() + "','" + DateTime.Parse(StartingDate.Text.ToString()).ToString().Substring(0, 10) + "','" + DateTime.Parse(Deadline.Text.ToString()).ToString().Substring(0, 10) + "','" + budgettextBox.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + id + "')");
                this.Hide();
                string query = @"
                SELECT p.id
                FROM [user] u, [userToTeam] t, [project] p
                WHERE u.id = t.uid AND t.id = p.tid AND u.id = '" + id + "'";
                homePage.GetInstance(id).updatehomePage(id, "My projects", query, "project");
                new projectReview(new Project(projecttextBox.Text.ToString(), DateTime.Parse(StartingDate.Text.ToString()).ToString().Substring(0, 10), DateTime.Parse(Deadline.Text.ToString()).ToString().Substring(0, 10), double.Parse(budgettextBox.Text.ToString()), comboBox1.Text.ToString(),id),id).Show();
            }
        }
    }
}
