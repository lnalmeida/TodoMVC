
namespace TodoMVC.Models
{
    public class Todo : ITodo
    {


        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }  = DateTime.Now.Date;
        public bool IsCompleted { get; set; }

        public Todo() {}

        public Todo(int id, string title, string description, DateTime createdDate, bool isCompleted = false)
        {
            Id = id;
            Title = title;
            Description = description;
            CreatedDate = createdDate;
            IsCompleted = isCompleted;
        }
    }
}
