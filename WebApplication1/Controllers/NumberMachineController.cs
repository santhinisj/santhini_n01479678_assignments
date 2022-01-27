using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //--------------- 5
   
        // GET api/numbermachine/5
        public int Get(int id)
        {
            //this takes a number and do * , /, + , - operations the number and then outputs the result
            int result = ((id * id + id) / id) - id;
            return result;
        }

    }
}
