using Identity.Models;
using Matching.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matching.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Interest> Interests { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<Interest>().HasData(
                new Interest { InterestId = 1, Name = "Football" },
                new Interest { InterestId = 2, Name = "Reading" },
                new Interest { InterestId = 3, Name = "Yoga" },
                new Interest { InterestId = 4, Name = "Running" },
                new Interest { InterestId = 5, Name = "Movies" }

                );

            base.OnModelCreating(builder);
        }
    }
}
