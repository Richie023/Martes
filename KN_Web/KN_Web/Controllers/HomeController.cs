using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KN_Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Nos reedirecciona  al inicio de sesion
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
      
    }
}