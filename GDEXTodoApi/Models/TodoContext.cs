using Microsoft.EntityFrameworkCore;

namespace GDEXTodoApi.Models
{
    public class TodoContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
