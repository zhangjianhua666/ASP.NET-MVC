using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2.Models;
namespace T2.Controllers
{
    
    public class SysuserController : Controller
    {
        fashionshoppingDBEntities db = new fashionshoppingDBEntities();
        // GET: Sysuser
        public ActionResult Index()
        {
            ViewBag.Title = "欢迎进入后台用户管理-查询";
            ViewData["sysuser"] = db.Sysuser.ToList();
            return View();
        }
        public ActionResult Details()
        {
            ViewBag.Title = "欢迎进入后台用户管理-详情查看";
            string id = Request["id"];
            if (!string.IsNullOrEmpty(id))
            {
                ViewBag.sysuser = db.Sysuser.Find(Int32.Parse(id));
            }
            return View();
        }
    }
}