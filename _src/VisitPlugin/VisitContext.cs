using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VisitPlugin.Models;

namespace VisitPlugin
{
    public class VisitContext : DbContext
    {
        public VisitContext()
            : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Visit> Visits { get; set; }
    }
}
