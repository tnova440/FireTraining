using System.ComponentModel.DataAnnotations;

namespace FireTrainingApp.Models
{
    public class Meeting
    {
        [Required]
        public int MeetingId { get; set; }
        [Required]
        [MaxLength(20)]
        public string MeetingName { get; set; }
        public Location? Location { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public List<Member>? Attendance { get; set; }
        public string? Description { get; set; }
    }
}
