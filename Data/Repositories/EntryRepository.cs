using Models.Interfaces;
using System;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Data.Repositories
{
    // This is the main unit that established contact with the database.
    // All presenters have to go through here to add/delete/edit data
    public class EntryRepository : GenericRepository<IEditableEntry>
    {
        public EntryRepository(SQLiteConnection connection)
            : base(connection)
        {
        }

        public override void Add(IEditableEntry entry)
        {
            try
            {
                using (base.connection)
                {
                    base.connection.Open();

                    using (base.query)
                    {
                        base.query.CommandText = 
                            "INSERT INTO Entries ("
                            + "[Name], [Address], [GroupId]) "
                            + "VALUES(@Name, @Address, @GroupId)";

                        base.query.Parameters.Add(new SQLiteParameter("@Name") { Value = entry.Name });
                        base.query.Parameters.Add(new SQLiteParameter("@Address") { Value = entry.Address });
                        base.query.Parameters.Add(new SQLiteParameter("@GroupId") { Value = entry.GroupId });

                        base.query.ExecuteNonQuery();

                        base.query.CommandText = "SELECT last_insert_rowid()";
                        var lastEntryId = base.query.ExecuteScalar();

                        foreach (var phone in entry.PhoneNumbers)
                        {
                            base.query.CommandText = "INSERT INTO Phones ("
                            + "[Phone], [EntryId]) "
                            + "VALUES(@Phone, @EntryId)";

                            base.query.Parameters.Add(new SQLiteParameter("@Phone") { Value = phone });
                            base.query.Parameters.Add(new SQLiteParameter("@EntryId") { Value = lastEntryId });

                            base.query.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public override void Edit(IEditableEntry entry)
        {
            try
            {
                using (base.connection)
                {
                    base.connection.Open();
                    
                    using (base.query)
                    {
                        base.query.CommandText =
                            "UPDATE Phones "
                            + "SET Phone = @Phone "
                            + "WHERE Phone = @CurrentPhone";

                        base.query.Parameters.Add(new SQLiteParameter("@Phone") { Value = entry.PhoneNumbers.FirstOrDefault() });
                        base.query.Parameters.Add(new SQLiteParameter("@CurrentPhone") { Value = entry.CurrentPhone });

                        base.query.ExecuteNonQuery();

                        var entryId = this.GetEntryId(entry);                    

                        base.query.CommandText =
                            "UPDATE Entries "
                            + "SET Name = @Name, Address = @Address, GroupId = @GroupId "
                            + "WHERE _id = " + entryId;

                        base.query.Parameters.Add(new SQLiteParameter("@Name") { Value = entry.Name });
                        base.query.Parameters.Add(new SQLiteParameter("@Address") { Value = entry.Address });
                        base.query.Parameters.Add(new SQLiteParameter("@GroupId") { Value = entry.GroupId });

                        base.query.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Delete(IEditableEntry entry)
        {
            base.query.CommandText =
                            "DELETE FROM Phones "
                            + "WHERE Phone = @Phone";

            base.query.Parameters.Add(new SQLiteParameter("@Phone") { Value = entry.CurrentPhone });

            base.query.ExecuteNonQuery();

            var entryId = this.GetEntryId(entry);

            // Check how many entries are left for this entryId
            base.query.CommandText =
                            "SELECT Count(Phone) FROM Phones "
                            + "WHERE EntryId = @EntryId";

            base.query.Parameters.Add(new SQLiteParameter("@EntryId") { Value = entryId });

            var entryPhonesCount = Convert.ToInt32(base.query.ExecuteScalar());

            // There are no more phones for this entryId, delete it from the Entries table
            if (entryPhonesCount <= 0)
            {
                base.query.CommandText =
                            "DELETE FROM Entries "
                            + "WHERE _id = " + entryId;

                base.query.ExecuteNonQuery();
            }
        }

        private int GetEntryId(IEditableEntry entry)
        {
            base.query.CommandText =
                           "SELECT _id FROM Entries "
                           + "WHERE Name = @CurrentName AND Address = @CurrentAddress AND GroupId = @CurrentGroupId";

            base.query.Parameters.Add(new SQLiteParameter("@CurrentName") { Value = entry.CurrentEntryName });
            base.query.Parameters.Add(new SQLiteParameter("@CurrentAddress") { Value = entry.CurrentAddress });
            base.query.Parameters.Add(new SQLiteParameter("@CurrentGroupId") { Value = entry.CurrentGroupId });

            var entryId = base.query.ExecuteScalar();

            return int.Parse(entryId.ToString());
        }
    }
}
