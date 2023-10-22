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
using TaskManagment.design;

namespace TaskManagment.forms
{
    public partial class userReview : Form
    {
        User user;
        public userReview(User user)
        {
            this.user = user;
            InitializeComponent();
            setUp();
        }
        private void setUp()
        {
            idBox.Text = user.Id.ToString();
            idBox.ReadOnly = true;
            passwordBox.Text = user.Password.ToString();
            passwordBox.ReadOnly = true;
            companyBox.Text = user.Company.ToString();
            companyBox.ReadOnly = true;
            nameBox.Text = user.Name.ToString();
            nameBox.ReadOnly = true;
            fNameBox.Text = user.FName.ToString();
            fNameBox.ReadOnly = true;
            jobDescriptionBox.Text = user.JobDescription.ToString();
            jobDescriptionBox.Enabled = false;
            hourRateBox.Text = user.HourRate.ToString();
            hourRateBox.ReadOnly = true;
            saveButton.Enabled = false;
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            saveButton.Enabled = !saveButton.Enabled;
            passwordBox.ReadOnly = !passwordBox.ReadOnly;
            companyBox.ReadOnly = companyBox.ReadOnly;
            nameBox.ReadOnly = !nameBox.ReadOnly;
            fNameBox.ReadOnly = !fNameBox.ReadOnly;
            jobDescriptionBox.Enabled = !jobDescriptionBox.Enabled;
            hourRateBox.ReadOnly = !hourRateBox.ReadOnly;
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

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (!jobDescriptionBox.Items.Contains(jobDescriptionBox.Text))
            {
                MessageBox.Show("Choose job description from the list");
            }
            else
            {
                DB dbHandler = DB.Instance;
                string query1 = "DELETE FROM [user] WHERE id = '" + idBox.Text + "'";
                string query2 = "INSERT INTO [user] ([id],[password],[company],[name],[fName],[jobDescription],[hourRate]) VALUES ('" + idBox.Text + "','" + passwordBox.Text + "','" + companyBox.Text + "','" + nameBox.Text + "','" + fNameBox.Text + "','" + jobDescriptionBox.Text + "','" + hourRateBox.Text + "')";
                dbHandler.UpdateDB(query1);
                dbHandler.UpdateDB(query2);
                user.Password = passwordBox.Text;
                user.Company = companyBox.Text;
                user.Name = nameBox.Text;
                user.FName = fNameBox.Text;
                user.JobDescription = jobDescriptionBox.Text;
                user.HourRate = double.Parse(hourRateBox.Text);
                editButton_Click_1(sender, e);
            }
        }
    }
}
