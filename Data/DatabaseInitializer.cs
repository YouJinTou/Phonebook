using Models;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Data
{
    // A singleton class that is called at startup to check if the database exists.
    // If it doesn't, it creates it
    public sealed class DatabaseInitializer
    {
        private static readonly DatabaseInitializer initializer = new DatabaseInitializer();
        private readonly SQLiteConnection connection;
        private SQLiteCommand query;

        static DatabaseInitializer()
        {
        }

        private DatabaseInitializer()
        {
            this.connection = new SQLiteConnection("data source=Phonebook.sqlite");
        }

        public static DatabaseInitializer Initializer
        {
            get { return initializer; }
        }

        public void InitializeDatabase()
        {
            try
            {
                this.query = new SQLiteCommand(connection);

                using (this.connection)
                {
                    this.connection.Open();

                    using (this.query)
                    {
                        CreateTables();
                        PopulateGroupsTable();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void CreateTables()
        {
            this.query.CommandText = "CREATE TABLE IF NOT EXISTS Groups ("
                + "_id INTEGER PRIMARY KEY NOT NULL, "
                + "Name nvarchar(50) NOT NULL UNIQUE)";
            this.query.ExecuteNonQuery();

            this.query.CommandText = "CREATE TABLE IF NOT EXISTS Entries ("
                + "_id INTEGER PRIMARY KEY NOT NULL, "
                + "Name nvarchar(75) NOT NULL UNIQUE, "
                + "Address nvarchar(200), "
                + "GroupId int NOT NULL, "
                + "FOREIGN KEY (GroupId) REFERENCES Groups(_id))";
            this.query.ExecuteNonQuery();

            this.query.CommandText = "CREATE TABLE IF NOT EXISTS Phones ("
                + "_id INTEGER PRIMARY KEY NOT NULL, "
                + "Phone nvarchar(50) UNIQUE NOT NULL, "
                + "EntryId int NOT NULL, "
                + "FOREIGN KEY (EntryId) REFERENCES Entries(_id)"
                + "CONSTRAINT uc_PhoneEntry UNIQUE (EntryId, Phone))";
            this.query.ExecuteNonQuery();
        }

        private void PopulateGroupsTable()
        {
            this.query.CommandText = "SELECT COUNT(Name) FROM Groups";
            var rows = this.query.ExecuteScalar();

            if (rows.ToString() == "0")
            {
                foreach (Group group in Enum.GetValues(typeof(Group)))
                {
                    this.query.CommandText = "INSERT INTO Groups ([Name]) "
                    + "VALUES (@name)";

                    this.query.Parameters.Add(new SQLiteParameter("@name") { Value = group.ToString() });

                    this.query.ExecuteNonQuery();
                }
            }
        }
    }
}
