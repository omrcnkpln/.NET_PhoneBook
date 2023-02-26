using Contact.Service.Abstract;

namespace Contact.Service.Concrete
{
    public class UnitOfService : IUnitOfService
    {
        public readonly IUserService _userService;


        public UnitOfService(IUserService userService)
        {
            _userService = userService;
        }

        //Delegates
        public IUserService User => _userService;
    }
}
