using Models.Interfaces;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Data.Repositories
{
    public class EntryRepository : GenericRepository<IEntry>
    {
        public EntryRepository(SQLiteConnection connection)
            : base(connection)
        {
        }

        public override void Add(IEntry entry)
        {
            try
            {
                using (base.connection)
                {
                    base.connection.Open();

                    using (base.query)
                    {
                        base.query.CommandText = "INSERT INTO Entries ("
                            + "[Name], [Address], [GroupId]) "
                            + "VALUES(@Name, @Address, @GroupId)";

                        base.query.Parameters.Add(new SQLiteParameter("@Name") { Value = entry.Name });
                        base.query.Parameters.Add(new SQLiteParameter("@Address") { Value = entry.Address});
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

        public override void Delete(IEntry item)
        {
            throw new NotImplementedException();
        }

        public override void Edit(IEntry item)
        {
            throw new NotImplementedException();
        }
    }
}
