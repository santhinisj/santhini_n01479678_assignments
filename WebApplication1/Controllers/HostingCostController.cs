using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get(int id)
        {
            int noOfFortNights = (id / 14)+1;
            float fortNightCost = (float)((float)noOfFortNights * 5.50);
            float hst = (float)(.13 * fortNightCost);
            float total = fortNightCost + hst;
            string fortNightDetails = noOfFortNights + " fortnights at $5.50/FN = $" + fortNightCost + " CAD";
            string hstDetails = "HST 13% = $" + hst + " CAD";
            string totalDetails = "Total = $" + total + " CAD";

            return new string[] { fortNightDetails, hstDetails, totalDetails };
        }

    }
}