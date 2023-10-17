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
    public partial class listPage : Form
    {
        string username;
        public listPage(string username,string query)
        {
            InitializeComponent();
            this.username = username;
            this.Controls.Add(new templatePanel(username));
        }
    }
}
