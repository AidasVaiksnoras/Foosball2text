using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class LastGameController : Controller
    {
        // GET: LastGame
        public ActionResult Index()
        {
            return View();
        }
    }
}