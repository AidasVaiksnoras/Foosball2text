using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Helpers;
using WebApplication.Models;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class SearchController : Controller
    {

        public ActionResult Index(string id)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}
