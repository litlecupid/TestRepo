using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace LearningMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /default/

        public ViewResult Index()
        {
          
            return View();
        }

    }
}
