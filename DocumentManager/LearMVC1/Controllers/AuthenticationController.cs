using System;
using System.Web.Mvc;
using System.Web.Security;
using LearMVC1.BL;
using LearMVC1.Models;

namespace LearMVC1.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }

       
        public ActionResult DoLogin(UserDetails u)
        {
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
                UserStatus status = bal.GetUserValied(u);
                bool IsAdmin = false;
                if (status == UserStatus.AuthenticatedAdmin)
                {
                    IsAdmin = true;
                }
                else if (status == UserStatus.AuthenticatedUser)
                {
                    IsAdmin = false;
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Invalid UserName or Password");
                    return View("Login");
                }

                FormsAuthentication.SetAuthCookie(u.UserName, false);
                Session["IsAdmin"] = IsAdmin;
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View("Login");
            }
        }
    }
}