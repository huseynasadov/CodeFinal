using Junko.Data.Entries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Junko.Repo.Data
{
   public class JunkoDbContext:DbContext
    {
        public JunkoDbContext(DbContextOptions<JunkoDbContext>options):base(options)
        {

        }
        public DbSet<Setting> Setting { get; set; }
        protected override void  OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Setting>().HasData(
                new Setting {
                Id=1,
                Logo="Junko"
                }
                );
        }
    }
}
