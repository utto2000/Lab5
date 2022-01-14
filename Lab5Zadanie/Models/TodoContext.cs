using Lab5Zadanie.Models.TodoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5Zadanie.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
               : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }

      
    }
}
