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

namespace TaskManagment.forms
{
    public partial class createReportForm : Form
    {
        DB dbHandler = DB.Instance;
        string id;
        public createReportForm(string id)
        {
            InitializeComponent();
            projectComboBox.Items.Clear();
            this.id = id;
            foreach(List<string> item in dbHandler.Query("SELECT p.id " +
                "FROM [project] p, [userToTeam] t " +
                "WHERE p.tId = t.id AND t.uId = '" + id + "'"))
            {
                projectComboBox.Items.Add(item.ToArray()[0]);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (reporttextBox.Text.Length < 1 || hourstextBox.Text.Length < 1)
            {
                MessageBox.Show("Make sure that you filled all the categories");
                return;
            }
            Validation val = new Validation();
            if (!val.isNumber(hourstextBox.Text))
            {
                MessageBox.Show("Make sure that hours contains only digits");
                return;
            }
            if(!projectComboBox.Items.Contains(projectComboBox.Text) && projectComboBox.Text != "")
            {
                MessageBox.Show("Make sure that your project is in the list");
                return;
            }
            if (!TaskComboBox.Items.Contains(TaskComboBox.Text))
            {
                MessageBox.Show("Make sure that your task is in the list");
                return;
            }
            if (dbHandler.IsExist("SELECT * FROM [report] WHERE id = '" + reporttextBox.Text + "' AND pId = '" + projectComboBox.Text + "' AND taskId = '" + TaskComboBox.Text + "'"))
            {
                MessageBox.Show("Report allready exist");
                return;
            }
            if (DateTime.Parse(Date.Text.ToString()) > DateTime.Today)
            {
                MessageBox.Show("Date is not Valid");
                return;
            }
            double hourRate = double.Parse(dbHandler.Query("SELECT hourRate FROM [user] WHERE id = '" + id + "'").ToArray()[0].ToArray()[0]);
            double totalBudget = double.Parse(dbHandler.Query("SELECT budget FROM [project] WHERE id = '" + projectComboBox.Text + "'").ToArray()[0].ToArray()[0]);
            double budgetused = 0;
            string query = "SELECT u.hourRate, r.hours " +
                "FROM [user] u, [report] r " +
                "WHERE r.pId = '" + projectComboBox.Text + "' AND r.uId = u.id";
            List<List<string>> data = dbHandler.Query(query);
            foreach (List<string> item in data)
            {
                budgetused += double.Parse(item.ToArray()[0]) * double.Parse(item.ToArray()[1]);
            }
            if (budgetused + hourRate * double.Parse(hourstextBox.Text) > totalBudget)
            {
                MessageBox.Show("The project will exceed the budget, so it is not possible to report such a number of work on the project");
                return;
            }
            dbHandler.UpdateDB("INSERT INTO [report] ([id],[pId],[taskId],[hours],[reportDate],[uId]) VALUES ('" + reporttextBox.Text.ToString() + "','" + projectComboBox.Text.ToString() + "','" + TaskComboBox.Text.ToString() + "','" + hourstextBox.Text.ToString() + "','" + DateTime.Parse(Date.Text.ToString()).ToString().Substring(0, 10) + "','" + id + "')");
            this.Hide();
            query = @"
                SELECT r.id
                FROM [report] r
                WHERE r.uid = '" + id + "'";
            homePage.GetInstance(id).updatehomePage(id, "My reports", query, "report");
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskComboBox.Items.Clear();
            foreach (List<string> item in dbHandler.Query("SELECT id FROM [task] WHERE pId = '" + projectComboBox.SelectedItem.ToString()+"'"))
            {
                TaskComboBox.Items.Add(item.ToArray()[0]);
            }
        }
    }
}
