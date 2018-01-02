using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDay4_AttributeRouting.Controllers
{

   
    public class HomeController : Controller
    {
        // GET: Home

        [Route("Default/{id?}")]
        public ActionResult About()
        {
            return View();
        }

    }
}