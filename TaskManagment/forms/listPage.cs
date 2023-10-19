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
using TaskManagment.design;

namespace TaskManagment.forms
{
    public partial class listPage : Form
    {
        public listPage(string username,string query, string title)
        {
            InitializeComponent();
            this.Controls.Add(new templatePanel(username));
            putTitle(title);
            this.Controls.Add(new myList(query, (text) => MessageBox.Show(text)));
        }

        private void putTitle(string title)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Text = title;
            label.Font = new System.Drawing.Font(label.Font.FontFamily, 36, System.Drawing.FontStyle.Regular);
            label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(170)))));
            label.Location = new Point(this.Width - label.PreferredWidth - 100, 40);

            this.Controls.Add(label);
        }


    }
}
