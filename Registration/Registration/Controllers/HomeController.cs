using Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private context homeContext = new context();
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }
        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register reg)
        {
           
                homeContext.Registers.Add(reg);
                homeContext.SaveChanges();
                return RedirectToAction("Login");
            
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Register loginUser)
        {
            if (isValidUser(loginUser.Email, loginUser.Password))
            {
                return RedirectToAction("Main");
            }
            else {
                ModelState.AddModelError("","Please check Email and password...");
                return View(loginUser);
            }
            
        }
        public bool isValidUser(String em,String pw) {
            bool valid = false;
            int count = homeContext.Registers.Count(x=>x.Email==em && x.Password==pw);
            if (count==1)
            {
                valid = true;
            }
            return valid;
        }
        public bool compPw(String pw) {
            bool valid = false;
            int count = homeContext.Registers.Count(x=>x.Password==pw && x.ComfirmPassword==pw);
            if (count == 1)
            {
                valid = true;
            }
            return valid;
        }
    }
}