using System.ComponentModel.DataAnnotations;

namespace FireTrainingApp.Models
{
    public class Location
    {
        [Required]
        public int LocationId { get; set; }
        [Required]
        [MaxLength(70)]
        [MinLength(3)]
        public string LocationName { get; set; }
        [MaxLength(70)]
        [MinLength(5)]
        public string Address { get; set; }
    }
}
