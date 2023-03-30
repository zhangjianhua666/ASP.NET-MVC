using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2.Models;

namespace T2.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC";
            ViewData["myName"] = "My name is Tom";
            TempData["myAge"] = "I'm 20 years old";
            TempData["myNationality"] = "I'm from the U.S.A";
            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult Index2_2()
        {
            using (fashionshoppingDBEntities db = new fashionshoppingDBEntities())
            {
                ViewData["user"] = db.users.ToList();
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index2_3() {
            string name = Request["username"];
            string pwd = Request["pwd"];
            ViewBag.name = name;
            ViewBag.pwd = pwd;
            return View();
        }
        public ActionResult logein2_3()
        {

            return View();
        }


      
    }
}