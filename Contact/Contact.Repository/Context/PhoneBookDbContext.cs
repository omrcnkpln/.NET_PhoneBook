using Contact.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact.Repository.Context
{
    public class PhoneBookContactDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Core.Models.Contact>? Contacts { get; set; }

        public PhoneBookContactDbContext(DbContextOptions<PhoneBookContactDbContext> options)
         : base(options)
        {
        }
    }
}
