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
        // ------------------- 6
        // The input {id} represents the number of days which has elapse since the beginning of the hosting.
        // Prices are $5.50 / FN (fortnight = 14 days) for web hosting and maintenance, plus an additional 13% HST.
        // Output 3 strings which describe the total hosting cost
        // GET api/hostingcost/10

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