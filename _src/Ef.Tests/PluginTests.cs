using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfConsole.CustomerPlugin;
using NUnit.Framework;
using VisitPlugin;

namespace Ef.Tests
{
    [TestFixture]
    public class PluginTests : BaseTest
    {
        private CustomerPluginConfiguration customerConfig;
        private VisitPluginConfiguration visitConfig;

        [SetUp]
        public override void Setup()
        {
            base.Setup();

            customerConfig = new CustomerPluginConfiguration();
            visitConfig = new VisitPluginConfiguration();
        }

        [Test]
        public void can_install_customer()
        {
            customerConfig.Install();

            using (var customerContext = new CustomerContext())
            {
                var list = customerContext.Customers.ToList();

                Assert.AreNotEqual(0, list.Count);
            }
        }

        [Test]
        [ExpectedException(typeof(AutomaticMigrationsDisabledException))]
        public void can_uninstall_customer()
        {
            customerConfig.Install();

            customerConfig.Uninstall();

            using (var customerContext = new CustomerContext())
            {
                var list = customerContext.Customers.ToList();
            }
        }

        [Test]
        public void can_install_visit()
        {
            visitConfig.Install();

            using (var visitContext = new VisitContext())
            {
                var list = visitContext.Visits.ToList();

                Assert.AreNotEqual(0, list.Count);
            }
        }

        [Test]
        [ExpectedException(typeof(AutomaticMigrationsDisabledException))]
        public void can_uninstall_visit()
        {
            visitConfig.Install();

            visitConfig.Uninstall();

            using (var visitContext = new VisitContext())
            {
                var list = visitContext.Visits.ToList();
            }
        }



    }
}
