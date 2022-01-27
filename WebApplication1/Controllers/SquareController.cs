using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {
        //returns the square of the integer input
        // api/square/4à
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}