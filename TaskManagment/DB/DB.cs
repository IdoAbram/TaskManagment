using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TaskManagment.classes
{
    internal sealed class DB
    {
        private static readonly Lazy<DB> lazyInstance = new Lazy<DB>(() => new DB());
        private OleDbConnection connection;
        private OleDbCommand command;

        private DB()
        {
            // Initialize your OleDbConnection here
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TaskManagerDB1.accdb";
            connection = new OleDbConnection(connectionString);
            connection.Open();

            // Create a single command instance to be reused
            command = new OleDbCommand();
            command.Connection = connection;
        }

        public static DB Instance => lazyInstance.Value;

        public OleDbConnection Connection => connection;

        public bool IsExist(string query)
        {
            command.CommandText = query;
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                return reader.Read();
            }
        }

        public List<List<string>> Query(string query)
        {
            command.CommandText = query;
            List<List<string>> resultList = new List<List<string>>();

            using (OleDbDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    List<string> row = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader[i].ToString());
                    }
                    resultList.Add(row);
                }
            }

            return resultList;
        }

        public void UpdateDB(string query)
        {
            command.CommandText = query;
            command.ExecuteNonQuery();
        }

        // Ensure the connection is closed when the application exits
        ~DB()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
