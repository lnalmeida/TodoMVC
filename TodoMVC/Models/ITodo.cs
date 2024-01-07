namespace TodoMVC.Models
{
    public interface ITodo
    {
        int Id { get; set; }
        string Title { get; set; } 
        string Description { get; set; }
        DateTime CreatedDate { get; set; }
        bool IsCompleted { get; set; }
    }
}
