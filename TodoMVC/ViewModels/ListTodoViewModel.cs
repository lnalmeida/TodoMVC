using TodoMVC.Models;

namespace TodoMVC.ViewModels
{
    public class ListTodoViewModel
    {
        public IEnumerable<Todo> Todos { get; set; } = new List<Todo>();
    }
}
