using EllipticCurve.Utils;
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
using TaskManagment.classes;

namespace TaskManagment.forms
{
    public partial class createTeamForm : Form
    {
        string id;
        public createTeamForm(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DB dbHandler = DB.Instance;
            dbHandler.UpdateDB("INSERT INTO [team] ([id],[uId]) VALUES ('" + textBox1.Text.ToString() + "','" + id + "')");
            this.Hide();
            string query = @"
                SELECT t.id
                FROM [user] u, [team] t
                WHERE u.id = t.uid AND u.id = '" + id + "'";
            homePage.GetInstance(id).updatehomePage(id, "My teams", query, "team");
            new teamReview(new Team(textBox1.Text.ToString())).Show();
        }
    }
}
