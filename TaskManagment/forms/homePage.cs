using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagment.design;

namespace TaskManagment.forms
{
    public partial class homePage : Form
    {
        string username;
        public homePage(string username)
        {
            InitializeComponent();
            this.username = username;
            templatePanel template = new templatePanel(username);
            this.Controls.Add(template);
        }
    }
}
