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

namespace TaskManagment.forms
{
    public partial class createTaskForm : Form
    {
        DB dbHandler = DB.Instance;
        string id;
        public createTaskForm(string id)
        {
            this.id = id;
            InitializeComponent();
            projectComboBox.Items.Clear();
            foreach (List<string> item in dbHandler.Query("SELECT p.id " +
                "FROM [project] p, [team] t " +
                "WHERE p.tId = t.id AND t.uId = '" + id + "'"))
            {
                projectComboBox.Items.Add(item.ToArray()[0]);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string team = dbHandler.Query("SELECT tId FROM [project] WHERE id = '" + projectComboBox.Text.ToString() + "'").ToArray()[0].ToArray()[0];
            dbHandler.UpdateDB("INSERT INTO [task] ([id],[description],[pId],[tId]) VALUES ('" + tasktextBox.Text.ToString() + "','" + DescriptiontextBox.Text.ToString() + "','" + projectComboBox.Text.ToString() + "','" + team + "')");
            this.Hide();
            string query = "SELECT t1.id AS [Task ID], t1.description AS Description, t1.pid AS [Project ID], t1.tid AS [Team ID], t1.status AS [Status] " +
                    "FROM [task] t1, [team] t2, [user] u " +
                    "WHERE u.id = '" + id + "' AND u.id = t2.uid AND t2.id = t1.tid";
            homePage.GetInstance(id).updatehomePage(id, "My tasks", query, "task");
        }
    }
}
