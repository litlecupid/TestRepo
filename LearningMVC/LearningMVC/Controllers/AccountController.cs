﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            string userName = Model.userName;
            string passWord = passWord;
            return View();
        }

    }
}
