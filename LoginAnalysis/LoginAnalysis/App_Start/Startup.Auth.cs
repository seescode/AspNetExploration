using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace LoginAnalysis
{
	public partial class Startup
	{
		public void ConfigureAuth(IAppBuilder app)
		{
			
			// Enable the application to use a cookie to store information for the signed in user
			app.UseCookieAuthentication(new CookieAuthenticationOptions
			{
				AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
				CookieName = "atom.web",
				LoginPath = new PathString("/home/index"),
				ExpireTimeSpan = new System.TimeSpan(24, 0, 0),
				SlidingExpiration = true
			});
	
		}
	}
}