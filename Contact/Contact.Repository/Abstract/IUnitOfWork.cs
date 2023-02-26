namespace Contact.Repository.Abstract
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }

        Task SaveChanges();
    }
}
