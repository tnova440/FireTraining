using System.Data.Entity;

namespace FireTrainingApp.Models
{
    public class MemberContext: DbContext
    {
        public DbSet<Member> Member { get; set; }
    }
}
