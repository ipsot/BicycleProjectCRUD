using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientBicycleWebApp.Controllers
{
    public class BicycleClientController : Controller
    {
        // GET: BicycleClient
        public ActionResult Index()
        {
            return View();
        }
    }
}