using Krokot.Database;
using Krokot.Web.Models;
using Krokot.Web.Models.Home;
using Krokot.Web.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPlatform; 

namespace Krokot.Web.Controllers
{
    public class HomeController : LoginPageController
    {

        public override void Startup()
        {
            
        }

        public ActionResult Index()
        { 
            ContentRepository tole = new ContentRepository();

            var result = tole.GetContent(null);

            return View(result);
        }

    }
}
