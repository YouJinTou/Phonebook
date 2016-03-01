using Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Data
{
    public class DataLoader
    {
        private readonly SQLiteConnection connection;
        private SQLiteCommand query;

        public DataLoader()
        {
            this.connection = new SQLiteConnection("data source=Phonebook.sqlite");
            this.query = new SQLiteCommand(connection);
        }

        public ICollection<Entry> GetEntries()
        {
            var entries = new HashSet<Entry>();

            try
            {
                using (this.connection)
                {
                    this.connection.Open();

                    using (this.query)
                    {
                        this.query.CommandText =
                            "SELECT e.Name, p.Phone, e.Address, g._id AS [Group] "
                            + "FROM Entries e JOIN Groups g "
                            + "ON e.GroupId = g._id "
                            + "JOIN Phones p "
                            + "ON e._id = p.EntryId";

                        SQLiteDataReader reader = this.query.ExecuteReader();

                        while (reader.Read())
                        {
                            var name = reader["Name"].ToString();
                            var phones = new string[] { reader["Phone"].ToString() };
                            var address = reader["Address"].ToString();
                            var group = (Group)Convert.ToInt16(reader["Group"]);
                            var entry = new Entry(name, phones, address, group);

                            entries.Add(entry);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return entries;
        }

        public IList<Group> GetGroups()
        {
            var groups = new List<Group>();

            foreach (Group group in Enum.GetValues(typeof(Group)))
            {
                groups.Add(group);
            }

            return groups;
        }
    }
}
