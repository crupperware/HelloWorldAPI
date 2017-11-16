using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Services.Tests
{
    [TestClass()]
    public class HelloServiceTests
    {
        [TestMethod()]
        public void GetHelloTest()
        {
            var condition = "Hello World";

            var serv = new HelloService();

            if (serv == null)
            {
                Assert.Fail("Service failed to be defined");
            }

            var results = serv.GetHello();

            if (results == null)
            {
                Assert.Fail("Get Hello returned null value");
            }
            else if (results.greeting != condition)
            {
                Assert.Fail();
            }
        }
    }
}