using System.Data.Entity.Migrations;
using Core;
using EfConsole.CustomerPlugin.Migrations;

namespace EfConsole.CustomerPlugin
{
    public class CustomerPluginConfiguration : IPlugin
    {
        public void Install()
        {
            var migratorConfig = new CustomerConfiguration() { AutomaticMigrationsEnabled = true };
            var migrator = new DbMigrator(migratorConfig);

            migrator.Update();
        }

        public void Uninstall()
        {
            var migratorConfig = new CustomerConfiguration() { AutomaticMigrationDataLossAllowed = true };
            var migrator = new DbMigrator(migratorConfig);
            migrator.Configuration.AutomaticMigrationDataLossAllowed = true;
            migrator.Update(DbMigrator.InitialDatabase);
        }
    }
}
