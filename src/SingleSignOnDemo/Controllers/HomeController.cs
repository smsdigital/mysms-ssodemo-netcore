using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SingleSignOnDemo.Controllers
{
    public class HomeController : Controller
    {
        public bool Index()
        {
            return Login(Request.Query["mysms_group[auth]"]);
        }

        public IActionResult Error()
        {
            return View();
        }

        [Route("/Login/token")]
        public bool Login(string token)
        {
            return SSOExample.Login(token);
        }
    }
}
