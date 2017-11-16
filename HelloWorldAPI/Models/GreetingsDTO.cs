using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldAPI.Models
{
    public class GreetingsDTO
    {
        public string greeting { get; set; }

        public GreetingsDTO() { }
        public GreetingsDTO(string greeting)
        {
            this.greeting = greeting;
        }
    }
}