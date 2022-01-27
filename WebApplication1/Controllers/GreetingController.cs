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

        // ----------------- 3
        
        // post request that returns the string "Hello World!"
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        //---------------- 4
        //returns greetings text with the no of people entered from the request
        public string Get(int id)
        {
            string greetings = "Greetings to " + id + " people!";
            return greetings;
        }
    }
}