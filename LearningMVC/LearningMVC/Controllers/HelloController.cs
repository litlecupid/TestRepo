using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC.Controllers
{
    public class HelloController:IController
    {
        public void Execute(System.Web.Routing.RequestContext requestContext)
        {
            requestContext.HttpContext.Response.Write("Hello Word");
        }
    }
}