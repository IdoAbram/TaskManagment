using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TaskManagement.Classes;
using TaskManagment.classes;
using TaskManagment.design;
using TaskManagment.validation;

namespace TaskManagment.forms
{
    public partial class projectReview : Form
    {
        Project project;
        DB dbHandler = DB.Instance;
        string id;
        public projectReview(Project project,string id)
        {
            this.id = id;
            this.project = project;
            InitializeComponent();
            setUp();
        }
        private void setUp()
        {
            idBox.Text = project.Id;
            idBox.ReadOnly = true;
            LeaderIdBox.Text = project.Leader;
            LeaderIdBox.ReadOnly = true;
            sDateBox.Text = DateTime.Parse(project.StartDate).ToString();
            sDateBox.Enabled = false;
            eDateBox.Text = DateTime.Parse(project.EndDate).ToString();
            eDateBox.Enabled = false;
            budgetBox.Text = project.Budget.ToString();
            if(LeaderIdBox.Text != id)
            {
                editButton.Visible = false;
                saveButton.Visible = false;
                deleteButton.Visible = false;
            }
            budgetBox.ReadOnly = true;
            saveButton.Enabled = false;

            ////////////////////////////////////////Budget chart//////////////////////////////////////////////
            double budgetused = 0;
            string query = "SELECT u.hourRate, r.hours " +
                "FROM [user] u, [report] r " +
                "WHERE r.pId = '" + project.Id.ToString() + "' AND r.uId = u.id";
            List<List<string>> data = dbHandler.Query(query);
            foreach (List<string> item in data)
            {
                budgetused += double.Parse(item.ToArray()[0]) * double.Parse(item.ToArray()[1]);
            }
            budgetChart.Series.Clear();
            budgetChart.ChartAreas.Clear();

            // Create the chart area.
            ChartArea budgetChartArea = new ChartArea();
            budgetChart.ChartAreas.Add(budgetChartArea);

            // Create the "Used Budget" series and add data points.
            Series usedBudgetSeries = new Series("Used Budget");
            usedBudgetSeries.Points.AddY(budgetused); // Example value, replace with your data.
            usedBudgetSeries.ChartType = SeriesChartType.Column;

            // Create the "Budget Left" series and add data points.
            double budgetLeft = project.Budget - budgetused;
            if (budgetLeft < 0) { budgetLeft = 0; }
            Series budgetLeftSeries = new Series("Budget Left");
            budgetLeftSeries.Points.AddY(budgetLeft); // Example value, replace with your data.
            budgetLeftSeries.ChartType = SeriesChartType.Column;

            // Add the series to the chart.
            budgetChart.Series.Add(usedBudgetSeries);
            budgetChart.Series.Add(budgetLeftSeries);

            // Customize the chart appearance as needed.
            budgetChart.ChartAreas[0].AxisY.Title = "Amount  in $";

            usedBudgetSeries.IsValueShownAsLabel = true;
            budgetLeftSeries.IsValueShownAsLabel = true;
            ////////////////////////////////////////Task chart//////////////////////////////////////////////
            query = "SELECT id FROM task WHERE pid = '" + project.Id + "' AND status = true";
            double completedTasks = dbHandler.Query(query).ToArray().Length;
            query = "SELECT id FROM task WHERE pid = '" + project.Id + "' AND status = false";
            double uncompletedTasks = dbHandler.Query(query).ToArray().Length;

            taskChart.Series.Clear();
            taskChart.ChartAreas.Clear();

            // Create the chart area.
            ChartArea taskChartArea = new ChartArea();
            taskChart.ChartAreas.Add(taskChartArea);


            // Create the "Completed Tasks" series and add data points.
            Series completedTasksSeries = new Series("Completed Tasks");
            completedTasksSeries.Points.AddY(completedTasks);
            completedTasksSeries.ChartType = SeriesChartType.Column;

            // Create the "Uncompleted Tasks" series and add data points.
            Series uncompletedTasksSeries = new Series("Uncompleted Tasks");
            uncompletedTasksSeries.Points.AddY(uncompletedTasks);
            uncompletedTasksSeries.ChartType = SeriesChartType.Column;

            // Add the series to the chart.
            taskChart.Series.Add(completedTasksSeries);
            taskChart.Series.Add(uncompletedTasksSeries);

            // Customize the chart appearance as needed.
            taskChart.ChartAreas[0].AxisY.Title = "Number of Tasks";

            completedTasksSeries.IsValueShownAsLabel = true;
            uncompletedTasksSeries.IsValueShownAsLabel = true;

            ///////////////////////////////////////////////status text
            double taskPrecentage = 0;
            if (completedTasks + uncompletedTasks != 0) { taskPrecentage = completedTasks / (completedTasks + uncompletedTasks); }
            double budgetPrecentage = 0;
            if (budgetused + budgetLeft != 0) { budgetPrecentage = budgetused / (budgetused + budgetLeft); }

            double daysGoneBy = (DateTime.Today - DateTime.Parse(project.StartDate)).Days;
            double allDays = (DateTime.Parse(project.EndDate) - DateTime.Parse(project.StartDate)).Days;

            double daysPrecentage = daysGoneBy / allDays;
            if(daysPrecentage < 0) { daysPrecentage = 0; }
            statusLabel2.Text = ((int)(100 * taskPrecentage)).ToString() + "% of task/s has been complited out of " + (completedTasks + uncompletedTasks).ToString() + " task/s";
            statuslabel1.Text = ((int)(100 * budgetPrecentage)).ToString() + "% of budget has been used out of " + (project.Budget).ToString() + "$";
            statuslabel3.Text = ((int)(100 * daysPrecentage)).ToString() + "% of days has been used out of " + allDays.ToString() + " days";

            if (taskPrecentage + 0.15 > budgetPrecentage
                && taskPrecentage > daysPrecentage - 0.15 && taskPrecentage < daysPrecentage 
                && daysPrecentage < 0.85 && taskPrecentage < 0.85 && budgetPrecentage < 0.85)
            {
                descriptionStatusLabel.Text = "The project meet the budget requirements ";
                statusLabel.ForeColor = Color.DarkGoldenrod;
            }
            else if (taskPrecentage >= budgetPrecentage && taskPrecentage >= daysPrecentage)
            {
                descriptionStatusLabel.Text = "The project exceeded the budget requirements";
                statusLabel.ForeColor = Color.Green;
            }
            else
            {
                descriptionStatusLabel.Text = "The project below the budget requirements";
                statusLabel.ForeColor = Color.Red;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            sDateBox.Enabled = !sDateBox.Enabled;
            eDateBox.Enabled = !eDateBox.Enabled;
            budgetBox.ReadOnly = !budgetBox.ReadOnly;
            saveButton.Enabled = !saveButton.Enabled;
            if (editButton.Text.ToString() == "edit")
            {
                editButton.Text = "cancel";
            }
            else
            {
                editButton.Text = "edit";
                setUp();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (budgetBox.Text.Length < 1)
            {
                MessageBox.Show("Make sure that you filled your budget");
                return;
            }
            Validation val = new Validation();
            if (!val.isNumber(budgetBox.Text))
            {
                MessageBox.Show("Make sure that your budget contains only digits");
                return;
            }
            if (DateTime.Parse(sDateBox.Text.ToString()) >= DateTime.Parse(eDateBox.Text.ToString()))
            {
                MessageBox.Show("Make sure that your dates are logical");
                return;
            }
            DB dbHandler = DB.Instance;
            string query = "UPDATE [project] " +
                           "SET [sDate] = '" + sDateBox.Text + "', [eDate] = '" + eDateBox.Text + "', [budget] = '" + budgetBox.Text + "' " +
                           "WHERE id = '" + idBox.Text + "'";
            dbHandler.UpdateDB(query);
            project.StartDate = sDateBox.Text;
            project.EndDate = eDateBox.Text;
            project.Budget = double.Parse(budgetBox.Text);
            editButton_Click(sender, e);
        }

        public DateTime StringToDate(string date)
        {
            char separator = '/';
            string[] dateParts = date.Split(separator);

            if (dateParts.Length == 3)
            {
                int year, month, day;
                if (int.TryParse(dateParts[2], out year) &&
                    int.TryParse(dateParts[0], out month) &&
                    int.TryParse(dateParts[1], out day))
                {
                    try
                    {
                        DateTime dateTime = new DateTime(year, month, day);
                        return dateTime;
                    }
                    catch (Exception)
                    {
                        // Handle DateTime construction errors
                    }
                }
            }

            // Handle invalid input or parsing errors
            throw new ArgumentException("Invalid date format");
        }

        private void projectTeam_Click(object sender, EventArgs e)
        {
            new teamReview(new Team(project.TeamId),project.Id,id).Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            new myMessageBox("Are you sure you want to delete this project?\ndeliting this project you will delete all the tasks\n and reports that related to it", () =>
            {
                dbHandler.UpdateDB("DELETE FROM [project] WHERE id = '" + project.Id + "'");
                projectReview.ActiveForm.Hide();
                string query = @"
                SELECT p.id
                FROM [user] u, [userToTeam] t, [project] p
                WHERE u.id = t.uid AND t.id = p.tid AND u.id = '" + id + "'";
                homePage.GetInstance(id).updatehomePage(id, "My projects", query, "project");
            }, () => myMessageBox.ActiveForm.Hide()).Show();

        }
    }
}
