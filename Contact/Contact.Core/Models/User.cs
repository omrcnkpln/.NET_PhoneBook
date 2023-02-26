namespace Contact.Core.Models
{
    public class User : BaseEntity
    {
        public User()
        {
            Contact = new HashSet<Contact>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
