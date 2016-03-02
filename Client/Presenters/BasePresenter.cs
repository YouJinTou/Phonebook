using Data.Repositories;
using Models.Interfaces;
using System.Data.SQLite;

namespace Client.Presenters
{
    // All presenters inherit from this one
    public abstract class BasePresenter
    {
        protected readonly SQLiteConnection connection;
        protected readonly GenericRepository<IEditableEntry> data;

        public BasePresenter()
        {
            this.connection = new SQLiteConnection("data source=Phonebook.sqlite");
            this.data = new EntryRepository(connection);    
        }

        public abstract void LoadView();

        public abstract void CloseView();
    }
}
