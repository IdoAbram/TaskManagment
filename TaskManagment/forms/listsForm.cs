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
        public listsForm(string username)
        {
            string query1 = "select name from taskList where user = '" + username + "'";
            InitializeComponent();
            this.Controls.Add(new templatePanel(username));
            putTitle();
            this.Controls.Add(new myList(query1, (taskListName) =>
            {
                string query2 = "SELECT name FROM task WHERE user = '" + username + "' AND taskListName = '" + taskListName + "'";
                listPage listPage = new listPage(username, query2, taskListName);
                this.Hide();
                listPage.ShowDialog();
            }));
        }

        private void putTitle()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Text = "My Lists";
            label.Font = new System.Drawing.Font(label.Font.FontFamily, 36, System.Drawing.FontStyle.Regular);
            label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(170)))));
            label.Location = new Point(this.Width - label.PreferredWidth - 250, 40);

            this.Controls.Add(label);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
