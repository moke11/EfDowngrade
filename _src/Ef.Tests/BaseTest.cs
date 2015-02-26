using EfConsole.CustomerPlugin;
using NUnit.Framework;

namespace Ef.Tests
{
    [TestFixture]
    public class BaseTest
    {
        [SetUp]
        public virtual void Setup()
        {
            DeleteDatabase();
        }

        [TearDown]
        public virtual void TearDown()
        {
        }
        protected void DeleteDatabase()
        {
            using (var customerContext = new CustomerContext())
            {
                customerContext.Database.Delete();
            }
        }
    }
}