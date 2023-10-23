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
                "FROM [project] p, [team] t " +
                "WHERE p.tId = t.id AND t.uId = '" + id + "'"))
            {
                projectComboBox.Items.Add(item.ToArray()[0]);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            dbHandler.UpdateDB("INSERT INTO [report] ([id],[pId],[taskId],[hours],[date],[uId]) VALUES ('" + reporttextBox.Text.ToString() + "','" + projectComboBox.Text.ToString() + "','" + TaskComboBox.Text.ToString() + "','" + hourstextBox.Text.ToString() + "','" + DateTime.Parse(Date.Text.ToString()).ToString().Substring(0, 10) + "','" + id + "')");
            this.Hide();
            string query = @"
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
