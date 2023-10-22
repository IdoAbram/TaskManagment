using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using TaskManagment.classes;
using System.Drawing;

public class taskGrid : DataGridView
{
    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TaskManagerDB1.accdb";
    string query;
    DB dB = DB.Instance;
    public taskGrid(string query)
    {
        this.BackgroundColor = Color.White;
        this.Height = 500;
        this.query = query;
        InitializeComponents();
        LoadData();
        Button saveButton = new Button();
        saveButton.Text = "Save";
        saveButton.BackColor = Color.LightBlue;
        saveButton.Click += SaveButton_Click; // Attach an event handler
        this.Controls.Add(saveButton);
        saveButton.Width = 42;
    }

    private void InitializeComponents()
    {
        // Set up other properties of your DataGridView
        this.Anchor = AnchorStyles.Right;
        this.BackgroundColor = Color.WhiteSmoke;
    }

    private void LoadData()
    {
        // Replace this with your database query logic
        DataTable dataTable = new DataTable();
        dB.Connection.Close();
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }
            connection.Close();
        }
        dB.Connection.Open();

        this.DataSource = dataTable;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        // Create a DataTable to hold the changes
        DataTable changes = ((DataTable)this.DataSource).GetChanges();

        if (changes != null)
        {
            dB.Connection.Close();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    // Configure the DataAdapter to perform updates
                    using (OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter))
                    {
                        adapter.UpdateCommand = builder.GetUpdateCommand();
                        adapter.InsertCommand = builder.GetInsertCommand();
                        adapter.DeleteCommand = builder.GetDeleteCommand();

                        // Update the database with changes
                        adapter.Update(changes);
                    }
                }
                connection.Close();
            }
            dB.Connection.Open();
            // Accept changes to reflect updates in the DataTable
            ((DataTable)this.DataSource).AcceptChanges();
        }
    }

}
