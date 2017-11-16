using HelloWorldAPI.Models;
using HelloWorldAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace HelloWorldAPI.Controllers
{
    public class HelloController : ApiController
    {
        private HelloService helloService;

        public HelloController()
        {
            helloService = new HelloService();
        }

        public GreetingsDTO GetHello()
        {
            var results = helloService.GetHello();

            return results;
        }
    }
}
