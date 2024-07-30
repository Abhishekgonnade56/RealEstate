using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using RealEstate_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RealEstate_Management.Controllers
{
    public class LoginController : Controller
    {
        private Contextdb db = new Contextdb();
        // GET: Login
        public ActionResult Sign_In()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sign_In(string Email, string Password)
        {
            var user = db.Signups.FirstOrDefault(u => u.Email == Email && u.Password == Password);

            if (user != null)
            {
                // Add code to handle successful login (e.g., setting session variables)
                return RedirectToAction("Dashboard", "Admin");
            }

            ModelState.AddModelError("", "Invalid login attempt.");
            return View();
        }



        public ActionResult Sign_up()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sign_up(Signup user)
        {
            if (ModelState.IsValid)
            {
                db.Signups.Add(user);
                db.SaveChanges();
                return RedirectToAction("Sign_In");
            }

            return View(user);
        }
        public ActionResult Sign_out()
        {
            return View();
        }
    }
}