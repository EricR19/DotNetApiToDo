using Microsoft.EntityFrameworkCore;
using ToDoAPI.Models;
using Task = ToDoAPI.Models.Task;

namespace TodoApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
