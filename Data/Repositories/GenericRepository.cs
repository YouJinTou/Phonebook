using System.Data.SQLite;

namespace Data.Repositories
{
    // This class is an attempt to provide a layer of abstraction between
    // the database provider (SQLite in this case) and the application.
    // In this application, we don't really need a GenericRepository,
    // because we only have on repository -- the EntryRepository,
    // but we might want to expand the application in the future
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    { 
        protected readonly SQLiteConnection connection;
        protected SQLiteCommand query;

        public GenericRepository(SQLiteConnection connection)
        {
            this.connection = new SQLiteConnection("data source=Phonebook.sqlite");
            this.query = new SQLiteCommand(connection);
        }

        public abstract void Add(T item);

        public abstract void Edit(T item);

        public abstract void Delete(T item);
    }
}
