using Microsoft.EntityFrameworkCore;
using RedisTest.Model;

namespace RedisTest.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) { }
        public DbSet<Product> Products
        {
            get;
            set;
        }
    }
}
