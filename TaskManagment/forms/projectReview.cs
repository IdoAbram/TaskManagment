using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Classes;

namespace TaskManagment.forms
{
    public partial class projectReview : Form
    {
        public projectReview(Project project)
        {
            InitializeComponent();
            idBox.Text=project.Id.ToString();
        }
    }
}
