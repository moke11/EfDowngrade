using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using EfConsole.CustomerPlugin;
using VisitPlugin;

namespace Ef.Tests
{
    [TestFixture]
    public class DatabaseTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void can_create_customer_context()
        {
            using (var customerContext = new CustomerContext())
            {
                var list = customerContext.Customers.ToList();
                list.ForEach(x => { Console.WriteLine("{0}", x.LastName); });
            }
        }

        [Test]
        public void can_create_visit_context()
        {
            using (var context = new VisitContext())
            {
                var list = context.Visits.ToList();
                list.ForEach(x => { Console.WriteLine("{0}", x.IpAddress); });
            }
        }

        [Test]
        public void can_create_both_schemas()
        {
            using (var customerContext = new CustomerContext())
            {
                var list = customerContext.Customers.ToList();
                list.ForEach(x => { Console.WriteLine("{0}", x.LastName); });
            }

            using (var context = new VisitContext())
            {
                var list = context.Visits.ToList();
                list.ForEach(x => { Console.WriteLine("{0}", x.IpAddress); });
            }
        }
     
    }
}
