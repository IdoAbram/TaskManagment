using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagment.forms;

namespace TaskManagment.design
{
    internal class templatePanel : Panel
    {
        template templateForm;
        public templatePanel(string username)
        {
            this.Width = 372;
            this.Height = 886;
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
            Form form = this.FindForm();
            form.Hide();
        }
    }
}
