using Contact.Repository.Abstract;
using Contact.Repository.Context;

namespace Contact.Repository.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly PhoneBookDbContext _context;

        public readonly UserRepository _userRepository;

        public UnitOfWork(PhoneBookDbContext context)
        {
            _context = context;
        }

        public IUserRepository User => _userRepository ?? new UserRepository(_context);

        public async Task SaveChanges()
        {
            var forDebug = _context.ChangeTracker.Entries();
            await _context.SaveChangesAsync();
        }
    }
}
