﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {
        // GET api/AddTen/5
        public int Get(int id)
        {
            int numberPlusTen = id + 10;
            return numberPlusTen;
        }
    }
}