using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace LearningMVC.Controllers
{
    public class ProcessController : Controller
    {
        //
        // GET: /Process/

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            var processList = from p in Process.GetProcesses()
                              select p;
            ViewData.Model = processList.ToList();
            return View();
        }
        public ViewResult Details(int id)
        {
            var process = (from p in Process.GetProcesses()
                           where p.Id == id
                           select p).Single();
            return View(process);
        }

    }
}
