using Microsoft.EntityFrameworkCore;
using TodoMVC.Contexts;
using TodoMVC.Models;

namespace TodoMVC.Repository;

public class TodoRepository : IRepository<Todo>
{
    private readonly AppDbContext _context;
    public TodoRepository(AppDbContext context)
    {
        _context = context;
    }
    public void Add(Todo entity)
    {
         _context.AddAsync(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
         _context.Remove(id);
        _context.SaveChanges();
    }

    public IEnumerable<Todo> Get()
    {
        return _context.Todos.ToList();
    }

    public  Todo GetById(int? id)
    {
        if(id != null)
        {
            return _context.Todos.FirstOrDefault(x => x.Id ==id);
        }
        return null;
    }

    public Todo Update(Todo entity, int id)
    {
        var existingTodo = _context.Todos.FirstOrDefault(x => x.Id == id);
        if (existingTodo != null)
        {
            _context.Entry(existingTodo).CurrentValues.SetValues(entity);
            _context.SaveChanges();
            return entity;
        }

        return null;
    }
}
