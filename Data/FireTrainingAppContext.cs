using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FireTrainingApp.Models;

namespace FireTrainingApp.Data
{
    public class FireTrainingAppContext : DbContext
    {
        public FireTrainingAppContext (DbContextOptions<FireTrainingAppContext> options)
            : base(options)
        {
        }

        public DbSet<FireTrainingApp.Models.Member> Member { get; set; } = default!;
    }
}
