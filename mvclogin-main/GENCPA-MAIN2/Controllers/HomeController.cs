using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GENCPA_MAIN2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: AdminCategory
        public ActionResult Index()
        {
            return View();
        }
    }
}