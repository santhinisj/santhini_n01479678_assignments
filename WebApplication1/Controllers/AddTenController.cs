using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {
        // ------- 1
        // GET api/AddTen/5
        // to add a number with 10
        public int Get(int id)
        {
            int numberPlusTen = id + 10;
            return numberPlusTen;
        }
    }
}