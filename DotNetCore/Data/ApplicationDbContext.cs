using DotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        //From here we are creating table thats the beauty of the entity framework
        public DbSet<Category> Categories { get; set; }
    }
}
