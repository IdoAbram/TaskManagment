using System;
using System.Collections;
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
using TaskManagment.design;

namespace TaskManagment.forms
{
    public partial class homePage : Form
    {
        string table;
        DB dbHandler = DB.Instance;
        public homePage(string id)
        {
            InitializeComponent();
            this.Controls.Add(new templatePanel(id));
            putTitle("My Projects");
            string query = @"
                SELECT p.id
                FROM [user] u, [team] t, [project] p
                WHERE u.id = t.uid AND t.id = p.tid AND u.id = '" + id +"'";
            this.Controls.Add(new myList(query,"project", (myId,currentTable) =>
            {
                List<string> list = dbHandler.Query("SELECT * FROM " + currentTable + " WHERE id = '" + myId + "'").ToArray()[0];
                new projectReview(new Project(list.ToArray()[0], list.ToArray()[1], list.ToArray()[2], double.Parse(list.ToArray()[3]), list.ToArray()[4])).Show();
            }));
        }

        public homePage(string id, string title, string query,string table)
        {
            InitializeComponent();
            this.Controls.Add(new templatePanel(id));
            putTitle(title);
            if (table == "task")
            {
                this.Controls.Add(new taskGrid("SELECT t1.id, t1.description, t1.pid, t1.tid, t1.status " +
        "FROM [task] t1, [team] t2, [user] u " +
        "WHERE u.id = '" + id + "' AND u.id = t2.uid AND t2.id = t1.tid"));
            }
            else if(table == "report")
            {
                taskGrid grid = new taskGrid("SELECT * FROM [report] WHERE uId = '" + id + "'");
                grid.Width = 644;
                grid.Location = new System.Drawing.Point(375, 150);
                this.Controls.Add(grid);
            }
            else
            {
                this.Controls.Add(new myList(query, table, (myId, currentTable) =>
                {
                    List<string> list = dbHandler.Query("SELECT * FROM " + currentTable + " WHERE id = '" + myId + "'").ToArray()[0];
                    switch (currentTable)
                    {
                        case "project":
                            new projectReview(new Project(list.ToArray()[0], list.ToArray()[1], list.ToArray()[2], double.Parse(list.ToArray()[3]), list.ToArray()[4])).Show();
                            break;

                        case "team":
                            //new teamReview(new Team().Show();
                            break;;

                        default:
                            MessageBox.Show("Class not recognized.");
                            break;
                    }
                }));
            }
        }

        private void putTitle(string title)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Text = title;
            label.Font = new System.Drawing.Font(label.Font.FontFamily, 36, System.Drawing.FontStyle.Regular);
            label.ForeColor = System.Drawing.Color.Black;
            label.Location = new Point(this.Width - label.PreferredWidth - 100, 40);

            this.Controls.Add(label);
        }
    }
}
