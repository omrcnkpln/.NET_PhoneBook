using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Contact.Core.Models
{
    public class BaseEntity
    {
        [Key]
        [Required]

        public int Id { get; set; }

        [JsonIgnore]
        public Guid UUID { get; set; } = Guid.NewGuid();

        [JsonIgnore]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
