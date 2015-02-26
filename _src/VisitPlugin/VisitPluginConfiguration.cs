using System.Data.Entity.Migrations;
using Core;
using VisitPlugin.Migrations;

namespace VisitPlugin
{
    public class VisitPluginConfiguration : IPlugin
    {
        public void Install()
        {
            var migratorConfig = new VisitConfiguration() { AutomaticMigrationsEnabled = true };
            var migrator = new DbMigrator(migratorConfig);
            migrator.Update();
        }

        public void Uninstall()
        {
            var migratorConfig = new VisitConfiguration() { AutomaticMigrationDataLossAllowed = true };
            var migrator = new DbMigrator(migratorConfig);
            migrator.Configuration.AutomaticMigrationDataLossAllowed = true;
            migrator.Update(DbMigrator.InitialDatabase);
        }
    }
}
