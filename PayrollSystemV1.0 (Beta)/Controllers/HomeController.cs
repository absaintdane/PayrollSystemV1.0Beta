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
            return View();
<<<<<<< HEAD
            int y;
=======
        }
        // GET: /Home/Show
        public ActionResult Show()
        {
            return View("Show", new DB());
        }

        // GET: /Home/Set?first=x,last=y
        public ActionResult Set(string first, string last)
        {
            DB.WriteDB(first, last);
            ViewBag.First = first;
            ViewBag.Last = last;
            return View();
>>>>>>> 523ad01dd615a6857fec890c5dc5bc213579be02
        }
    }
}
