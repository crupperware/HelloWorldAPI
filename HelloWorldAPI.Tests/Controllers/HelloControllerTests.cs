using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI.Services;

namespace HelloWorldAPI.Controllers.Tests
{
    [TestClass()]
    public class HelloControllerTests
    {
        [TestMethod()]
        public void GetHelloTest()
        {
            var condition = "Hello World";

            var hCon = new HelloController();

            if (hCon == null)
            {
                Assert.Fail("Service failed to be defined");
            }

            var results = hCon.GetHello(); 

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