using Aws_s3.Platform.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Aws_s3.Platform.Infrastructure.Database
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "UsersDb");
        }

        public DataContext()
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
