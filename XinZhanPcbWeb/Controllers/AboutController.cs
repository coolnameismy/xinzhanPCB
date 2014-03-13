using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XinZhanPcbWeb.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /AboutUs/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Introduce()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
