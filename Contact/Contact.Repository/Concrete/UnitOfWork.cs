using Contact.Repository.Abstract;
using Contact.Repository.Context;

namespace Contact.Repository.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly PhoneBookContactDbContext _context;

        public readonly UserRepository _userRepository;

        public UnitOfWork(PhoneBookContactDbContext context)
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
