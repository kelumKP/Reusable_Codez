using CLMVCApp.SingletonImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SingletonClass oneObject = SingletonClass.GetInstance;
            ViewBag.OutPutVal = oneObject.Multiplication("2");
            return View();
        }
    }
}
