using PayrollSystemV1_0__Beta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayrollSystemV1_0__Beta.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "This is the first greeting that we could have     ~Mohit";
            return View();
        }
    }
}
