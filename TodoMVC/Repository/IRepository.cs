namespace TodoMVC.Repository
{
    public interface IRepository<T>
    {
        public IEnumerable<T> Get();
        public T GetById(int? id);
        public void  Add(T entity);
        public T Update(T entity, int id);
        public void Delete(int id);
    }
}
