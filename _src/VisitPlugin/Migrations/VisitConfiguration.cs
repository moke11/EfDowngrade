using System.Data.Entity.Migrations;
using VisitPlugin.Models;

namespace VisitPlugin.Migrations
{
    internal sealed class VisitConfiguration : DbMigrationsConfiguration<VisitContext>
    {
        public VisitConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = this.GetType().FullName;
        }

        protected override void Seed(VisitContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Visits.Add(new Visit() { IpAddress = "192.169.1.1" });
        }
    }
}
