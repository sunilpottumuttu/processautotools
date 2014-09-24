using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProcessAutoTools.POCOS;
using ProcessAutoTools.BL;
using System.ComponentModel.DataAnnotations;
using ProcessAutoTools.Extensions;

namespace ProcessAutoTools.Controllers
{
    public class UsersController : Controller
    {

        [Route("Login")]
        public ActionResult Login()
        {
            ViewData["UserName"] = string.Empty;
            ViewData["PassWord"] = string.Empty;
            ViewData["Message"] = string.Empty;
            return View("Users", false);
        }

        [Route("Users/Validate")]
        public ActionResult ValidateUser()
        {
            
            string userName = HttpContext.Request.Form["txtUserName"].ToString();
            string passWord = HttpContext.Request.Form["txtPassword"].ToString();

            using (var context = new ProcessAutoToolsBLContext())
            {
                var user = context.GetUsersByUserName(userName, passWord);
                if (user == null)
                {
                    ViewData["UserName"] = userName;
                    ViewData["PassWord"] = passWord;
                    ViewData["Message"] = "Invalid User";
                    return View("Users", false);
                }
                else
                {
                    return this.Redirect("~/Projects");
                }
            }

            
            
        }

        

       
	}
}