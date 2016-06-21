using System;
using System.Collections.Generic;
using soccerApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace soccerApp.DAL
{
    public class ManagerContext : DbContext
    {
        public ManagerContext() : base("ManagerContext")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Player>()
                    .HasRequired(p => p.Team)
                    .WithMany(t => t.Players)
                    .HasForeignKey(p => p.TeamID);
        }
    }
}