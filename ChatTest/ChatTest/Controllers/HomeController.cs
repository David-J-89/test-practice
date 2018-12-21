using ChatTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                return Redirect("/chat");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class AuthController : Controller
    {
        [HttpPost]
        public ActionResult Login()
        {
            string user_name = Request.Form["username"];

            if (user_name.Trim() == "")
            {
                return Redirect("/");
            }

            using (var db = new Models.ChatContext())
            {
                User user = db.Users.FirstOrDefault(u => u.name == user_name);

                if (user == null)
                {
                    user = new User { name = user_name };

                    db.Users.Add(user);
                    db.SaveChanges();
                }

                Session["user"] = user;

                Session["user"] = user;
            }
            return Redirect("/chat");
        }
    }

    public class ChatController: Controller
    {
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return Redirect("/");
            }

            var currentUser = (Models.User)Session["user"];

            using ( var db = new Models.ChatContext())
            {
                ViewBag.allUsers = db.Users.Where(u => u.name != currentUser.name)
                    .ToList();
            }

            ViewBag.currentUser = currentUser;

            return View();
        }
    }
}