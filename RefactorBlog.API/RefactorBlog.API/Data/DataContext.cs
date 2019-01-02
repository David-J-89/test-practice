using Microsoft.EntityFrameworkCore;
using RefactorBlog.API.Models;

namespace RefactorBlog.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
