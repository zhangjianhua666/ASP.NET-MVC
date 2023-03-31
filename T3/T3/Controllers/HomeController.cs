using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T3.Models;

namespace T3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        /// <summary>
        /// 3-1作业
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Product p) {
            ViewBag.Info = "您输入了名称为" + p.Name + "的商品" + p.Num + "件";
            return View();
        }
        /// <summary>
        /// 3-2作业
        /// </summary>
        /// <returns></returns>
        public ActionResult Index3_2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index3_2(string id,int? fx,string pl)
        {
            ViewBag.Info = id+"提交的评论信息是" + pl + "，评分" + fx ;
            return View();
        }

        public ActionResult Index3_3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Buy3_3(IList<string> personName)
        {
            ViewBag.persons = personName;
            return View();
        }
        public ActionResult Index3_4()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index3_4(HttpPostedFileBase file)
        {
            if (file!=null)
            {
                if (file.ContentLength==0)
                {
                    return View();
                }
                else
                {
                    file.SaveAs(Server.MapPath("~/uploadFile/"+file.FileName));
                }
            }
            return View();
        }

    }
}