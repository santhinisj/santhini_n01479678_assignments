using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {
        
        // returns the string "Hello World!"
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        public string Get(int id)
        {
            string greetings = "Greetings to " + id + " people!";
            return greetings;
        }
    }
}