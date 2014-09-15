using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProcessAutoTools.Controllers
{
    public class UsersController : Controller
    {
        [Route("IsValidUser/{UserName}")]
        public ActionResult IsValidUser(string UserName)
        {
            return View("Users", false);
        }
	}
}