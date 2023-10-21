using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagment.forms;
using TaskManagment.classes;
using TaskManagement.Classes;

namespace TaskManagment.forms
{
    public partial class template : Form
    {
        string id;
        public event EventHandler SignOutClicked;
        public template(string id)
        {
            DB dbHandler;
            dbHandler = DB.Instance;
            InitializeComponent();
            this.id = id;
            string query = "SELECT name , fName FROM [user] WHERE id = '" + id + "'";
            usernameLabel.Text = "Hello " + string.Join(" ", dbHandler.Query(query).ToArray()[0]);

            signoutButton.Click += (sender, e) =>
            {
                OnSignOutClicked();
            };
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.OnSignOutClicked();
            new loginForm().ShowDialog();
        }

        protected virtual void OnSignOutClicked()
        {
            SignOutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void project_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT p.id
                FROM [user] u, [team] t, [project] p
                WHERE u.id = t.uid AND t.id = p.tid AND u.id = '" + id + "'";
            OnSignOutClicked();
            new homePage(id,"My projects",query, "project").ShowDialog();
        }

        private void task_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT t2.id, t2.description, t2.tId
                FROM [user] u, [team] t1, [task] t2
                WHERE u.id = t1.uid AND t1.id = t2.tid AND u.id = '" + id + "'";
            OnSignOutClicked();
            new homePage(id, "My tasks", query, "task").ShowDialog();
        }

        private void team_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT t.id
                FROM [user] u, [team] t
                WHERE u.id = t.uid AND u.id = '" + id + "'";
            OnSignOutClicked();
            new homePage(id, "My teams", query, "team").ShowDialog();
        }

        private void report_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT r.id
                FROM [report] r
                WHERE r.uid = '" + id + "'";
            OnSignOutClicked();
            new homePage(id, "My reports", query, "report").ShowDialog();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            DB dbHandler = DB.Instance;
            List<string> user = dbHandler.Query("SELECT * FROM [user] WHERE id = '" + id + "'").ToArray()[0];
            new userReview(new User(user.ToArray()[0], user.ToArray()[1], user.ToArray()[2], user.ToArray()[3], user.ToArray()[4], user.ToArray()[5], double.Parse(user.ToArray()[6]))).Show();
        }
    }
}
