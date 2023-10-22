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
            List<List<string>> myTeams = DB.Instance.Query("SELECT id From [team] WHERE uId = '" + id + "'");
            myTeams.ForEach(team => { comboBox1.Items.Add(team.ToArray()[0]); });
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DB dbHandler = DB.Instance;
            dbHandler.UpdateDB("INSERT INTO [project] ([id],[sDate],[eDate],[budget],[tId]) VALUES ('" + projecttextBox.Text.ToString() + "','" + DateTime.Parse(StartingDate.Text.ToString()).ToString().Substring(0, 10) + "','"+ DateTime.Parse(Deadline.Text.ToString()).ToString().Substring(0, 10) + "','" + budgettextBox.Text.ToString() + "','" + comboBox1.Text.ToString() + "')");
            this.Hide();
            string query = @"
                SELECT p.id
                FROM [user] u, [team] t, [project] p
                WHERE u.id = t.uid AND t.id = p.tid AND u.id = '" + id + "'";
            homePage.GetInstance(id).updatehomePage(id, "My projects", query, "project");
            new projectReview(new Project(projecttextBox.Text.ToString(),DateTime.Parse(StartingDate.Text.ToString()).ToString().Substring(0,10), DateTime.Parse(Deadline.Text.ToString()).ToString().Substring(0, 10), double.Parse(budgettextBox.Text.ToString()),comboBox1.Text.ToString()),id).Show();
        }
    }
}
