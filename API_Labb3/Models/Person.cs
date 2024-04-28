using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

namespace API_Labb3.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        [JsonIgnore]
        public ICollection<Interest>? Interests { get; set; }
        [JsonIgnore]
        public ICollection<Link>? Links { get; set; }
    }
}
