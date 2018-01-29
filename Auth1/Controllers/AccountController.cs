using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Auth1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string name)
        {
            FormsAuthentication.SignOut(); 
            FormsAuthentication.Initialize();
            FormsAuthentication.RedirectFromLoginPage(name, false);
            return Redirect("http://localhost:5194/");
        }
    }
}