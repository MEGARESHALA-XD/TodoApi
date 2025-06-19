namespace TodoApi.Models
{
    public class ItemCategory
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<TodoItem> TodoItems { get; set; } = new();
    }
}