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
        public string get()
        {
            return "Hello from Home";
        }
    }
}
