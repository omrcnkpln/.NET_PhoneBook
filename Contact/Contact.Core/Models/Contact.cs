using Contact.Core.Enums;

namespace Contact.Core.Models
{
    public class Contact : BaseEntity
    {
        public ContactType ContactType { get; set; }
        public string ContactInfo { get; set; }
    }
}
