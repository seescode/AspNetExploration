using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace LoginAnalysis.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
		[HttpGet]
		[AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }


		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public ActionResult Login()
		{
			SignIn();

			return View("Index");
		}


		private void SignIn()
		{
			var identity = new ClaimsIdentity(new[]
				{
					new Claim(ClaimTypes.Name, "Yong") 
				},
				DefaultAuthenticationTypes.ApplicationCookie,
				ClaimTypes.Name,
				ClaimTypes.Role);

			//In order to get access to GetOwinContext I had to nuget install Microsoft.Owin.Host.SystemWeb	
			HttpContext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties { IsPersistent = false}, identity);
		}
    }
}