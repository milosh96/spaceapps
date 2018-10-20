using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceApp.Controllers
{

    public class LaunchesController : Controller
    {
        public static List<Trajectory> launches;
        // GET: Launches
        public ActionResult Index()
        {
            return View();
        }
    }
}