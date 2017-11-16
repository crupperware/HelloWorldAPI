using HelloWorldAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HelloWorldAPI.Services
{
    public class HelloService
    {

        public GreetingsDTO GetHello()
        {
            var results = new GreetingsDTO("Hello World");

            return results;
        }


    }
}