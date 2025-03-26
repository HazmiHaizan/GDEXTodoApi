namespace GDEXTodoApi.Models
{
    public static class DbInitializer
    {
        public static void SeedItems(TodoContext context)
        {
            if (context.TodoItems.Any())
            {
                return;
            }

            var items = new List<TodoItem>
            {
                new TodoItem { Id = 1, Name = "Hazmi", Description = "Test Todo 1", DueDate = DateTime.Now.ToString("dd/MM/yyyy"), Status = "In Progress", Category = "Technical", Priority = "High"},
                new TodoItem { Id = 2, Name = "Johnny", Description = "Test Todo 2", DueDate = DateTime.Now.ToString("dd/MM/yyyy"), Status = "Completed", Category = "Functional", Priority = "High"},
                new TodoItem { Id = 3, Name = "Shamsul", Description = "Test Todo 3", DueDate = DateTime.Now.ToString("dd/MM/yyyy"), Status = "Overdue", Category = "Technical", Priority = "Low"}
            };

            context.TodoItems.AddRange(items);
            context.SaveChanges();
        }
    }
}
