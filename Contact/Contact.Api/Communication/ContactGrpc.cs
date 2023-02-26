using ContactProto;
using Grpc.Core;
using static ContactProto.ContactService;

namespace Contact.Api.Communication
{
    public class ContactGrpc : ContactServiceBase
    {
        public override Task<ContactListDTO> GetAllContacts(Empty request, ServerCallContext context)
        {
            return base.GetAllContacts(request, context);
        }
    }
}
