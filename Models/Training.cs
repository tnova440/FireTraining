using System.ComponentModel.DataAnnotations;
namespace FireTrainingApp.Models
{
    public class Training
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Required]
        public int TrainingId { get; set; }
        [Required]
        [MaxLength(100)]
        public string TrainingName { get; set; }
        public Location? Location { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public List<Member>? Attendance { get; set; }
        public string? Description { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
