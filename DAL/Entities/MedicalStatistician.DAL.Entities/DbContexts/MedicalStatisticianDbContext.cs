using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities.DbContexts
{
    public class MedicalStatisticianDbContext : DbContext
    {
        public MedicalStatisticianDbContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<Judgment>()
                .Property(j => j.TypeOfJudgment)
                .HasConversion<string>();
        }
    }
}
