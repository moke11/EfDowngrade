using System.Data.Entity.Migrations;
using EfConsole.CustomerPlugin.Models;

namespace EfConsole.CustomerPlugin.Migrations
{
    internal sealed class CustomerConfiguration : DbMigrationsConfiguration<CustomerContext>
    {
        public CustomerConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = GetType().FullName;
        }

        protected override void Seed(CustomerContext context)
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

            context.Customers.Add(new Customer() { FirstName = "Mickey", LastName = "Mouse" });
        }
    }
}
