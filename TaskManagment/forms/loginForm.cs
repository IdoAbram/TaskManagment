using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using TaskManagment.classes;

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
            string query = "SELECT * FROM [user] WHERE username = '" + usernameBox.Text +"' AND password = '"+ passwordBox.Text + "'";
            if(dbHandler.IsExist(query))
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
        }
    }
}
