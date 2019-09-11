using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myhtml.Models.Home;
using BaseLibrary;


namespace myhtml.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            IndexModel model1 = new IndexModel();
            model1.text = "測試~測試~";
            return View(model1);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AboutMe()
        {
            return View();
        }
    }
}