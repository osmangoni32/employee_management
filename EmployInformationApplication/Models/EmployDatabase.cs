using Microsoft.EntityFrameworkCore;

namespace EmployInformationApplication.Models
{
    public class EmployDatabase:DbContext
    {
        public EmployDatabase(DbContextOptions<EmployDatabase> Options):base(Options)
        {

        }
      
        public DbSet<EmployDatabaseModel> EmployDatabaseModelInDatabaseAsTable { get; set; }
    }
}
