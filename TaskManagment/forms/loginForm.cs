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
            string query = "SELECT id FROM [user] WHERE id = '" + idBox.Text + "' AND password = '" + passwordBox.Text + "'";
            if (dbHandler.IsExist(query))
            {
                this.Hide();
                new homePage(idBox.Text).Show();
            }
            else
            {
                MessageBox.Show("Incorrect id or password");
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new signUpForm().Show();
        }
    }
}
