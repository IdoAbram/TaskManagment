using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using TaskManagment.classes;
using System.Drawing;
using System.Collections.Generic;
using TaskManagment.validation;

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
        this.AllowUserToAddRows = false;
    }

    private void InitializeComponents()
    {
        // Set up other properties of your DataGridView
        this.Location = new Point(430, 150);
        this.BackgroundColor = Color.WhiteSmoke;
        this.Height = 400;
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


        // Iterate through the columns and find the one with the header name "Task ID"
        foreach (DataColumn column in dataTable.Columns)
        {
            if (column.ColumnName == "Task ID")
            {
                column.ReadOnly = true; // Make the "Task ID" column read-only
                break; // Exit the loop since we found the column
            }
        }

        this.DataSource = dataTable;

    }
    private void SaveButton_Click(object sender, EventArgs e)
    {
        // Create a DataTable to hold the changes
        Validation val = new Validation();
        DataTable changes = ((DataTable)this.DataSource).GetChanges();

        if (changes != null)
        {
            try
            {
                foreach (DataRow row in changes.Rows)
                {
                    if (row.Table.Columns.Contains("Hours"))
                        if (!val.isNumber(row["Hours"].ToString()))
                            throw new Exception("Make sure that the hours represent by digits");
                    if (row.Table.Columns.Contains("Date"))
                        if (!val.isValidDate(row["Date"].ToString()))
                            throw new Exception("Illegal Date");
                }
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Illegal data has been entered");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LoadData();
            }
        }
    }
}
