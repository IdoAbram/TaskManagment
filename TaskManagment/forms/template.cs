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
        public template(string username)
        {
            InitializeComponent();
            usernameLabel.Text = "hello " + username;
        }

    }
}
