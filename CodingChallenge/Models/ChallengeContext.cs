using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodingChallenge.Models
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext() : base("ChallengeConnection")
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<UserProject> UserProject { get; set; }

    }
}