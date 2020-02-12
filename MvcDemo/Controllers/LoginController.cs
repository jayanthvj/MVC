using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class LoginController : Controller
    {
        public string LoginIndex()
        {
            ViewBag.title = "jai";
            return "welcome to Aspire Jayanth";
        }
    }
}