using System.ComponentModel.DataAnnotations;

namespace FireTrainingApp.Models
{
    public class Member
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Required]
        public int MemberId { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        [MinLength(2)]
        public string lastName { get; set; }
        //public string email { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
