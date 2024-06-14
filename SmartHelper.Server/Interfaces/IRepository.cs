namespace SmartHelper.Server.Interfaces
{
    public interface IRepository<T>
    {
        public T GetById(int id);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
