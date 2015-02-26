using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EfConsole.CustomerPlugin.Models;

namespace EfConsole.CustomerPlugin
{
    public class CustomerContext : DbContext
    {
        public CustomerContext()
            : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
