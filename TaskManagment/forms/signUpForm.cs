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
using TaskManagment.validation;

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
            Validation val = new Validation();
            if (companyBox.Text.Length < 1 || nameBox.Text.Length < 1 || fNameBox.Text.Length < 1 || hourRateBox.Text.Length < 1)
            {
                MessageBox.Show("Make sure that you filled all the categories");
                return;
            }

            if (idBox.Text.Length != 9)
            {
                MessageBox.Show("Make sure that your id is 9 letters");
                return;
            }

            if (passwordBox.Text.Length < 8)
            {
                MessageBox.Show("Make sure that your password is at list 8 letters");
                return;
            }

            if (!val.isletters(nameBox.Text) || !val.isletters(fNameBox.Text))
            {
                MessageBox.Show("Make sure that your name and your suraname contains only letters");
                return;
            }

            if (!val.isNumber(idBox.Text) || !val.isNumber(hourRateBox.Text))
            {
                MessageBox.Show("Make sure that your Id and your hour rate contains only digits");
                return;
            }

            if (passwordBox.Text != confirmPasswordBox.Text)
            {
                MessageBox.Show("password are not the same");
                return;
            }

            string query = "SELECT * FROM [user] WHERE id = '" + idBox.Text + "'";
            if (dbHandler.IsExist(query))
            {
                MessageBox.Show("User allready exist");
                return;
            }

            if (!jobDescriptionBox.Items.Contains(jobDescriptionBox.Text))
            {
                MessageBox.Show("Choose job description from the list");
                return;
            }

            query = "INSERT INTO [user] ([id],[password],[company],[name],[fName],[jobDescription],[hourRate]) VALUES ('" + idBox.Text + "','" + passwordBox.Text + "','" + companyBox.Text + "','" + nameBox.Text + "','" + fNameBox.Text + "','" + jobDescriptionBox.Text + "','" + hourRateBox.Text + "')";
            dbHandler.UpdateDB(query);
            MessageBox.Show("Sigend up successfully");
            this.Hide();
            new loginForm().Show();




        }
    }
}
    

