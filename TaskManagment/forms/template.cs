using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagment.forms
{
    public partial class template : Form
    {
        string username;
        public event EventHandler SignOutClicked;
        public template(string username)
        {
            InitializeComponent();
            this.username = username;
            usernameLabel.Text = "hello " + username;

            signoutButton.Click += (sender, e) =>
            {
                OnSignOutClicked();
            };
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.OnSignOutClicked();
            loginForm login = new loginForm();
            login.ShowDialog();
        }

        protected virtual void OnSignOutClicked()
        {
            SignOutClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
