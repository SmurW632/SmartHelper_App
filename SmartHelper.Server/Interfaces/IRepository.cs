namespace SmartHelper.Server.Interfaces
{
    public interface IRepository<T>
    {
        public T GetById(int id);
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);
    }
}
