using Magic_Villa_Villa_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Magic_Villa_Villa_API.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
       
        public DbSet<Villa> Villas { get; set; }
    }
}
