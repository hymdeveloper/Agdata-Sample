using System.ComponentModel.DataAnnotations;

namespace SampleApp.API.DTOs
{
    public class PersonDto
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
