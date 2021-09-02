using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().ToTable("ToDoItems");
            //seed data
            modelBuilder.Entity<TodoItem>().HasData(new TodoItem
            {
                Id = 2343423423,
                Name = "just do it",
                IsComplete = false
            });
        }
    }
}