using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapIntroduction.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult CalcApp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcApp(string ValA, string ValB, string Op)
        {

                int first = Convert.ToInt32(Request["first"]);
                int second = Convert.ToInt32(Request["second"]);
                string operation = Request["operator"];
                int answer = 0;

                switch (operation)
                {
                    case "add":
                        answer = first + second;
                        break;
                    case "subtract":
                        answer = first - second;
                        break;
                    case "multiply":
                        answer = first * second;
                        break;
                    case "divide":
                        answer = first / second;
                        break;
                }
            return View("CalcApp", (object)answer.ToString());
        }
    }
}