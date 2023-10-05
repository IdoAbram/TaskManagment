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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using TaskManagment.forms;

namespace TaskManagment
{
    public partial class loginForm : Form
    {
        DB dbHandler;
        public loginForm()
        {
            InitializeComponent();
            dbHandler = DB.Instance;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [user] WHERE username = '" + usernameBox.Text + "' AND password = '" + passwordBox.Text + "'";
            if (dbHandler.IsExist(query))
            {
                this.Hide();
                homePage t = new homePage(usernameBox.Text);
                t.Show();
            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [user] ([username],[password]) VALUES ('" + usernameBox.Text + "','" + passwordBox.Text + "')";
            dbHandler.UpdateDB(query);
            //GmailEmailSender.SendEmailAsync("abramovichido@gmail.com", "try", "53");
            MessageBox.Show("added successfully");
        }

        
    }
}
