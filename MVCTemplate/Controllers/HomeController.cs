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
            LoginRepository repo = new LoginRepository();
            
            ApplicationSettings.Instance.UI.Theme = Theme.Blue;
            ApplicationSettings.Instance.Environment.ApplicationId = "100";
            string impersonateUser = repo.GetImpersonateUser(new
            {
                NetworkId = WebUtils.ParseUserLogon(HttpContext.User.Identity.Name),
                Application = ApplicationSettings.Instance.Environment.ApplicationId
            });

            if (!base.Login(impersonateUser))
            {
                return RedirectToAction(this.PageSettings.IndexPage, ApplicationSettings.Instance.Security.UnauthorizedControlller);
            }

            ContentRepository tole = new ContentRepository();

            var result = tole.GetContent(null);

            return View(result);
        }

    }
}
