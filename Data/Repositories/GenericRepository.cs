using System.Data.SQLite;

namespace Data.Repositories
{
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
