using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp
{
    [Route("app")]
    public class TestController : Controller
    {
        [HttpGet("thing", Name = "GetThing")]
        public IActionResult Thing()
        {
            return new HttpOkResult();
        }
    }
}

