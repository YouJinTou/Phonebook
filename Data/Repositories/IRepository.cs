namespace Data.Repositories
{
    // Created for the purpose of passing to different presenters
    interface IRepository<T> where T : class
    {
        void Add(T item);
        void Delete(T item);
        void Edit(T item);
    }
}
