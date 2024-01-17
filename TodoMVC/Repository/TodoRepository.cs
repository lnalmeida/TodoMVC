using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Runtime.CompilerServices;
using TodoMVC.Contexts;
using TodoMVC.Models;
using X.PagedList;

namespace TodoMVC.Repository;

public class TodoRepository : IRepository<Todo> 
{
    private readonly AppDbContext _context;
    public TodoRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IPagedList<Todo>> GetAllPaged(int pageNumber, int pageSize)
    {
        try
        {
            var todos = await _context.Todos.AsNoTracking().OrderByDescending(x => x.IsCompleted).ToPagedListAsync(pageNumber, pageSize); 
            return todos;
        } catch (Exception ex)
        {
            throw new Exception($"An error ocurred on search data. Details: {ex.Message}");
        }
    }
    public async Task<Todo> GetById(int id)
    {
        try
        {
            var todo = await _context.Todos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (todo == null) return null;
            return todo;
        } catch(Exception ex)
        {
            throw new Exception($"An error ocurred on search data. Details: {ex.Message}");
        }
    }

    public async Task Add(Todo todo)
    {
        try
        {
            _context.Add(todo);
            await _context.SaveChangesAsync();
        } catch (Exception ex)
        {
            throw new Exception($"An error ocurred on save data. Details: {ex.Message}");
        }
    }

    public async Task Delete(int id)
    {
        try
        {
            var existingTodo = _context.Todos.FirstOrDefault(x => x.Id == id);
            if (existingTodo != null)
            {
                _context.Remove(existingTodo);
                await _context.SaveChangesAsync();
            } 

        } catch (Exception ex) 
        {
           throw new Exception($"An error ocurred on delete data. Details: {ex.Message}");
        }
    }

    public async Task CompleteToDo(int id)
    {
        var todo = await _context.Todos.FindAsync(id);
        if (todo != null)
        {
            todo.IsCompleted = true;
            await _context.SaveChangesAsync();
        }
    }

    public async Task Update(int id, Todo todo)
    {
        try
        {
            var existingTodo = await _context.Todos.FindAsync(id);
            if (existingTodo != null)
            {
                _context.Entry(existingTodo).CurrentValues.SetValues(todo);
                await _context.SaveChangesAsync();
            }

        } catch (Exception ex)
        {
            throw new Exception($"An error ocurred on update data. Details: {ex.Message}");
        }
    }
}
