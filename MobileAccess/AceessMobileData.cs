using Microsoft.EntityFrameworkCore;
using PhoneDomin;

namespace MobileAccess
{
    public class AceessMobileData:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Mobile;");
        }
        public DbSet<MobilePhone> Mobiles { get; set; }
        public DbSet<Specifications> Specifications { get; set; }
    }
}