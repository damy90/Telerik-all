namespace BulsAndCows.Data
{
    using System.Data.Entity;
    using BulsAndCows.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Linq;
    using BulsAndCows.Data.Migrations;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Game> Games { get; set; }
    }
}
