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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManagment.forms
{
    public partial class signUpForm : Form
    {
        DB dbHandler;
        public signUpForm()
        {
            InitializeComponent();
            dbHandler = DB.Instance;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginForm().Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            //check validation
            if (passwordBox.Text != confirmPasswordBox.Text)
            {
                MessageBox.Show("password are not the same");
            }
            else {
                string query = "SELECT * FROM [user] WHERE id = '" + idBox.Text + "'";
                if (dbHandler.IsExist(query))
                {
                    MessageBox.Show("User allready exist");
                }
                else
                {
                    if (!jobDescriptionBox.Items.Contains(jobDescriptionBox.Text))
                    {
                        MessageBox.Show("Choose job description from the list");
                    }
                    else {
                        query = "INSERT INTO [user] ([id],[password],[company],[name],[fName],[jobDescription],[hourRate]) VALUES ('" + idBox.Text + "','" + passwordBox.Text + "','" + companyBox.Text + "','" + nameBox.Text + "','" + fNameBox.Text + "','" + jobDescriptionBox.Text + "','" + hourRateBox.Text + "')";
                        dbHandler.UpdateDB(query);
                        MessageBox.Show("Sigend up successfully");
                        this.Hide();
                        new loginForm().Show();
                    }
                }
            }
        }
    }
}
