using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WSS.DocumentHelp.Controllers
{
    public class ConfigController : Controller
    {
        // GET: Config
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}