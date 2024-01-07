
namespace TodoMVC.Models
{
    public class Todo : ITodo
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }  = DateTime.Now.Date;
        public bool IsCompleted { get; set; }

        public Todo(string title, string description, DateTime createdDate, bool isCompleted = false)
        {
            Title = title;
            Description = description;
            CreatedDate = createdDate;
            this.IsCompleted = isCompleted;
        }

        public Todo(int id, string title, string description, DateTime createdDate, bool isCompleted = false)
        {
            Id = id;
            Title = title;
            Description = description;
            CreatedDate = createdDate;
            this.IsCompleted = isCompleted;
        }
    }
}
