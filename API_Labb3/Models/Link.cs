using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Labb3.Models
{
    public class Link
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }

        public int? InterestId { get; set; }
        [JsonIgnore]
        public Interest? Interest { get; set; }
        public int? PersonId { get; set; }
        [JsonIgnore]
        public Person? Person { get; set; }

    }
}
