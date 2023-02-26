using Contact.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact.Repository.Context
{
    public class PhoneBookDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
         : base(options)
        {
        }
    }
}
