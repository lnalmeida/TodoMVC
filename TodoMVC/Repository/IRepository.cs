using TodoMVC.Models;
using X.PagedList;

namespace TodoMVC.Repository
{
    public interface IRepository<T> where T : class
    {
        public Task<IPagedList<T>> GetAllPaged(int pageNumber, int pageSize);
        public Task<T> GetById(int id);
        public Task Add(T entity);
        public Task Update(int id, T entity);
        public  Task Delete(int id);
    }
}
