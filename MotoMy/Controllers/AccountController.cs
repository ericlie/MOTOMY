using MotoMy.Globals;
using MotoMy.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MotoMy.Models;
using System.Data.Objects;




namespace MotoMy.Controllers
{
    public class AccountController : GeneralController
    {
        protected User emp = null;

        public ActionResult Login()
        {
            //Sepertinya kita bahkan ga perlu menggunakan LDAP authentication,
            //karena LDAP authentication adalah proses dimana kita authenticate username dan password 
            //yang kita pass dari web client .. ke server ldap .. jadi kita cuma perlu ambil username login 
            //aja disini .. please check webconfig .. ada comment untuk windows user impersonation disana

            //sesimple ini mengambil login di windows, baru username ini di passing ke value 
            //di session handler setelah di check di table user

            //START
            //string activeUsername = HttpContext.User.Identity.Name;
            //END

            ViewData["ShowErr"] = "none";
            //return View();
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                
                if (validateLogin(login.Username, login.Password))
                {
                    
                    SessionHandler.ActiveUser = emp;
                    return RedirectToAction("Index", "Dashboard");
                    //return RedirectToAction("nabe");
                    /*
                    if (SessionHandler.ActiveUser.UserRoleId == 1)
                    {
                        return RedirectToAction("IndexDispatcher", "TravelRequest");
                    }
                    else
                    {
                        if (SessionHandler.ActiveUser.UserRoleId == 2)
                        {
                            return RedirectToAction("IndexAgent", "TravelRequest");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Dashboard");
                        }
                    }*/
                    
                }
                else
                {
                    return View(login);
                }
            }
            return RedirectToAction("Index", "Dashboard");
        }

        private bool validateLogin(String username, String password)
        {
            /*
            emp = db.Users.Where(x => x.UserName == username).FirstOrDefault();
            if (emp == null)
            {
                ViewData["ErrorMessage"] = "User is not found !";
                ViewData["ShowErr"] = "true";
                return false;
            }

            emp = db.Users.Where(x => x.UserName == username && x.RecordStatus == 2).FirstOrDefault();
            if (emp == null)
            {
                ViewData["ErrorMessage"] = "User is not registered to log in !";
                ViewData["ShowErr"] = "true";
                return false;
            }

            String md5Password = SharedMethod.CalculateMD5Hash(password);
            emp = db.Users.Where(x => x.UserName == username && x.Password == md5Password && x.RecordStatus == 1).FirstOrDefault();
            if (emp == null)
            {
                ViewData["ErrorMessage"] = "Username and Password do not match !";
                ViewData["ShowErr"] = "true";
                return false;
            }
            
            if(username != null && password != null)
            {
                return true;
            }
            */
            return true;
        }

        public ActionResult LogOut()
        {
            SessionHandler.ActiveUser = null;
            return RedirectToAction("Login");
        }

        public ActionResult nabe()
        {
            return View();
        }

    }
}
