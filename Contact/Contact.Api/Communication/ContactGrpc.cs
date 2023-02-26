using Contact.Service.Abstract;
using ContactProto;
using Grpc.Core;
using static ContactProto.ContactService;

namespace Contact.Api.Communication
{
    public class ContactGrpc : ContactServiceBase
    {
        private readonly IUnitOfService _unitOfService;

        public ContactGrpc(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }


        public override async Task<UserListDTO> GetAllUsers(Empty request, ServerCallContext context)
        {
            var users = await _unitOfService.User.GetAllWithIncludesAsync();

            //forusers
            var grpcUsers = new List<UserDTO>();
            foreach (var user in users)
            {
                var grpcUser = new UserDTO()
                {
                    GRPCSucceeded = true,
                    UUID = user.UUID.ToString(),
                    Name = user.Name,
                    Surname = user.Surname,
                    Company = user.Company,
                };

                //forcontacts
                //var contactList = new List<ContactDTO>();
                foreach (var contact in user.Contacts)
                {
                    grpcUser.Contacts.Add(new ContactDTO
                    {
                        GRPCSucceeded = true,
                        UUID = contact.UUID.ToString(),
                        ContactInfo = contact.ContactInfo,
                        ContactType = (int)contact.ContactType,
                    });
                }

                grpcUsers.Add(grpcUser);
            }


            var userListDTO = new UserListDTO();
            userListDTO.Users.AddRange(grpcUsers);

            return userListDTO;
        }
    }
}
