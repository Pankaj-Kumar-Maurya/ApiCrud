using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<tblContact> tblContacts { get; set; }
    }
}
