using Contact.Core.Models;
using Contact.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Contact.Repository.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
