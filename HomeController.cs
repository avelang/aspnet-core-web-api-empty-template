using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_web_api_empty_template
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {

        }
        [HttpGet]
        [Route("[action]")]
        public string Index()
        {
            decimal totSum = 0, count = 0;

            try
            {
                var inputString = Request.QueryString.Value.ToString().Replace("?q=", "").Split(",");
                foreach (var x in inputString)
                {
                    totSum += Convert.ToInt32(x);
                    count++;
                }

                return String.Format("Average is : {0}", totSum/count);
            }
            catch (Exception)
            {

                return "Input is in incorrect format";
            }

        }
    }
}
