using CRUD_MVC_SQL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC_SQL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
