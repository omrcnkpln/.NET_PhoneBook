using Contact.Core.Models;
using Contact.Core.Requests;

namespace Contact.Service.Abstract
{
    public interface IUserService
    {
        Task<IList<User>> GetAllAsync();
        Task<IList<User>> GetAllWithIncludesAsync();
        //Task<User> GetAsync(int mattressId);
        Task<bool> AddAsync(UserRequest userRequest);
        //Task<User> UpdateAsync(UserRequest userRequest);
        //Task DeleteAsync(int mattressId);
    }
}
