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
    public partial class homePage : Form
    {
        string username;
        template templateForm;
        public homePage(string username)
        {
            InitializeComponent();
            this.username = username;
            templateForm = new template(username);
            foreach (Control control in templateForm.Controls)
            {
                this.Controls.Add(control);
            }
            templateForm.SignOutClicked += TemplateForm_SignOutClicked; // Subscribe to the event
        }

        private void TemplateForm_SignOutClicked(object sender, EventArgs e)
        {
            templateForm.Close();
            this.Close();
        }
    }
}
