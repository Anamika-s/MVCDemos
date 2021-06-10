using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {

     List<String> breakingNews = new List<String>()      //DO NOT change this declaration and values
        {
            "PM visit brings business","10% slash in GST","Top Player announced retirement","India wins series"
        };

        public ActionResult NewsByChoice(int id)
        {
            return Content(breakingNews[id].ToString());
        }// Implement 'NewsByChoice' acti
        public ActionResult Index()
        {
            return View();
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


        [HttpGet]
        public ActionResult AddNumbers1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNumbers1(string txtNo1, string txtNo2)
        {
            int res = int.Parse(txtNo1) + int.Parse(txtNo2);
            ViewBag.res = res;
            return View();
        }

    }
}