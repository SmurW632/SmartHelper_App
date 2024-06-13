namespace SmartHelper.Server.Data.Repositories
{
    public interface IRepository<T>
    {
        public T GetById(int id);
        void Read(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
